using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DBDMatchmakingTracker {
    public partial class Form1 : Form {

        DataTable dt;
        int counter;

        RegionList regions;
        bool recordingGlobal = false;

        string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DBDMatchmakingLogger\";

        public Form1() {
            InitializeComponent();
        }
        
        public bool ValidateRequiredSettings() {
            return (bhvrSessionToken.TextLength > 0) && (killerQueue.Checked || survivorQueue.Checked) && (regionType.Text.Length > 0);
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!ValidateRequiredSettings()) {
                liveOutputBox.Text = "Cannot validate settings!\r\n" +
                    "Please make sure you have the following fields filled out:\r\n" +
                    "* Fill out the BHVR Session field with your bhvrSession ID (Found in response headers) \r\n" +
                    "* Select a region to analyze from the region dropdown field.\r\n" +
                    "* Make sure a role is selected to queue as.";
                return; 
            }
            if (QueueDataTimer.Enabled) { QueueDataTimer.Stop(); return; }

            ResetDataTable();

            counter = 0;
            QueueDataTimer.Start();
            counter -= (int)Math.Round((double)(QueueDataTimer.Interval / 1000));
            UpdateRequests();
        }

        public void ResetDataTable() {
            dt = new DataTable();
            dt.Columns.Add("Time", typeof(int));
            dt.Columns.Add("KLRs", typeof(int));
            dt.Columns.Add("SRVs", typeof(int));
            dt.Columns.Add("ETAs", typeof(double));
        }

        public void UpdateChart() {

            KLRCHRT.DataSource = dt;
            SRVCHRT.DataSource = dt;
            ETACHRT.DataSource = dt;

            KLRCHRT.Series["Killer Pool"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            SRVCHRT.Series["Survivor Pool"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ETACHRT.Series["Estimated Wait Times"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            KLRCHRT.Series["Killer Pool"].XValueMember = "Time";
            KLRCHRT.Series["Killer Pool"].YValueMembers = "KLRs";

            SRVCHRT.Series["Survivor Pool"].XValueMember = "Time";
            SRVCHRT.Series["Survivor Pool"].YValueMembers = "SRVs";

            ETACHRT.Series["Estimated Wait Times"].XValueMember = "Time";
            ETACHRT.Series["Estimated Wait Times"].YValueMembers = "ETAs";

            KLRCHRT.ChartAreas[0].AxisY.LabelStyle.Format = "";
            SRVCHRT.ChartAreas[0].AxisY.LabelStyle.Format = "";
            ETACHRT.ChartAreas[0].AxisY.LabelStyle.Format = "";

        }

        /// <summary>
        /// Gets the queue data from the Dead by Daylight backend. Spoofs a BHVR account with a unique BHVR session ID
        /// and then pretends to queue - thus receiving the server data.
        /// </summary>
        /// <param name="regionIndex">
        /// The index of the region you'd like to request queue data from.
        /// </param>
        /// <param name="recordMode">
        /// The way the program handles recording data to the data table and files.
        /// <para/>
        /// 0 = Don't record information
        /// <para/>
        /// 1 = Record to same file (SurvivorPool.csv, KillerPool.csv, EstimatedWaitTimes.csv)
        /// <para/>
        /// 2 = Record to folders based on region
        /// </param>
        public async Task<QueueData> GetQueueData(int regionIndex, bool recordData, bool recordToTable) {
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseCookies = false;

            HttpClient client = new HttpClient(handler);

            string url = "https://brill.live.bhvrdbd.com/api/v1/queue";
            string data = File.ReadAllText("requestData.json");

            dynamic requestData = JsonConvert.DeserializeObject(data);

            requestData = ConfigureRequestToUserSettings(requestData);

            data = JsonConvert.SerializeObject(requestData);

            //client.DefaultRequestHeaders.Add("User-Agent", "DeadByDaylight/++DeadByDaylight+Live-CL-546656 EGS/10.0.19044.1.256.64bit");
            client.DefaultRequestHeaders.Add("Cookie", "bhvrSession=" + bhvrSessionToken.Text);
            //client.DefaultRequestHeaders.Add("x-kraken-analytics-session-id", "1d5fcdbb-4a3d-63ca-6fca-52a51d2e42fc");
            //client.DefaultRequestHeaders.Add("x-kraken-client-os", "10.0.19044.1.256.64bit");
            client.DefaultRequestHeaders.Add("x-kraken-client-platform", "egs");
            //client.DefaultRequestHeaders.Add("x-kraken-client-provider", "egs");
            //client.DefaultRequestHeaders.Add("x-kraken-client-resolution", "1920x1080");
            //client.DefaultRequestHeaders.Add("x-kraken-client-timezone-offset", "240");
            //client.DefaultRequestHeaders.Add("x-kraken-client-version", "5.6.2");
            //client.DefaultRequestHeaders.Add("Accept", "*/*");
            //client.DefaultRequestHeaders.Add("Accept-Encoding", "deflate, gzip");


            client.DefaultRequestHeaders.ConnectionClose = true;

            var response = await client.PostAsync(url, new StringContent(data, Encoding.UTF8, "application/json"));
            string strResponse = await response.Content.ReadAsStringAsync();

            try {
                dynamic results = JsonConvert.DeserializeObject(strResponse);
                QueueData dataSample = new QueueData(int.Parse((string)results["queueData"]["sizeB"]), int.Parse((string)results["queueData"]["sizeA"]), double.Parse((string)results["queueData"]["ETA"]));

                if (recordData) {
                    RecordQueueData(dataSample, recordToTable);
                }

                return dataSample;
            } catch (Exception ex) {
                liveOutputBox.Text = "Exception at: " + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "\n" + ex.Source + "\n" + ex.Message + "\n" + ex.StackTrace;
                Console.WriteLine(liveOutputBox.Text);
                return null;
            }
        }

        public void RecordQueueData(QueueData queueData, bool recordToTable) {
            string currentRegion = regionType.Text.ToUpper();
            string regionString = "REGION " + currentRegion;

            if (allRegions.Checked) { regionString = "GLOBAL VALUES"; }
            if (recordingGlobal) { currentRegion = "GLOBAL"; }

            string resultsText = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + " - " + regionString +
                "\r\n----------------------------------------\r\n" +
                "KILLERS IN QUEUE: " + queueData.GetKlrPool() + "\r\n" +
                "SURVIVORS IN QUEUE: " + queueData.GetSurvPool() + "\r\n" +
                "CURRENT ESTIMATED WAIT TIME: " + (queueData.GetETA() / 1000).ToString("0.00") + " seconds" +
                "\r\n----------------------------------------\r\n";

            if (recordToTable) { dt.Rows.Add(counter, queueData.GetKlrPool(), queueData.GetSurvPool(), queueData.GetETA() / 1000); }


            using (StreamWriter sw = new StreamWriter(path + currentRegion + @"\KillerPool.csv", true)) {
                sw.WriteLine(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "," + queueData.GetKlrPool());
            }
            using (StreamWriter sw = new StreamWriter(path + currentRegion + @"\SurvivorPool.csv", true)) {
                sw.WriteLine(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "," + queueData.GetSurvPool());
            }
            using (StreamWriter sw = new StreamWriter(path + currentRegion + @"\EstimatedWaitTimes.csv", true)) {
                sw.WriteLine(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "," + (queueData.GetETA()).ToString("0.00"));
            }

            liveOutputBox.Text = resultsText;

        }

        public dynamic ConfigureRequestToUserSettings(dynamic request) {
            int i = 0;
            foreach (Region region in regions.GetRegionList()) {
                //Console.WriteLine("Examining Region \"" + request["latencies"][i]["regionName"] + "\" - Latency: " + request["latencies"][i]["latency"]);
                request["latencies"][i]["latency"] = region.GetLatency();
                request["latencies"][i]["regionName"] = region.GetRegionName();
                //Console.WriteLine("\tChanged Region \"" + request["latencies"][i]["regionName"] + "\" - Latency: " + request["latencies"][i]["latency"]);
                i++;
            }

            request["props"]["CrossplayOptOut"] = !crossplayEnabled.Checked;

            if (survivorQueue.Checked) { request["side"] = "B"; }
            else { request["side"] = "A"; }

            return request;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dt = new DataTable();
            dt.Columns.Add("Time", typeof(int));
            dt.Columns.Add("KLRs", typeof(int));    
            dt.Columns.Add("SRVs", typeof(int));
            dt.Columns.Add("ETAs", typeof(double));

            SetupRegions();
            SetupFiles();
        }

        public void SetupFiles() {
            List<Region> regionList = regions.GetRegionList();
            foreach(Region region in regionList) {
                string directoryPath = path + region.GetRegionName().ToUpper();
                if (!Directory.Exists(directoryPath)) {
                    Directory.CreateDirectory(directoryPath);
                }

                ValidateFiles(directoryPath);
            }

            if (!Directory.Exists(path + "GLOBAL")) {
                Directory.CreateDirectory(path + "GLOBAL");
            }
            ValidateFiles(path + "GLOBAL");
        }

        public void ValidateFiles(string directoryPath) {
            if (!File.Exists(directoryPath + @"\KillerPool.csv")) {
                using (StreamWriter sw = new StreamWriter(directoryPath + @"\KillerPool.csv", true)) {
                    sw.WriteLine("Time,Size");
                }
            }

            if (!File.Exists(directoryPath + @"\SurvivorPool.csv")) {
                using (StreamWriter sw = new StreamWriter(directoryPath + @"\SurvivorPool.csv", true)) {
                    sw.WriteLine("Time,Size");
                }
            }

            if (!File.Exists(directoryPath + @"\EstimatedWaitTimes.csv")) {
                using (StreamWriter sw = new StreamWriter(directoryPath + @"\EstimatedWaitTimes.csv", true)) {
                    sw.WriteLine("Time,ETAs");
                }
            }
        }

        public void SetupRegions() {
            List<Region> regionList = new List<Region>();
            IntRange unselectedRegionRange = new IntRange(100, 251);
            Random rand = new Random();

            foreach(string region in regionType.Items.OfType<string>()) {
                regionList.Add(new Region(rand.Next(unselectedRegionRange.GetMin(), unselectedRegionRange.GetMax()), region));
                Console.WriteLine("Added " + region);
            }

            regions = new RegionList(
                regionList,
                (regionType.SelectedIndex == 0),
                0
                );
            regionType.SelectedIndex = regions.GetSelectedRegion();
        }

        private void QueueDataTimer_Tick(object sender, EventArgs e) {
            UpdateRequests();
        }

        public async void UpdateRequests() {
            counter += (int)Math.Round((double)(QueueDataTimer.Interval / 1000));
            if (allRegions.Checked) {
                int sumSurv = 0, sumKlr = 0;
                List<double> regionEtas = new List<double>();
                List<Region> regionList = regions.GetRegionList();
                bool exceptionFound = false;
                for (int i = 0; i < regionList.Count; i++) {
                    try {
                        regionType.SelectedIndex = i;
                        QueueData queueData = await GetQueueData(regionType.SelectedIndex, true, false);
                        sumSurv += queueData.GetSurvPool();
                        sumKlr += queueData.GetKlrPool();
                        regionEtas.Add(queueData.GetETA());

                    

                        Console.WriteLine("Analyzing Region " + regions.GetRegionList()[regionType.SelectedIndex].GetRegionName().ToUpper() + ":\n" +
                            "\tSurvs in queue: " + queueData.GetSurvPool() + "\n" +
                            "\tKlrs in queue: " + queueData.GetKlrPool() + "\n" +
                            "\tETA for region: " + queueData.GetETA());
                    } catch (Exception ex) {
                        exceptionFound = true;
                        break;
                    }
                }
                if (!exceptionFound) {
                    double sumEtas = 0;
                    foreach (double eta in regionEtas) {
                        sumEtas += eta;
                    }
                    double avgEta = sumEtas / regionEtas.Count;

                    QueueData summedData = new QueueData(sumSurv, sumKlr, avgEta);

                    recordingGlobal = true;
                    RecordQueueData(summedData, true);
                    recordingGlobal = false;
                }
            } else {
                QueueData queueData = await GetQueueData(regionType.SelectedIndex, true, true);
                Console.WriteLine("Current Queue Data Shows: " + queueData.GetSurvPool() + " survivors are in queue!");
            }
            UpdateChart();
            if (dt.Rows.Count > 100) {
                dt.Rows.RemoveAt(0);
            }
            rawTable.DataSource = dt;
        }

        private void intervalBar_ValueChanged(object sender, EventArgs e) {
            TrackBar trackBar = (TrackBar)sender;
            intervalDisplay.Value = trackBar.Value;

            QueueDataTimer.Interval = trackBar.Value * 1000;
        }

        private void intervalDisplay_ValueChanged(object sender, EventArgs e) {
            NumericUpDown numUpDown = (NumericUpDown)sender;

            intervalBar.Value = (int)Math.Round(numUpDown.Value);

            QueueDataTimer.Interval = intervalBar.Value * 1000;
        }

        private void regionType_SelectedIndexChanged(object sender, EventArgs e) {
            IntRange unselectedRegionRange = new IntRange(150, 251);
            Random rand = new Random();

            regions.SetSelectedRegion(regionType.SelectedIndex);
            for (int i = 0; i < regions.GetRegionList().Count; i++) {
                regions.SetRegionLatency(i, rand.Next(unselectedRegionRange.GetMin(), unselectedRegionRange.GetMax()));
            }
            regions.SetRegionLatency(regionType.SelectedIndex, 50);
            Console.WriteLine("Selected Region is " + regions.GetRegion(regions.GetSelectedRegion()).GetRegionName());
        }

        private void allRegions_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked) {
                regionType.Enabled = false;
                regions.SetRegionPreference(false);
                intervalDisplay.Value = 10;
                intervalDisplay.Minimum = 10;
                intervalBar.Minimum = 10;

                return;
            }

            regionType.Enabled = true;
            regions.SetRegionPreference(true);
            intervalDisplay.Minimum = 1;
            intervalBar.Minimum = 1;

        }
    }
}

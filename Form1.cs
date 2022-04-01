using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class DBDQueueAnalyzer : Form {

        DataTable dt;
        int counter;

        RegionList regions;
        bool recordingGlobal = false;
        string prevIntervalText = "";

        bool queueSurvivor = true;

        string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DBDMatchmakingLogger\";
        string regionPath;
        string configPath;

        ConfigHandler config;

        bool dragging = false;
        Point dragOffset;

        public DBDQueueAnalyzer() {
            InitializeComponent();
        }
        
        public bool ValidateRequiredSettings() {
            return (bhvrSessionToken.TextLength > 0) && (regionType.Text.Length > 0);
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

            Label button = (Label)sender;

            if (QueueDataTimer.Enabled) { button.ForeColor = Color.FromArgb(0, 191, 0); button.Text = "Begin Recording Values"; QueueDataTimer.Stop(); return; }

            ResetDataTable();


            button.ForeColor = Color.FromArgb(255, 64, 64);
            button.Text = "Stop Recording Values";
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

            client.DefaultRequestHeaders.Add("Cookie", "bhvrSession=" + bhvrSessionToken.Text);
            client.DefaultRequestHeaders.Add("x-kraken-client-platform", platformChoice.Text);


            client.DefaultRequestHeaders.ConnectionClose = true;

            var response = await client.PostAsync(url, new StringContent(data, Encoding.UTF8, "application/json"));
            string strResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine(strResponse);

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

            string resultsText = "TIME: " + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "\n" +
                "REGION: " + regionString + "\n\n" +
                "KILLERS IN QUEUE: " + queueData.GetKlrPool() + "\r\n" +
                "SURVIVORS IN QUEUE: " + queueData.GetSurvPool() + "\r\n" +
                "CURRENT ESTIMATED WAIT TIME: " + (queueData.GetETA() / 1000).ToString("0.00") + " seconds";

            if (recordToTable) { dt.Rows.Add(counter, queueData.GetKlrPool(), queueData.GetSurvPool(), queueData.GetETA() / 1000); }


            using (StreamWriter sw = new StreamWriter(regionPath + currentRegion + @"\KillerPool.csv", true)) {
                sw.WriteLine(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "," + queueData.GetKlrPool());
            }
            using (StreamWriter sw = new StreamWriter(regionPath + currentRegion + @"\SurvivorPool.csv", true)) {
                sw.WriteLine(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "," + queueData.GetSurvPool());
            }
            using (StreamWriter sw = new StreamWriter(regionPath + currentRegion + @"\EstimatedWaitTimes.csv", true)) {
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

            if (queueSurvivor) { request["side"] = "B"; }
            else { request["side"] = "A"; }

            return request;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dragBar.Text = "Dead by Daylight Queue Pool Analyzer - Version " + Application.ProductVersion + " - Made by @SHADERSOP";
            regionPath = path + @"REGIONS\";
            configPath = path + @"config.json";


            rawTable.Columns.Clear();
            dt = new DataTable();
            dt.Columns.Add("Time", typeof(int));
            dt.Columns.Add("KLRs", typeof(int));    
            dt.Columns.Add("SRVs", typeof(int));
            dt.Columns.Add("ETAs", typeof(double));

            regionType.Region = new System.Drawing.Region(new Rectangle(3, 3, regionType.Width - 3, regionType.Height - 7));
            platformChoice.Region = new System.Drawing.Region(new Rectangle(3, 3, regionType.Width - 3, regionType.Height - 7));

            SetupRegions();
            SetupFiles();
            SetupConfig();
            CheckQueueAsStatus();
        }

        public void SetupFiles() {
            List<Region> regionList = regions.GetRegionList();
            foreach(Region region in regionList) {
                string directoryPath = regionPath + region.GetRegionName().ToUpper();
                if (!Directory.Exists(directoryPath)) {
                    Directory.CreateDirectory(directoryPath);
                }

                ValidateFiles(directoryPath);
            }

            if (!Directory.Exists(regionPath + "GLOBAL")) {
                Directory.CreateDirectory(regionPath + "GLOBAL");
            }
            ValidateFiles(regionPath + "GLOBAL");
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

        public void SetupConfig() {
            if (!File.Exists(configPath)) {
                CreateNewConfig();
            }

            try {
                config = JsonConvert.DeserializeObject<ConfigHandler>(File.ReadAllText(configPath));

                regionType.SelectedIndex = config.RegionPreference;
                platformChoice.SelectedIndex = config.PlatformPreference;
                allRegions.Checked = config.SniffAllRegions;

                queueSurvivor = config.QueueAsSurvivor;
                CheckQueueAsStatus();

            } catch (Exception ex) {
                CreateNewConfig();
                Console.WriteLine("Exception: " + ex.Message + "\n" + ex.StackTrace + "\n" + ex.Source);
            }
        }

        public void CreateNewConfig() {
            config = new ConfigHandler(true, 0, 0, false, true, Application.ProductVersion);
            string jsonConfig = JsonConvert.SerializeObject(config);
            File.WriteAllText(configPath, jsonConfig);
        }

        public void SaveConfig() {
            File.WriteAllText(configPath, JsonConvert.SerializeObject(config));
        }

        public void SetupRegions() {
            List<Region> regionList = new List<Region>();
            IntRange unselectedRegionRange = new IntRange(150, 251);
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
                try {
                    QueueData queueData = await GetQueueData(regionType.SelectedIndex, true, true);
                    Console.WriteLine("Current Queue Data Shows: " + queueData.GetSurvPool() + " survivors are in queue!");
                }
                catch (Exception ex) {
                    liveOutputBox.Text = "Exception at: " + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "\n" + ex.Source + "\n" + ex.Message + "\n" + ex.StackTrace;
                    Console.WriteLine(liveOutputBox.Text);
                }
            }
            UpdateChart();
            if (dt.Rows.Count > 100) {
                dt.Rows.RemoveAt(0);
            }
            rawTable.DataSource = dt;
            //rawTable.FirstDisplayedScrollingRowIndex = rawTable.Rows.Count - 1;

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

            try {
                config.RegionPreference = regionType.SelectedIndex;
                SaveConfig();
            } catch (Exception) {
                Console.WriteLine("Config is null");
            }
        }

        private void allRegions_CheckedChanged(object sender, EventArgs e) {
            config.SniffAllRegions = allRegions.Checked;
            SaveConfig();

            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked) {
                regionType.Enabled = false;
                regions.SetRegionPreference(false);
                blockPanel.Enabled = true;
                blockPanel.Visible = true;
                
                if (int.Parse(intervalBox.Text) < 15) {
                    intervalBox.Text = "15";
                }

                return;
            }

            blockPanel.Enabled = false;
            blockPanel.Visible = false;
            regionType.Enabled = true;
            regions.SetRegionPreference(true);

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            TextBox intervalBox = (TextBox)sender;
            int interval;
            bool isNumber = int.TryParse(intervalBox.Text, out interval);

            if (isNumber == false || (isNumber && (interval * 1000) < 0)) {
                intervalBox.Text = prevIntervalText;
                return;
            }

            QueueDataTimer.Interval = interval * 1000;
            prevIntervalText = intervalBox.Text;
        }

        private void LabelHoverStart(object sender, EventArgs e) {
            Label label = (Label)sender;

            short r = (short)(label.BackColor.R + 20);
            short g = (short)(label.BackColor.G + 20);
            short b = (short)(label.BackColor.B + 20);

            if (r > 255) { r = 255; }
            if (g > 255) { g = 255; }
            if (b > 255) { b = 255; }

            label.BackColor = Color.FromArgb(r, g, b);
        }

        private void LabelHoverEnd(object sender, EventArgs e) {
            Label label = (Label)sender;

            short r = (short)(label.BackColor.R - 20);
            short g = (short)(label.BackColor.G - 20);
            short b = (short)(label.BackColor.B - 20);

            if (r < 0) { r = 0; }
            if (g < 0) { g = 0; }
            if (b < 0) { b = 0; }

            label.BackColor = Color.FromArgb(r, g, b);

        }

        private void LabelClickStart(object sender, MouseEventArgs e) {
            LabelHoverStart(sender, null);
        }

        private void LabelClickEnd(object sender, MouseEventArgs e) {
            LabelHoverEnd(sender, null);
        }

        private void label8_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TextboxFocusEnter(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;

            short r = (short)(textBox.BackColor.R + 20);
            short g = (short)(textBox.BackColor.G + 20);
            short b = (short)(textBox.BackColor.B + 20);

            if (r > 255) { r = 255; }
            if (g > 255) { g = 255; }
            if (b > 255) { b = 255; }

            textBox.BackColor = Color.FromArgb(r, g, b);
        }

        private void TextboxFocusLeave(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;

            short r = (short)(textBox.BackColor.R - 20);
            short g = (short)(textBox.BackColor.G - 20);
            short b = (short)(textBox.BackColor.B - 20);

            if (r > 255) { r = 255; }
            if (g > 255) { g = 255; }
            if (b > 255) { b = 255; }

            textBox.BackColor = Color.FromArgb(r, g, b);
        }

        private void TextboxHoverStart(object sender, EventArgs e) {
            TextboxFocusEnter(sender, e);
        }

        private void TextboxHoverLeave(object sender, EventArgs e) {
            TextboxFocusLeave(sender, e);
        }

        private void ComboBoxFocusEnter(object sender, EventArgs e) {
            ComboBox comboBox = (ComboBox)sender;

            short r = (short)(comboBox.BackColor.R + 20);
            short g = (short)(comboBox.BackColor.G + 20);
            short b = (short)(comboBox.BackColor.B + 20);

            if (r > 255) { r = 255; }
            if (g > 255) { g = 255; }
            if (b > 255) { b = 255; }

            comboBox.BackColor = Color.FromArgb(r, g, b);
        }

        private void ComboBoxFocusLeave(object sender, EventArgs e) {
            ComboBox comboBox = (ComboBox)sender;

            short r = (short)(comboBox.BackColor.R - 20);
            short g = (short)(comboBox.BackColor.G - 20);
            short b = (short)(comboBox.BackColor.B - 20);

            if (r > 255) { r = 255; }
            if (g > 255) { g = 255; }
            if (b > 255) { b = 255; }

            comboBox.BackColor = Color.FromArgb(r, g, b);
        }

        public void CheckQueueAsStatus() {

            config.QueueAsSurvivor = queueSurvivor;
            SaveConfig();

            if (queueSurvivor) {
                queueAsSurvivor.BackColor = Color.FromArgb(0, 0, 255);
                queueAsSurvivor.ForeColor = Color.White;
                queueAsKiller.BackColor = Color.FromArgb(159, 16, 16);
                queueAsKiller.ForeColor = Color.FromArgb(159, 159, 159);
                return;
            }
            queueAsSurvivor.BackColor = Color.FromArgb(16, 16, 159);
            queueAsSurvivor.ForeColor = Color.FromArgb(159, 159, 159);
            queueAsKiller.BackColor = Color.FromArgb(255, 0, 0);
            queueAsKiller.ForeColor = Color.White;
        }
        private void queueAsSurvivor_Click(object sender, EventArgs e) {
            queueSurvivor = true;
            CheckQueueAsStatus();
        }

        private void queueAsKiller_Click(object sender, EventArgs e) {
            queueSurvivor = false;
            CheckQueueAsStatus();
        }

        private void DragStart(object sender, MouseEventArgs e) {
            LabelClickStart(sender, e);
            dragging = true;
            dragOffset = new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
        }

        private void DragEnd(object sender, MouseEventArgs e) {
            LabelClickEnd(sender, e);
            dragging = false;
        }

        private void DragMove(object sender, MouseEventArgs e) {
            if (dragging) {
                this.Location = new Point(Cursor.Position.X - dragOffset.X, Cursor.Position.Y - dragOffset.Y);
            }
        }

        private void clearGraphData_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories) {
                    Directory.Delete(directory, true);
                }
                Application.Restart();
            }
        }

        private void viewGraphFolder_Click(object sender, EventArgs e) {
            Process.Start(path);
        }

        private void kofi_Click(object sender, EventArgs e) {
            Process.Start("https://ko-fi.com/shadersop");
        }

        private void platformChoice_SelectedIndexChanged(object sender, EventArgs e) {
            config.PlatformPreference = platformChoice.SelectedIndex;
            SaveConfig();
        }
    }
}

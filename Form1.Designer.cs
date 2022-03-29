namespace DBDMatchmakingTracker {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StartAnalyzer = new System.Windows.Forms.Button();
            this.liveOutputBox = new System.Windows.Forms.TextBox();
            this.QueueDataTimer = new System.Windows.Forms.Timer(this.components);
            this.KLRCHRT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SRVCHRT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ETACHRT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.regionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bhvrSessionToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crossplayEnabled = new System.Windows.Forms.CheckBox();
            this.rawTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.survivorQueue = new System.Windows.Forms.RadioButton();
            this.killerQueue = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.intervalBar = new System.Windows.Forms.TrackBar();
            this.intervalDisplay = new System.Windows.Forms.NumericUpDown();
            this.allRegions = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.KLRCHRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRVCHRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETACHRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // StartAnalyzer
            // 
            this.StartAnalyzer.Location = new System.Drawing.Point(12, 472);
            this.StartAnalyzer.Name = "StartAnalyzer";
            this.StartAnalyzer.Size = new System.Drawing.Size(440, 37);
            this.StartAnalyzer.TabIndex = 0;
            this.StartAnalyzer.Text = "Toggle Timer (Get Queue Data Every Second)";
            this.StartAnalyzer.UseVisualStyleBackColor = true;
            this.StartAnalyzer.Click += new System.EventHandler(this.button1_Click);
            // 
            // liveOutputBox
            // 
            this.liveOutputBox.Location = new System.Drawing.Point(9, 12);
            this.liveOutputBox.Multiline = true;
            this.liveOutputBox.Name = "liveOutputBox";
            this.liveOutputBox.Size = new System.Drawing.Size(440, 127);
            this.liveOutputBox.TabIndex = 1;
            this.liveOutputBox.Text = " ";
            // 
            // QueueDataTimer
            // 
            this.QueueDataTimer.Interval = 1000;
            this.QueueDataTimer.Tick += new System.EventHandler(this.QueueDataTimer_Tick);
            // 
            // KLRCHRT
            // 
            this.KLRCHRT.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.KLRCHRT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.KLRCHRT.Legends.Add(legend1);
            this.KLRCHRT.Location = new System.Drawing.Point(458, 12);
            this.KLRCHRT.Name = "KLRCHRT";
            this.KLRCHRT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Killer Pool";
            this.KLRCHRT.Series.Add(series1);
            this.KLRCHRT.Size = new System.Drawing.Size(712, 160);
            this.KLRCHRT.TabIndex = 2;
            this.KLRCHRT.Text = "chart1";
            // 
            // SRVCHRT
            // 
            this.SRVCHRT.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.SRVCHRT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SRVCHRT.Legends.Add(legend2);
            this.SRVCHRT.Location = new System.Drawing.Point(458, 178);
            this.SRVCHRT.Name = "SRVCHRT";
            this.SRVCHRT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Survivor Pool";
            this.SRVCHRT.Series.Add(series2);
            this.SRVCHRT.Size = new System.Drawing.Size(712, 160);
            this.SRVCHRT.TabIndex = 3;
            this.SRVCHRT.Text = "chart2";
            // 
            // ETACHRT
            // 
            this.ETACHRT.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.ETACHRT.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ETACHRT.Legends.Add(legend3);
            this.ETACHRT.Location = new System.Drawing.Point(458, 350);
            this.ETACHRT.Name = "ETACHRT";
            this.ETACHRT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Lime;
            series3.Legend = "Legend1";
            series3.Name = "Estimated Wait Times";
            this.ETACHRT.Series.Add(series3);
            this.ETACHRT.Size = new System.Drawing.Size(712, 160);
            this.ETACHRT.TabIndex = 4;
            this.ETACHRT.Text = "chart3";
            // 
            // regionType
            // 
            this.regionType.FormattingEnabled = true;
            this.regionType.Items.AddRange(new object[] {
            "ap-south-1",
            "eu-west-1",
            "ap-southeast-1",
            "ap-southeast-2",
            "eu-central-1",
            "ap-northeast-2",
            "ap-northeast-1",
            "us-east-1",
            "sa-east-1",
            "us-west-2"});
            this.regionType.Location = new System.Drawing.Point(57, 163);
            this.regionType.Name = "regionType";
            this.regionType.Size = new System.Drawing.Size(273, 21);
            this.regionType.TabIndex = 5;
            this.regionType.SelectedIndexChanged += new System.EventHandler(this.regionType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Region:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bhvrSessionToken
            // 
            this.bhvrSessionToken.Location = new System.Drawing.Point(93, 190);
            this.bhvrSessionToken.Name = "bhvrSessionToken";
            this.bhvrSessionToken.Size = new System.Drawing.Size(356, 20);
            this.bhvrSessionToken.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "BHVR Session:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crossplayEnabled
            // 
            this.crossplayEnabled.AutoSize = true;
            this.crossplayEnabled.Checked = true;
            this.crossplayEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crossplayEnabled.Location = new System.Drawing.Point(9, 214);
            this.crossplayEnabled.Name = "crossplayEnabled";
            this.crossplayEnabled.Size = new System.Drawing.Size(113, 17);
            this.crossplayEnabled.TabIndex = 9;
            this.crossplayEnabled.Text = "Crossplay Enabled";
            this.crossplayEnabled.UseVisualStyleBackColor = true;
            // 
            // rawTable
            // 
            this.rawTable.AllowUserToAddRows = false;
            this.rawTable.AllowUserToDeleteRows = false;
            this.rawTable.AllowUserToResizeColumns = false;
            this.rawTable.AllowUserToResizeRows = false;
            this.rawTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawTable.Location = new System.Drawing.Point(12, 280);
            this.rawTable.MultiSelect = false;
            this.rawTable.Name = "rawTable";
            this.rawTable.ReadOnly = true;
            this.rawTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawTable.Size = new System.Drawing.Size(440, 186);
            this.rawTable.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Raw Data Table:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // survivorQueue
            // 
            this.survivorQueue.AutoSize = true;
            this.survivorQueue.Checked = true;
            this.survivorQueue.Location = new System.Drawing.Point(83, 236);
            this.survivorQueue.Name = "survivorQueue";
            this.survivorQueue.Size = new System.Drawing.Size(64, 17);
            this.survivorQueue.TabIndex = 12;
            this.survivorQueue.TabStop = true;
            this.survivorQueue.Text = "Survivor";
            this.survivorQueue.UseVisualStyleBackColor = true;
            // 
            // killerQueue
            // 
            this.killerQueue.AutoSize = true;
            this.killerQueue.Location = new System.Drawing.Point(153, 236);
            this.killerQueue.Name = "killerQueue";
            this.killerQueue.Size = new System.Drawing.Size(47, 17);
            this.killerQueue.TabIndex = 13;
            this.killerQueue.Text = "Killer";
            this.killerQueue.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Queue Role:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data Collection Interval:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intervalBar
            // 
            this.intervalBar.AutoSize = false;
            this.intervalBar.LargeChange = 10;
            this.intervalBar.Location = new System.Drawing.Point(136, 142);
            this.intervalBar.Maximum = 3600;
            this.intervalBar.Minimum = 1;
            this.intervalBar.Name = "intervalBar";
            this.intervalBar.Size = new System.Drawing.Size(236, 21);
            this.intervalBar.TabIndex = 16;
            this.intervalBar.Value = 1;
            this.intervalBar.ValueChanged += new System.EventHandler(this.intervalBar_ValueChanged);
            // 
            // intervalDisplay
            // 
            this.intervalDisplay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.intervalDisplay.Location = new System.Drawing.Point(378, 142);
            this.intervalDisplay.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.intervalDisplay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalDisplay.Name = "intervalDisplay";
            this.intervalDisplay.Size = new System.Drawing.Size(70, 20);
            this.intervalDisplay.TabIndex = 17;
            this.intervalDisplay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalDisplay.ValueChanged += new System.EventHandler(this.intervalDisplay_ValueChanged);
            // 
            // allRegions
            // 
            this.allRegions.AutoSize = true;
            this.allRegions.Location = new System.Drawing.Point(345, 165);
            this.allRegions.Name = "allRegions";
            this.allRegions.Size = new System.Drawing.Size(103, 17);
            this.allRegions.TabIndex = 18;
            this.allRegions.Text = "Sniff All Regions";
            this.allRegions.UseVisualStyleBackColor = true;
            this.allRegions.CheckedChanged += new System.EventHandler(this.allRegions_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 521);
            this.Controls.Add(this.allRegions);
            this.Controls.Add(this.intervalDisplay);
            this.Controls.Add(this.intervalBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.killerQueue);
            this.Controls.Add(this.survivorQueue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rawTable);
            this.Controls.Add(this.crossplayEnabled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bhvrSessionToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regionType);
            this.Controls.Add(this.ETACHRT);
            this.Controls.Add(this.SRVCHRT);
            this.Controls.Add(this.KLRCHRT);
            this.Controls.Add(this.liveOutputBox);
            this.Controls.Add(this.StartAnalyzer);
            this.Name = "Form1";
            this.Text = "Dead by Daylight Matchmaking Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KLRCHRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRVCHRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETACHRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartAnalyzer;
        private System.Windows.Forms.TextBox liveOutputBox;
        private System.Windows.Forms.Timer QueueDataTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart KLRCHRT;
        private System.Windows.Forms.DataVisualization.Charting.Chart SRVCHRT;
        private System.Windows.Forms.DataVisualization.Charting.Chart ETACHRT;
        private System.Windows.Forms.ComboBox regionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bhvrSessionToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox crossplayEnabled;
        private System.Windows.Forms.DataGridView rawTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton survivorQueue;
        private System.Windows.Forms.RadioButton killerQueue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar intervalBar;
        private System.Windows.Forms.NumericUpDown intervalDisplay;
        private System.Windows.Forms.CheckBox allRegions;
    }
}


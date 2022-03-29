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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.liveOutputBox = new System.Windows.Forms.TextBox();
            this.QueueDataTimer = new System.Windows.Forms.Timer(this.components);
            this.KLRCHRT = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.allRegions = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SRVCHRT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ETACHRT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.KLRCHRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRVCHRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETACHRT)).BeginInit();
            this.SuspendLayout();
            // 
            // liveOutputBox
            // 
            this.liveOutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.liveOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.liveOutputBox.ForeColor = System.Drawing.Color.White;
            this.liveOutputBox.Location = new System.Drawing.Point(1, 30);
            this.liveOutputBox.Multiline = true;
            this.liveOutputBox.Name = "liveOutputBox";
            this.liveOutputBox.Size = new System.Drawing.Size(450, 107);
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
            this.KLRCHRT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.KLRCHRT.BorderlineWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.KLRCHRT.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            legend1.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.KLRCHRT.Legends.Add(legend1);
            this.KLRCHRT.Location = new System.Drawing.Point(452, 30);
            this.KLRCHRT.Name = "KLRCHRT";
            this.KLRCHRT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Killer Pool";
            this.KLRCHRT.Series.Add(series1);
            this.KLRCHRT.Size = new System.Drawing.Size(730, 161);
            this.KLRCHRT.TabIndex = 2;
            this.KLRCHRT.Text = "chart1";
            // 
            // regionType
            // 
            this.regionType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.regionType.Font = new System.Drawing.Font("Roboto", 9F);
            this.regionType.ForeColor = System.Drawing.Color.White;
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
            this.regionType.Location = new System.Drawing.Point(46, 171);
            this.regionType.Name = "regionType";
            this.regionType.Size = new System.Drawing.Size(405, 22);
            this.regionType.TabIndex = 5;
            this.regionType.SelectedIndexChanged += new System.EventHandler(this.regionType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Region:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bhvrSessionToken
            // 
            this.bhvrSessionToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.bhvrSessionToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bhvrSessionToken.Font = new System.Drawing.Font("Roboto", 10F);
            this.bhvrSessionToken.ForeColor = System.Drawing.Color.White;
            this.bhvrSessionToken.Location = new System.Drawing.Point(89, 156);
            this.bhvrSessionToken.Name = "bhvrSessionToken";
            this.bhvrSessionToken.Size = new System.Drawing.Size(362, 17);
            this.bhvrSessionToken.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "BHVR Session:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crossplayEnabled
            // 
            this.crossplayEnabled.AutoSize = true;
            this.crossplayEnabled.Checked = true;
            this.crossplayEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crossplayEnabled.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.crossplayEnabled.FlatAppearance.BorderSize = 15;
            this.crossplayEnabled.Font = new System.Drawing.Font("Roboto", 8F);
            this.crossplayEnabled.ForeColor = System.Drawing.Color.White;
            this.crossplayEnabled.Location = new System.Drawing.Point(4, 211);
            this.crossplayEnabled.Name = "crossplayEnabled";
            this.crossplayEnabled.Size = new System.Drawing.Size(118, 17);
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
            this.rawTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rawTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rawTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rawTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rawTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.rawTable.GridColor = System.Drawing.Color.White;
            this.rawTable.Location = new System.Drawing.Point(1, 271);
            this.rawTable.MultiSelect = false;
            this.rawTable.Name = "rawTable";
            this.rawTable.ReadOnly = true;
            this.rawTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawTable.Size = new System.Drawing.Size(450, 196);
            this.rawTable.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Raw Data Table:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // survivorQueue
            // 
            this.survivorQueue.AutoSize = true;
            this.survivorQueue.Checked = true;
            this.survivorQueue.Font = new System.Drawing.Font("Roboto", 8F);
            this.survivorQueue.ForeColor = System.Drawing.Color.White;
            this.survivorQueue.Location = new System.Drawing.Point(75, 228);
            this.survivorQueue.Name = "survivorQueue";
            this.survivorQueue.Size = new System.Drawing.Size(67, 17);
            this.survivorQueue.TabIndex = 12;
            this.survivorQueue.TabStop = true;
            this.survivorQueue.Text = "Survivor";
            this.survivorQueue.UseVisualStyleBackColor = true;
            // 
            // killerQueue
            // 
            this.killerQueue.AutoSize = true;
            this.killerQueue.Font = new System.Drawing.Font("Roboto", 8F);
            this.killerQueue.ForeColor = System.Drawing.Color.White;
            this.killerQueue.Location = new System.Drawing.Point(145, 228);
            this.killerQueue.Name = "killerQueue";
            this.killerQueue.Size = new System.Drawing.Size(51, 17);
            this.killerQueue.TabIndex = 13;
            this.killerQueue.Text = "Killer";
            this.killerQueue.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Queue Role:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto", 8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data Collection Interval (in seconds):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // allRegions
            // 
            this.allRegions.AutoSize = true;
            this.allRegions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allRegions.FlatAppearance.BorderSize = 15;
            this.allRegions.Font = new System.Drawing.Font("Roboto", 8F);
            this.allRegions.ForeColor = System.Drawing.Color.White;
            this.allRegions.Location = new System.Drawing.Point(5, 191);
            this.allRegions.Name = "allRegions";
            this.allRegions.Size = new System.Drawing.Size(109, 17);
            this.allRegions.TabIndex = 18;
            this.allRegions.Text = "Sniff All Regions";
            this.allRegions.UseVisualStyleBackColor = true;
            this.allRegions.CheckedChanged += new System.EventHandler(this.allRegions_CheckedChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1122, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dead by Daylight Queue Pool Analyzer - Version 1.0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Roboto Bk", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1124, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "_";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Roboto Bk", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1153, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "X";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(199, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 17);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "1";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label9.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(1, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(450, 48);
            this.label9.TabIndex = 25;
            this.label9.Text = "Begin Recording Values";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.button1_Click);
            // 
            // SRVCHRT
            // 
            this.SRVCHRT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SRVCHRT.BorderlineWidth = 0;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.SRVCHRT.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            legend2.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.SRVCHRT.Legends.Add(legend2);
            this.SRVCHRT.Location = new System.Drawing.Point(452, 192);
            this.SRVCHRT.Name = "SRVCHRT";
            this.SRVCHRT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            series2.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Survivor Pool";
            this.SRVCHRT.Series.Add(series2);
            this.SRVCHRT.Size = new System.Drawing.Size(730, 161);
            this.SRVCHRT.TabIndex = 26;
            this.SRVCHRT.Text = "chart1";
            // 
            // ETACHRT
            // 
            this.ETACHRT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ETACHRT.BorderlineWidth = 0;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.ETACHRT.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            legend3.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.ETACHRT.Legends.Add(legend3);
            this.ETACHRT.Location = new System.Drawing.Point(452, 354);
            this.ETACHRT.Name = "ETACHRT";
            this.ETACHRT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            series3.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            series3.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Estimated Wait Times";
            this.ETACHRT.Series.Add(series3);
            this.ETACHRT.Size = new System.Drawing.Size(730, 162);
            this.ETACHRT.TabIndex = 27;
            this.ETACHRT.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1182, 517);
            this.Controls.Add(this.ETACHRT);
            this.Controls.Add(this.SRVCHRT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.allRegions);
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
            this.Controls.Add(this.KLRCHRT);
            this.Controls.Add(this.liveOutputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Dead by Daylight Matchmaking Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KLRCHRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRVCHRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETACHRT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox liveOutputBox;
        private System.Windows.Forms.Timer QueueDataTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart KLRCHRT;
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
        private System.Windows.Forms.CheckBox allRegions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart SRVCHRT;
        private System.Windows.Forms.DataVisualization.Charting.Chart ETACHRT;
    }
}


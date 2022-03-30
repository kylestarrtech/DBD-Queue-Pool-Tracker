namespace DBDMatchmakingTracker {
    partial class DBDQueueAnalyzer {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.QueueDataTimer = new System.Windows.Forms.Timer(this.components);
            this.KLRCHRT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.regionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bhvrSessionToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crossplayEnabled = new System.Windows.Forms.CheckBox();
            this.rawTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.allRegions = new System.Windows.Forms.CheckBox();
            this.dragBar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.intervalBox = new System.Windows.Forms.TextBox();
            this.recordData = new System.Windows.Forms.Label();
            this.SRVCHRT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ETACHRT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.blockPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.queueAsSurvivor = new System.Windows.Forms.Label();
            this.queueAsKiller = new System.Windows.Forms.Label();
            this.liveOutputBox = new System.Windows.Forms.Label();
            this.viewGraphFolder = new System.Windows.Forms.Label();
            this.clearGraphData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.platformChoice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.KLRCHRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRVCHRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETACHRT)).BeginInit();
            this.SuspendLayout();
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
            this.KLRCHRT.Location = new System.Drawing.Point(401, 22);
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
            this.KLRCHRT.Size = new System.Drawing.Size(779, 164);
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
            this.regionType.Location = new System.Drawing.Point(53, 171);
            this.regionType.Name = "regionType";
            this.regionType.Size = new System.Drawing.Size(347, 22);
            this.regionType.TabIndex = 5;
            this.regionType.SelectedIndexChanged += new System.EventHandler(this.regionType_SelectedIndexChanged);
            this.regionType.Enter += new System.EventHandler(this.ComboBoxFocusEnter);
            this.regionType.Leave += new System.EventHandler(this.ComboBoxFocusLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
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
            this.bhvrSessionToken.Size = new System.Drawing.Size(311, 17);
            this.bhvrSessionToken.TabIndex = 7;
            this.bhvrSessionToken.Enter += new System.EventHandler(this.TextboxFocusEnter);
            this.bhvrSessionToken.Leave += new System.EventHandler(this.TextboxFocusLeave);
            this.bhvrSessionToken.MouseEnter += new System.EventHandler(this.TextboxHoverStart);
            this.bhvrSessionToken.MouseLeave += new System.EventHandler(this.TextboxHoverLeave);
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
            this.crossplayEnabled.Location = new System.Drawing.Point(5, 227);
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
            this.rawTable.AllowUserToOrderColumns = true;
            this.rawTable.AllowUserToResizeRows = false;
            this.rawTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rawTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rawTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rawTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rawTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.rawTable.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rawTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.rawTable.EnableHeadersVisualStyles = false;
            this.rawTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rawTable.Location = new System.Drawing.Point(0, 313);
            this.rawTable.MultiSelect = false;
            this.rawTable.Name = "rawTable";
            this.rawTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rawTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.rawTable.RowHeadersVisible = false;
            this.rawTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rawTable.Size = new System.Drawing.Size(402, 149);
            this.rawTable.TabIndex = 10;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Raw Data Table:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.allRegions.Location = new System.Drawing.Point(5, 209);
            this.allRegions.Name = "allRegions";
            this.allRegions.Size = new System.Drawing.Size(109, 17);
            this.allRegions.TabIndex = 18;
            this.allRegions.Text = "Sniff All Regions";
            this.allRegions.UseVisualStyleBackColor = true;
            this.allRegions.CheckedChanged += new System.EventHandler(this.allRegions_CheckedChanged);
            // 
            // dragBar
            // 
            this.dragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dragBar.Font = new System.Drawing.Font("Roboto Bk", 11F);
            this.dragBar.ForeColor = System.Drawing.Color.White;
            this.dragBar.Location = new System.Drawing.Point(1, 1);
            this.dragBar.Name = "dragBar";
            this.dragBar.Size = new System.Drawing.Size(926, 20);
            this.dragBar.TabIndex = 19;
            this.dragBar.Text = "Dead by Daylight Queue Pool Analyzer - Version 1.0 - Made by SHADERS";
            this.dragBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragStart);
            this.dragBar.MouseEnter += new System.EventHandler(this.LabelHoverStart);
            this.dragBar.MouseLeave += new System.EventHandler(this.LabelHoverEnd);
            this.dragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            this.dragBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragEnd);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Roboto Bk", 7F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1124, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "_";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelClickStart);
            this.label7.MouseEnter += new System.EventHandler(this.LabelHoverStart);
            this.label7.MouseLeave += new System.EventHandler(this.LabelHoverEnd);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelClickEnd);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Roboto Bk", 7F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1153, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "X";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelClickStart);
            this.label8.MouseEnter += new System.EventHandler(this.LabelHoverStart);
            this.label8.MouseLeave += new System.EventHandler(this.LabelHoverEnd);
            this.label8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelClickEnd);
            // 
            // intervalBox
            // 
            this.intervalBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.intervalBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intervalBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.intervalBox.ForeColor = System.Drawing.Color.White;
            this.intervalBox.Location = new System.Drawing.Point(199, 138);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(201, 17);
            this.intervalBox.TabIndex = 24;
            this.intervalBox.Text = "1";
            this.intervalBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.intervalBox.Enter += new System.EventHandler(this.TextboxFocusEnter);
            this.intervalBox.Leave += new System.EventHandler(this.TextboxFocusLeave);
            this.intervalBox.MouseEnter += new System.EventHandler(this.TextboxHoverStart);
            this.intervalBox.MouseLeave += new System.EventHandler(this.TextboxHoverLeave);
            // 
            // recordData
            // 
            this.recordData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.recordData.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.recordData.Location = new System.Drawing.Point(1, 462);
            this.recordData.Name = "recordData";
            this.recordData.Size = new System.Drawing.Size(399, 54);
            this.recordData.TabIndex = 25;
            this.recordData.Text = "Begin Recording Values";
            this.recordData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.recordData.Click += new System.EventHandler(this.button1_Click);
            this.recordData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelClickStart);
            this.recordData.MouseEnter += new System.EventHandler(this.LabelHoverStart);
            this.recordData.MouseLeave += new System.EventHandler(this.LabelHoverEnd);
            this.recordData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelClickEnd);
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
            this.SRVCHRT.Location = new System.Drawing.Point(401, 187);
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
            this.SRVCHRT.Size = new System.Drawing.Size(779, 164);
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
            this.ETACHRT.Location = new System.Drawing.Point(401, 352);
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
            this.ETACHRT.Size = new System.Drawing.Size(779, 164);
            this.ETACHRT.TabIndex = 27;
            this.ETACHRT.Text = "chart2";
            // 
            // blockPanel
            // 
            this.blockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.blockPanel.Enabled = false;
            this.blockPanel.Location = new System.Drawing.Point(56, 174);
            this.blockPanel.Name = "blockPanel";
            this.blockPanel.Size = new System.Drawing.Size(344, 15);
            this.blockPanel.TabIndex = 28;
            this.blockPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Queue As:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // queueAsSurvivor
            // 
            this.queueAsSurvivor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(159)))));
            this.queueAsSurvivor.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold);
            this.queueAsSurvivor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.queueAsSurvivor.Location = new System.Drawing.Point(1, 261);
            this.queueAsSurvivor.Name = "queueAsSurvivor";
            this.queueAsSurvivor.Size = new System.Drawing.Size(199, 35);
            this.queueAsSurvivor.TabIndex = 30;
            this.queueAsSurvivor.Text = "Survivor";
            this.queueAsSurvivor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.queueAsSurvivor.Click += new System.EventHandler(this.queueAsSurvivor_Click);
            this.queueAsSurvivor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelClickStart);
            this.queueAsSurvivor.MouseEnter += new System.EventHandler(this.LabelHoverStart);
            this.queueAsSurvivor.MouseLeave += new System.EventHandler(this.LabelHoverEnd);
            this.queueAsSurvivor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelClickEnd);
            // 
            // queueAsKiller
            // 
            this.queueAsKiller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.queueAsKiller.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold);
            this.queueAsKiller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.queueAsKiller.Location = new System.Drawing.Point(201, 261);
            this.queueAsKiller.Name = "queueAsKiller";
            this.queueAsKiller.Size = new System.Drawing.Size(199, 35);
            this.queueAsKiller.TabIndex = 31;
            this.queueAsKiller.Text = "Killer";
            this.queueAsKiller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.queueAsKiller.Click += new System.EventHandler(this.queueAsKiller_Click);
            this.queueAsKiller.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelClickStart);
            this.queueAsKiller.MouseEnter += new System.EventHandler(this.LabelHoverStart);
            this.queueAsKiller.MouseLeave += new System.EventHandler(this.LabelHoverEnd);
            this.queueAsKiller.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelClickEnd);
            // 
            // liveOutputBox
            // 
            this.liveOutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.liveOutputBox.Font = new System.Drawing.Font("Roboto Cn", 10F);
            this.liveOutputBox.ForeColor = System.Drawing.Color.White;
            this.liveOutputBox.Location = new System.Drawing.Point(1, 22);
            this.liveOutputBox.Name = "liveOutputBox";
            this.liveOutputBox.Size = new System.Drawing.Size(399, 115);
            this.liveOutputBox.TabIndex = 32;
            this.liveOutputBox.Text = "TIME: 2022-03-29 - 10:11:35 PM\r\nREGION: AP-SOUTH-1\r\n\r\nKILLERS IN QUEUE: 15\r\nSURVI" +
    "VORS IN QUEUE: 36\r\nCURRENT ESTIMATED WAIT TIME: 72.20 seconds";
            this.liveOutputBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewGraphFolder
            // 
            this.viewGraphFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.viewGraphFolder.Font = new System.Drawing.Font("Roboto Bk", 7F);
            this.viewGraphFolder.ForeColor = System.Drawing.Color.White;
            this.viewGraphFolder.Location = new System.Drawing.Point(1040, 1);
            this.viewGraphFolder.Name = "viewGraphFolder";
            this.viewGraphFolder.Size = new System.Drawing.Size(83, 20);
            this.viewGraphFolder.TabIndex = 33;
            this.viewGraphFolder.Text = "View Data Folder";
            this.viewGraphFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewGraphFolder.Click += new System.EventHandler(this.viewGraphFolder_Click);
            this.viewGraphFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelClickStart);
            this.viewGraphFolder.MouseEnter += new System.EventHandler(this.LabelHoverStart);
            this.viewGraphFolder.MouseLeave += new System.EventHandler(this.LabelHoverEnd);
            this.viewGraphFolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelClickEnd);
            // 
            // clearGraphData
            // 
            this.clearGraphData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.clearGraphData.Font = new System.Drawing.Font("Roboto Bk", 7F);
            this.clearGraphData.ForeColor = System.Drawing.Color.White;
            this.clearGraphData.Location = new System.Drawing.Point(928, 1);
            this.clearGraphData.Name = "clearGraphData";
            this.clearGraphData.Size = new System.Drawing.Size(112, 20);
            this.clearGraphData.TabIndex = 34;
            this.clearGraphData.Text = "Clear Data (Right Click)";
            this.clearGraphData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearGraphData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearGraphData_MouseClick);
            this.clearGraphData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelClickStart);
            this.clearGraphData.MouseEnter += new System.EventHandler(this.LabelHoverStart);
            this.clearGraphData.MouseLeave += new System.EventHandler(this.LabelHoverEnd);
            this.clearGraphData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelClickEnd);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto", 8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Platform Used:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // platformChoice
            // 
            this.platformChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.platformChoice.Font = new System.Drawing.Font("Roboto", 9F);
            this.platformChoice.ForeColor = System.Drawing.Color.White;
            this.platformChoice.FormattingEnabled = true;
            this.platformChoice.Items.AddRange(new object[] {
            "egs",
            "steam"});
            this.platformChoice.Location = new System.Drawing.Point(86, 187);
            this.platformChoice.Name = "platformChoice";
            this.platformChoice.Size = new System.Drawing.Size(314, 22);
            this.platformChoice.TabIndex = 35;
            // 
            // DBDQueueAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1182, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.platformChoice);
            this.Controls.Add(this.clearGraphData);
            this.Controls.Add(this.viewGraphFolder);
            this.Controls.Add(this.liveOutputBox);
            this.Controls.Add(this.queueAsKiller);
            this.Controls.Add(this.queueAsSurvivor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blockPanel);
            this.Controls.Add(this.ETACHRT);
            this.Controls.Add(this.SRVCHRT);
            this.Controls.Add(this.recordData);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dragBar);
            this.Controls.Add(this.allRegions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rawTable);
            this.Controls.Add(this.crossplayEnabled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bhvrSessionToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regionType);
            this.Controls.Add(this.KLRCHRT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DBDQueueAnalyzer";
            this.Text = "Dead by Daylight Queue Pool Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KLRCHRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRVCHRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETACHRT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer QueueDataTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart KLRCHRT;
        private System.Windows.Forms.ComboBox regionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bhvrSessionToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox crossplayEnabled;
        private System.Windows.Forms.DataGridView rawTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox allRegions;
        private System.Windows.Forms.Label dragBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox intervalBox;
        private System.Windows.Forms.Label recordData;
        private System.Windows.Forms.DataVisualization.Charting.Chart SRVCHRT;
        private System.Windows.Forms.DataVisualization.Charting.Chart ETACHRT;
        private System.Windows.Forms.Panel blockPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label queueAsSurvivor;
        private System.Windows.Forms.Label queueAsKiller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label liveOutputBox;
        private System.Windows.Forms.Label viewGraphFolder;
        private System.Windows.Forms.Label clearGraphData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox platformChoice;
    }
}


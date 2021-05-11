namespace demo_manager
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttons_Setting = new System.Windows.Forms.Button();
            this.gDemList = new System.Windows.Forms.GroupBox();
            this.butDLFinalizeSelected = new System.Windows.Forms.Button();
            this.butDLDelSelected = new System.Windows.Forms.Button();
            this.gridDemoList = new System.Windows.Forms.DataGridView();
            this.gridDLMapNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDLTimeTicks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDLTimeSecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDLMTicks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDLMTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDLHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butDLRefresh = new System.Windows.Forms.Button();
            this.gInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labRunnerName = new System.Windows.Forms.Label();
            this.labSegNum = new System.Windows.Forms.Label();
            this.boxSegNum = new System.Windows.Forms.TextBox();
            this.boxRunnerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridProcessedDemos = new System.Windows.Forms.DataGridView();
            this.gridPDMapNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPDTimeTicks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPDTimeSecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPDMTicks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPDMSecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPDHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butPDDelSelected = new System.Windows.Forms.Button();
            this.butHelpAndAbout = new System.Windows.Forms.Button();
            this.boxConsole = new System.Windows.Forms.TextBox();
            this.gConsole = new System.Windows.Forms.GroupBox();
            this.gLatestSeg = new System.Windows.Forms.GroupBox();
            this.boxLatestSeg = new System.Windows.Forms.TextBox();
            this.gDemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDemoList)).BeginInit();
            this.gInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcessedDemos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gConsole.SuspendLayout();
            this.gLatestSeg.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttons_Setting
            // 
            this.buttons_Setting.Location = new System.Drawing.Point(723, 158);
            this.buttons_Setting.Name = "buttons_Setting";
            this.buttons_Setting.Size = new System.Drawing.Size(75, 23);
            this.buttons_Setting.TabIndex = 0;
            this.buttons_Setting.Text = "Settings";
            this.buttons_Setting.UseVisualStyleBackColor = true;
            this.buttons_Setting.Click += new System.EventHandler(this.button1_Click);
            // 
            // gDemList
            // 
            this.gDemList.Controls.Add(this.butDLFinalizeSelected);
            this.gDemList.Controls.Add(this.butDLDelSelected);
            this.gDemList.Controls.Add(this.gridDemoList);
            this.gDemList.Location = new System.Drawing.Point(10, 26);
            this.gDemList.Name = "gDemList";
            this.gDemList.Size = new System.Drawing.Size(605, 331);
            this.gDemList.TabIndex = 1;
            this.gDemList.TabStop = false;
            this.gDemList.Text = "Raw Demos";
            // 
            // butDLFinalizeSelected
            // 
            this.butDLFinalizeSelected.Location = new System.Drawing.Point(493, 298);
            this.butDLFinalizeSelected.Name = "butDLFinalizeSelected";
            this.butDLFinalizeSelected.Size = new System.Drawing.Size(106, 23);
            this.butDLFinalizeSelected.TabIndex = 3;
            this.butDLFinalizeSelected.Text = "Process Selected";
            this.butDLFinalizeSelected.UseVisualStyleBackColor = true;
            this.butDLFinalizeSelected.Click += new System.EventHandler(this.butDLFinalizeSelected_Click);
            // 
            // butDLDelSelected
            // 
            this.butDLDelSelected.Location = new System.Drawing.Point(6, 298);
            this.butDLDelSelected.Name = "butDLDelSelected";
            this.butDLDelSelected.Size = new System.Drawing.Size(106, 23);
            this.butDLDelSelected.TabIndex = 2;
            this.butDLDelSelected.Text = "Delete Selected";
            this.butDLDelSelected.UseVisualStyleBackColor = true;
            this.butDLDelSelected.Click += new System.EventHandler(this.butDLDelSelected_Click);
            // 
            // gridDemoList
            // 
            this.gridDemoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDemoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridDLMapNames,
            this.gridDLTimeTicks,
            this.gridDLTimeSecs,
            this.gridDLMTicks,
            this.gridDLMTime,
            this.gridDLHash});
            this.gridDemoList.Location = new System.Drawing.Point(6, 19);
            this.gridDemoList.Name = "gridDemoList";
            this.gridDemoList.Size = new System.Drawing.Size(593, 273);
            this.gridDemoList.TabIndex = 0;
            this.gridDemoList.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.grids_SortCompare);
            // 
            // gridDLMapNames
            // 
            this.gridDLMapNames.HeaderText = "Map Name";
            this.gridDLMapNames.MinimumWidth = 150;
            this.gridDLMapNames.Name = "gridDLMapNames";
            this.gridDLMapNames.ReadOnly = true;
            this.gridDLMapNames.Width = 150;
            // 
            // gridDLTimeTicks
            // 
            this.gridDLTimeTicks.HeaderText = "Ticks";
            this.gridDLTimeTicks.Name = "gridDLTimeTicks";
            this.gridDLTimeTicks.ReadOnly = true;
            // 
            // gridDLTimeSecs
            // 
            this.gridDLTimeSecs.HeaderText = "Time";
            this.gridDLTimeSecs.Name = "gridDLTimeSecs";
            this.gridDLTimeSecs.ReadOnly = true;
            // 
            // gridDLMTicks
            // 
            this.gridDLMTicks.HeaderText = "Measured Ticks";
            this.gridDLMTicks.Name = "gridDLMTicks";
            this.gridDLMTicks.ReadOnly = true;
            // 
            // gridDLMTime
            // 
            this.gridDLMTime.HeaderText = "Measured Time";
            this.gridDLMTime.Name = "gridDLMTime";
            this.gridDLMTime.ReadOnly = true;
            // 
            // gridDLHash
            // 
            this.gridDLHash.HeaderText = "File Hash";
            this.gridDLHash.Name = "gridDLHash";
            this.gridDLHash.ReadOnly = true;
            // 
            // butDLRefresh
            // 
            this.butDLRefresh.Location = new System.Drawing.Point(643, 157);
            this.butDLRefresh.Name = "butDLRefresh";
            this.butDLRefresh.Size = new System.Drawing.Size(75, 23);
            this.butDLRefresh.TabIndex = 1;
            this.butDLRefresh.Text = "Refresh All";
            this.butDLRefresh.UseVisualStyleBackColor = true;
            this.butDLRefresh.Click += new System.EventHandler(this.butDLRefresh_Click);
            // 
            // gInfo
            // 
            this.gInfo.Controls.Add(this.tableLayoutPanel1);
            this.gInfo.Location = new System.Drawing.Point(643, 12);
            this.gInfo.Name = "gInfo";
            this.gInfo.Size = new System.Drawing.Size(215, 139);
            this.gInfo.TabIndex = 2;
            this.gInfo.TabStop = false;
            this.gInfo.Text = "Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labRunnerName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labSegNum, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.boxSegNum, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.boxRunnerName, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 107);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // labRunnerName
            // 
            this.labRunnerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labRunnerName.AutoSize = true;
            this.labRunnerName.Location = new System.Drawing.Point(3, 6);
            this.labRunnerName.Name = "labRunnerName";
            this.labRunnerName.Size = new System.Drawing.Size(73, 13);
            this.labRunnerName.TabIndex = 0;
            this.labRunnerName.Text = "Runner Name";
            // 
            // labSegNum
            // 
            this.labSegNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSegNum.AutoSize = true;
            this.labSegNum.Location = new System.Drawing.Point(3, 58);
            this.labSegNum.Name = "labSegNum";
            this.labSegNum.Size = new System.Drawing.Size(89, 13);
            this.labSegNum.TabIndex = 1;
            this.labSegNum.Text = "Segment Number";
            // 
            // boxSegNum
            // 
            this.boxSegNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxSegNum.Location = new System.Drawing.Point(3, 82);
            this.boxSegNum.Name = "boxSegNum";
            this.boxSegNum.Size = new System.Drawing.Size(196, 20);
            this.boxSegNum.TabIndex = 3;
            // 
            // boxRunnerName
            // 
            this.boxRunnerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxRunnerName.Location = new System.Drawing.Point(3, 29);
            this.boxRunnerName.Name = "boxRunnerName";
            this.boxRunnerName.Size = new System.Drawing.Size(196, 20);
            this.boxRunnerName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butPDDelSelected);
            this.groupBox1.Controls.Add(this.gridProcessedDemos);
            this.groupBox1.Location = new System.Drawing.Point(10, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processed Demos";
            // 
            // gridProcessedDemos
            // 
            this.gridProcessedDemos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProcessedDemos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridPDMapNames,
            this.gridPDTimeTicks,
            this.gridPDTimeSecs,
            this.gridPDMTicks,
            this.gridPDMSecs,
            this.gridPDHash});
            this.gridProcessedDemos.Location = new System.Drawing.Point(6, 19);
            this.gridProcessedDemos.Name = "gridProcessedDemos";
            this.gridProcessedDemos.Size = new System.Drawing.Size(593, 129);
            this.gridProcessedDemos.TabIndex = 0;
            this.gridProcessedDemos.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.grids_SortCompare);
            // 
            // gridPDMapNames
            // 
            this.gridPDMapNames.HeaderText = "Map Name";
            this.gridPDMapNames.MinimumWidth = 150;
            this.gridPDMapNames.Name = "gridPDMapNames";
            this.gridPDMapNames.ReadOnly = true;
            this.gridPDMapNames.Width = 150;
            // 
            // gridPDTimeTicks
            // 
            this.gridPDTimeTicks.HeaderText = "Ticks";
            this.gridPDTimeTicks.Name = "gridPDTimeTicks";
            this.gridPDTimeTicks.ReadOnly = true;
            // 
            // gridPDTimeSecs
            // 
            this.gridPDTimeSecs.HeaderText = "Time";
            this.gridPDTimeSecs.Name = "gridPDTimeSecs";
            this.gridPDTimeSecs.ReadOnly = true;
            // 
            // gridPDMTicks
            // 
            this.gridPDMTicks.HeaderText = "Measured Ticks";
            this.gridPDMTicks.Name = "gridPDMTicks";
            this.gridPDMTicks.ReadOnly = true;
            // 
            // gridPDMSecs
            // 
            this.gridPDMSecs.HeaderText = "Measured Time";
            this.gridPDMSecs.Name = "gridPDMSecs";
            this.gridPDMSecs.ReadOnly = true;
            // 
            // gridPDHash
            // 
            this.gridPDHash.HeaderText = "File Hash";
            this.gridPDHash.Name = "gridPDHash";
            this.gridPDHash.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gDemList);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 560);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Demo List";
            // 
            // butPDDelSelected
            // 
            this.butPDDelSelected.Location = new System.Drawing.Point(6, 154);
            this.butPDDelSelected.Name = "butPDDelSelected";
            this.butPDDelSelected.Size = new System.Drawing.Size(106, 23);
            this.butPDDelSelected.TabIndex = 4;
            this.butPDDelSelected.Text = "Delete Selected";
            this.butPDDelSelected.UseVisualStyleBackColor = true;
            this.butPDDelSelected.Click += new System.EventHandler(this.butPDDelSelected_Click);
            // 
            // butHelpAndAbout
            // 
            this.butHelpAndAbout.Location = new System.Drawing.Point(643, 187);
            this.butHelpAndAbout.Name = "butHelpAndAbout";
            this.butHelpAndAbout.Size = new System.Drawing.Size(155, 23);
            this.butHelpAndAbout.TabIndex = 6;
            this.butHelpAndAbout.Text = "Help and About";
            this.butHelpAndAbout.UseVisualStyleBackColor = true;
            this.butHelpAndAbout.Click += new System.EventHandler(this.butHelpAndAbout_Click);
            // 
            // boxConsole
            // 
            this.boxConsole.Font = new System.Drawing.Font("Consolas", 8F);
            this.boxConsole.Location = new System.Drawing.Point(6, 19);
            this.boxConsole.Multiline = true;
            this.boxConsole.Name = "boxConsole";
            this.boxConsole.ReadOnly = true;
            this.boxConsole.Size = new System.Drawing.Size(203, 154);
            this.boxConsole.TabIndex = 7;
            // 
            // gConsole
            // 
            this.gConsole.Controls.Add(this.boxConsole);
            this.gConsole.Location = new System.Drawing.Point(643, 394);
            this.gConsole.Name = "gConsole";
            this.gConsole.Size = new System.Drawing.Size(215, 179);
            this.gConsole.TabIndex = 8;
            this.gConsole.TabStop = false;
            this.gConsole.Text = "Debug Ouput";
            // 
            // gLatestSeg
            // 
            this.gLatestSeg.Controls.Add(this.boxLatestSeg);
            this.gLatestSeg.Location = new System.Drawing.Point(643, 216);
            this.gLatestSeg.Name = "gLatestSeg";
            this.gLatestSeg.Size = new System.Drawing.Size(215, 171);
            this.gLatestSeg.TabIndex = 9;
            this.gLatestSeg.TabStop = false;
            this.gLatestSeg.Text = "Latest Segment";
            // 
            // boxLatestSeg
            // 
            this.boxLatestSeg.Font = new System.Drawing.Font("Consolas", 8F);
            this.boxLatestSeg.Location = new System.Drawing.Point(6, 19);
            this.boxLatestSeg.Multiline = true;
            this.boxLatestSeg.Name = "boxLatestSeg";
            this.boxLatestSeg.ReadOnly = true;
            this.boxLatestSeg.Size = new System.Drawing.Size(203, 146);
            this.boxLatestSeg.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 585);
            this.Controls.Add(this.gLatestSeg);
            this.Controls.Add(this.gConsole);
            this.Controls.Add(this.butHelpAndAbout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.butDLRefresh);
            this.Controls.Add(this.gInfo);
            this.Controls.Add(this.buttons_Setting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(884, 624);
            this.Name = "MainWindow";
            this.Text = "Source Attempted Segment Organizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gDemList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDemoList)).EndInit();
            this.gInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProcessedDemos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.gConsole.ResumeLayout(false);
            this.gConsole.PerformLayout();
            this.gLatestSeg.ResumeLayout(false);
            this.gLatestSeg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttons_Setting;
        private System.Windows.Forms.GroupBox gDemList;
        private System.Windows.Forms.DataGridView gridDemoList;
        private System.Windows.Forms.Button butDLRefresh;
        private System.Windows.Forms.Button butDLDelSelected;
        private System.Windows.Forms.GroupBox gInfo;
        private System.Windows.Forms.Label labRunnerName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox boxRunnerName;
        private System.Windows.Forms.TextBox boxSegNum;
        private System.Windows.Forms.Label labSegNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridProcessedDemos;
        private System.Windows.Forms.Button butDLFinalizeSelected;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butPDDelSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDLMapNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDLTimeTicks;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDLTimeSecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDLMTicks;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDLMTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDLHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPDMapNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPDTimeTicks;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPDTimeSecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPDMTicks;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPDMSecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPDHash;
        private System.Windows.Forms.Button butHelpAndAbout;
        private System.Windows.Forms.TextBox boxConsole;
        private System.Windows.Forms.GroupBox gConsole;
        private System.Windows.Forms.GroupBox gLatestSeg;
        private System.Windows.Forms.TextBox boxLatestSeg;
    }
}


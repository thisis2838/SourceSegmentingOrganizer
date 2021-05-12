namespace demo_organizer.Window
{
    partial class SettingsWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.labWorkDir = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labFinalDir = new System.Windows.Forms.Label();
            this.labGameDir = new System.Windows.Forms.Label();
            this.labDefName = new System.Windows.Forms.Label();
            this.labTickrate = new System.Windows.Forms.Label();
            this.labDemName = new System.Windows.Forms.Label();
            this.labDefSaveName = new System.Windows.Forms.Label();
            this.tDemCollect = new System.Windows.Forms.TableLayoutPanel();
            this.boxDemName = new System.Windows.Forms.TextBox();
            this.boxWorkDir = new System.Windows.Forms.TextBox();
            this.butWorkDir = new System.Windows.Forms.Button();
            this.boxFinalDir = new System.Windows.Forms.TextBox();
            this.butFinalDir = new System.Windows.Forms.Button();
            this.gGameCollect = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlabDescEntries = new System.Windows.Forms.Label();
            this.tlabDescName = new System.Windows.Forms.Label();
            this.tlabTagName = new System.Windows.Forms.Label();
            this.tlabTagEntries = new System.Windows.Forms.Label();
            this.gDemSettings = new System.Windows.Forms.GroupBox();
            this.tDemSettings = new System.Windows.Forms.TableLayoutPanel();
            this.butGameDir = new System.Windows.Forms.Button();
            this.boxGameDir = new System.Windows.Forms.TextBox();
            this.boxDefName = new System.Windows.Forms.TextBox();
            this.boxTickrate = new System.Windows.Forms.TextBox();
            this.boxDefSaveName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.butOK = new System.Windows.Forms.Button();
            this.labDemNamingNote = new System.Windows.Forms.Label();
            this.labSaveNameNote = new System.Windows.Forms.Label();
            this.labDemNameNote = new System.Windows.Forms.Label();
            this.tDemCollect.SuspendLayout();
            this.gGameCollect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gDemSettings.SuspendLayout();
            this.tDemSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // labWorkDir
            // 
            this.labWorkDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labWorkDir.AutoSize = true;
            this.labWorkDir.Location = new System.Drawing.Point(3, 9);
            this.labWorkDir.Name = "labWorkDir";
            this.labWorkDir.Size = new System.Drawing.Size(92, 13);
            this.labWorkDir.TabIndex = 0;
            this.labWorkDir.Text = "Working Directory";
            this.labWorkDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.labWorkDir, "Place to put all finished segments");
            // 
            // labFinalDir
            // 
            this.labFinalDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labFinalDir.AutoSize = true;
            this.labFinalDir.Location = new System.Drawing.Point(3, 40);
            this.labFinalDir.Name = "labFinalDir";
            this.labFinalDir.Size = new System.Drawing.Size(74, 13);
            this.labFinalDir.TabIndex = 1;
            this.labFinalDir.Text = "Final Directory";
            this.toolTip1.SetToolTip(this.labFinalDir, "Place to put finished (correctly-named) demos");
            // 
            // labGameDir
            // 
            this.labGameDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labGameDir.AutoSize = true;
            this.labGameDir.Location = new System.Drawing.Point(3, 8);
            this.labGameDir.Name = "labGameDir";
            this.labGameDir.Size = new System.Drawing.Size(80, 13);
            this.labGameDir.TabIndex = 0;
            this.labGameDir.Text = "Game Directory";
            this.toolTip1.SetToolTip(this.labGameDir, "Directory from which to get demos");
            // 
            // labDefName
            // 
            this.labDefName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDefName.AutoSize = true;
            this.labDefName.Location = new System.Drawing.Point(3, 37);
            this.labDefName.Name = "labDefName";
            this.labDefName.Size = new System.Drawing.Size(66, 13);
            this.labDefName.TabIndex = 1;
            this.labDefName.Text = "Demo Name";
            this.toolTip1.SetToolTip(this.labDefName, "Default name of the demo files");
            // 
            // labTickrate
            // 
            this.labTickrate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTickrate.AutoSize = true;
            this.labTickrate.Location = new System.Drawing.Point(3, 96);
            this.labTickrate.Name = "labTickrate";
            this.labTickrate.Size = new System.Drawing.Size(46, 13);
            this.labTickrate.TabIndex = 2;
            this.labTickrate.Text = "Tickrate";
            this.toolTip1.SetToolTip(this.labTickrate, "Tickrate of the game");
            // 
            // labDemName
            // 
            this.labDemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDemName.AutoSize = true;
            this.labDemName.Location = new System.Drawing.Point(3, 72);
            this.labDemName.Name = "labDemName";
            this.labDemName.Size = new System.Drawing.Size(74, 13);
            this.labDemName.TabIndex = 8;
            this.labDemName.Text = "Demo Naming";
            this.toolTip1.SetToolTip(this.labDemName, "Naming convention for demos");
            // 
            // labDefSaveName
            // 
            this.labDefSaveName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDefSaveName.AutoSize = true;
            this.labDefSaveName.Location = new System.Drawing.Point(3, 66);
            this.labDefSaveName.Name = "labDefSaveName";
            this.labDefSaveName.Size = new System.Drawing.Size(63, 13);
            this.labDefSaveName.TabIndex = 8;
            this.labDefSaveName.Text = "Save Name";
            this.toolTip1.SetToolTip(this.labDefSaveName, "Default name of the save files");
            // 
            // tDemCollect
            // 
            this.tDemCollect.ColumnCount = 3;
            this.tDemCollect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tDemCollect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tDemCollect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tDemCollect.Controls.Add(this.boxDemName, 1, 2);
            this.tDemCollect.Controls.Add(this.labWorkDir, 0, 0);
            this.tDemCollect.Controls.Add(this.labFinalDir, 0, 1);
            this.tDemCollect.Controls.Add(this.boxWorkDir, 1, 0);
            this.tDemCollect.Controls.Add(this.butWorkDir, 2, 0);
            this.tDemCollect.Controls.Add(this.boxFinalDir, 1, 1);
            this.tDemCollect.Controls.Add(this.butFinalDir, 2, 1);
            this.tDemCollect.Controls.Add(this.labDemName, 0, 2);
            this.tDemCollect.Controls.Add(this.labDemNamingNote, 2, 2);
            this.tDemCollect.Location = new System.Drawing.Point(6, 19);
            this.tDemCollect.Name = "tDemCollect";
            this.tDemCollect.RowCount = 3;
            this.tDemCollect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tDemCollect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tDemCollect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tDemCollect.Size = new System.Drawing.Size(400, 95);
            this.tDemCollect.TabIndex = 2;
            // 
            // boxDemName
            // 
            this.boxDemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxDemName.Location = new System.Drawing.Point(103, 68);
            this.boxDemName.Name = "boxDemName";
            this.boxDemName.Size = new System.Drawing.Size(234, 20);
            this.boxDemName.TabIndex = 9;
            // 
            // boxWorkDir
            // 
            this.boxWorkDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxWorkDir.Location = new System.Drawing.Point(103, 5);
            this.boxWorkDir.Name = "boxWorkDir";
            this.boxWorkDir.Size = new System.Drawing.Size(234, 20);
            this.boxWorkDir.TabIndex = 2;
            // 
            // butWorkDir
            // 
            this.butWorkDir.Location = new System.Drawing.Point(343, 3);
            this.butWorkDir.Name = "butWorkDir";
            this.butWorkDir.Size = new System.Drawing.Size(54, 23);
            this.butWorkDir.TabIndex = 5;
            this.butWorkDir.Text = "Browse";
            this.butWorkDir.UseVisualStyleBackColor = true;
            this.butWorkDir.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxFinalDir
            // 
            this.boxFinalDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxFinalDir.Location = new System.Drawing.Point(103, 36);
            this.boxFinalDir.Name = "boxFinalDir";
            this.boxFinalDir.Size = new System.Drawing.Size(234, 20);
            this.boxFinalDir.TabIndex = 6;
            // 
            // butFinalDir
            // 
            this.butFinalDir.Location = new System.Drawing.Point(343, 34);
            this.butFinalDir.Name = "butFinalDir";
            this.butFinalDir.Size = new System.Drawing.Size(54, 23);
            this.butFinalDir.TabIndex = 7;
            this.butFinalDir.Text = "Browse";
            this.butFinalDir.UseVisualStyleBackColor = true;
            this.butFinalDir.Click += new System.EventHandler(this.button2_Click);
            // 
            // gGameCollect
            // 
            this.gGameCollect.Controls.Add(this.tableLayoutPanel1);
            this.gGameCollect.Controls.Add(this.tDemCollect);
            this.gGameCollect.Location = new System.Drawing.Point(12, 12);
            this.gGameCollect.Name = "gGameCollect";
            this.gGameCollect.Size = new System.Drawing.Size(412, 222);
            this.gGameCollect.TabIndex = 3;
            this.gGameCollect.TabStop = false;
            this.gGameCollect.Text = "Demo Collection";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.tlabDescEntries, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlabDescName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlabTagName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlabTagEntries, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.45455F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.54545F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 88);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tlabDescEntries
            // 
            this.tlabDescEntries.AutoSize = true;
            this.tlabDescEntries.Location = new System.Drawing.Point(103, 18);
            this.tlabDescEntries.Name = "tlabDescEntries";
            this.tlabDescEntries.Size = new System.Drawing.Size(106, 65);
            this.tlabDescEntries.TabIndex = 3;
            this.tlabDescEntries.Text = "Name of demo\'s map\r\nPlayer name\r\nTime in ticks\r\nTime in seconds\r\nSegment count";
            // 
            // tlabDescName
            // 
            this.tlabDescName.AutoSize = true;
            this.tlabDescName.Location = new System.Drawing.Point(103, 0);
            this.tlabDescName.Name = "tlabDescName";
            this.tlabDescName.Size = new System.Drawing.Size(60, 13);
            this.tlabDescName.TabIndex = 2;
            this.tlabDescName.Text = "Description";
            // 
            // tlabTagName
            // 
            this.tlabTagName.AutoSize = true;
            this.tlabTagName.Location = new System.Drawing.Point(3, 0);
            this.tlabTagName.Name = "tlabTagName";
            this.tlabTagName.Size = new System.Drawing.Size(31, 13);
            this.tlabTagName.TabIndex = 0;
            this.tlabTagName.Text = "Tags\r\n";
            // 
            // tlabTagEntries
            // 
            this.tlabTagEntries.AutoSize = true;
            this.tlabTagEntries.Location = new System.Drawing.Point(3, 18);
            this.tlabTagEntries.Name = "tlabTagEntries";
            this.tlabTagEntries.Size = new System.Drawing.Size(88, 65);
            this.tlabTagEntries.TabIndex = 1;
            this.tlabTagEntries.Text = "{map_name}\r\n{runner_name}\r\n{time_ticks}\r\n{time_secs}\r\n{segment_count}";
            // 
            // gDemSettings
            // 
            this.gDemSettings.Controls.Add(this.tDemSettings);
            this.gDemSettings.Location = new System.Drawing.Point(12, 240);
            this.gDemSettings.Name = "gDemSettings";
            this.gDemSettings.Size = new System.Drawing.Size(412, 145);
            this.gDemSettings.TabIndex = 4;
            this.gDemSettings.TabStop = false;
            this.gDemSettings.Text = "Demo Retrieval and Settings";
            // 
            // tDemSettings
            // 
            this.tDemSettings.ColumnCount = 3;
            this.tDemSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tDemSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tDemSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tDemSettings.Controls.Add(this.butGameDir, 2, 0);
            this.tDemSettings.Controls.Add(this.boxGameDir, 1, 0);
            this.tDemSettings.Controls.Add(this.labGameDir, 0, 0);
            this.tDemSettings.Controls.Add(this.labDefName, 0, 1);
            this.tDemSettings.Controls.Add(this.boxDefName, 1, 1);
            this.tDemSettings.Controls.Add(this.labTickrate, 0, 3);
            this.tDemSettings.Controls.Add(this.boxTickrate, 1, 3);
            this.tDemSettings.Controls.Add(this.labDefSaveName, 0, 2);
            this.tDemSettings.Controls.Add(this.boxDefSaveName, 1, 2);
            this.tDemSettings.Controls.Add(this.labSaveNameNote, 2, 2);
            this.tDemSettings.Controls.Add(this.labDemNameNote, 2, 1);
            this.tDemSettings.Location = new System.Drawing.Point(6, 20);
            this.tDemSettings.Name = "tDemSettings";
            this.tDemSettings.RowCount = 4;
            this.tDemSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tDemSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tDemSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tDemSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tDemSettings.Size = new System.Drawing.Size(400, 119);
            this.tDemSettings.TabIndex = 0;
            // 
            // butGameDir
            // 
            this.butGameDir.Location = new System.Drawing.Point(343, 3);
            this.butGameDir.Name = "butGameDir";
            this.butGameDir.Size = new System.Drawing.Size(54, 23);
            this.butGameDir.TabIndex = 6;
            this.butGameDir.Text = "Browse";
            this.butGameDir.UseVisualStyleBackColor = true;
            this.butGameDir.Click += new System.EventHandler(this.button3_Click);
            // 
            // boxGameDir
            // 
            this.boxGameDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxGameDir.Location = new System.Drawing.Point(103, 4);
            this.boxGameDir.Name = "boxGameDir";
            this.boxGameDir.Size = new System.Drawing.Size(234, 20);
            this.boxGameDir.TabIndex = 3;
            // 
            // boxDefName
            // 
            this.boxDefName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxDefName.Location = new System.Drawing.Point(103, 33);
            this.boxDefName.Name = "boxDefName";
            this.boxDefName.Size = new System.Drawing.Size(234, 20);
            this.boxDefName.TabIndex = 4;
            // 
            // boxTickrate
            // 
            this.boxTickrate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxTickrate.Location = new System.Drawing.Point(103, 93);
            this.boxTickrate.Name = "boxTickrate";
            this.boxTickrate.Size = new System.Drawing.Size(101, 20);
            this.boxTickrate.TabIndex = 7;
            this.boxTickrate.Text = "0.015";
            // 
            // boxDefSaveName
            // 
            this.boxDefSaveName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxDefSaveName.Location = new System.Drawing.Point(103, 62);
            this.boxDefSaveName.Name = "boxDefSaveName";
            this.boxDefSaveName.Size = new System.Drawing.Size(234, 20);
            this.boxDefSaveName.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(349, 391);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 5;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // labDemNamingNote
            // 
            this.labDemNamingNote.AutoSize = true;
            this.labDemNamingNote.Location = new System.Drawing.Point(343, 62);
            this.labDemNamingNote.Name = "labDemNamingNote";
            this.labDemNamingNote.Size = new System.Drawing.Size(52, 26);
            this.labDemNamingNote.TabIndex = 10;
            this.labDemNamingNote.Text = "without extension";
            // 
            // labSaveNameNote
            // 
            this.labSaveNameNote.AutoSize = true;
            this.labSaveNameNote.Location = new System.Drawing.Point(343, 58);
            this.labSaveNameNote.Name = "labSaveNameNote";
            this.labSaveNameNote.Size = new System.Drawing.Size(52, 26);
            this.labSaveNameNote.TabIndex = 11;
            this.labSaveNameNote.Text = "with extension";
            // 
            // labDemNameNote
            // 
            this.labDemNameNote.AutoSize = true;
            this.labDemNameNote.Location = new System.Drawing.Point(343, 29);
            this.labDemNameNote.Name = "labDemNameNote";
            this.labDemNameNote.Size = new System.Drawing.Size(52, 26);
            this.labDemNameNote.TabIndex = 12;
            this.labDemNameNote.Text = "with extension";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 423);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.gDemSettings);
            this.Controls.Add(this.gGameCollect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(452, 462);
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_FormOpen);
            this.tDemCollect.ResumeLayout(false);
            this.tDemCollect.PerformLayout();
            this.gGameCollect.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gDemSettings.ResumeLayout(false);
            this.tDemSettings.ResumeLayout(false);
            this.tDemSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labWorkDir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labFinalDir;
        private System.Windows.Forms.TableLayoutPanel tDemCollect;
        private System.Windows.Forms.GroupBox gGameCollect;
        private System.Windows.Forms.GroupBox gDemSettings;
        private System.Windows.Forms.TableLayoutPanel tDemSettings;
        private System.Windows.Forms.Label labGameDir;
        private System.Windows.Forms.Label labDefName;
        private System.Windows.Forms.TextBox boxWorkDir;
        private System.Windows.Forms.Label labTickrate;
        private System.Windows.Forms.Button butWorkDir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox boxFinalDir;
        private System.Windows.Forms.Button butFinalDir;
        private System.Windows.Forms.Button butGameDir;
        private System.Windows.Forms.TextBox boxGameDir;
        private System.Windows.Forms.TextBox boxDefName;
        private System.Windows.Forms.TextBox boxTickrate;
        private System.Windows.Forms.TextBox boxDemName;
        private System.Windows.Forms.Label labDemName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tlabTagName;
        private System.Windows.Forms.Label tlabTagEntries;
        private System.Windows.Forms.Label tlabDescEntries;
        private System.Windows.Forms.Label tlabDescName;
        private System.Windows.Forms.Label labDefSaveName;
        private System.Windows.Forms.TextBox boxDefSaveName;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Label labDemNamingNote;
        private System.Windows.Forms.Label labSaveNameNote;
        private System.Windows.Forms.Label labDemNameNote;
    }
}
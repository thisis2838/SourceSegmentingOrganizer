using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace demo_organizer.Window
{
    public partial class SettingsWindow : Form
    {
        public string WorkDir { get { return boxWorkDir.Text; } }
        public string FinalDir { get { return boxFinalDir.Text; } }
        public string GameDir { get { return boxGameDir.Text; } }
        public string DemDefName { get { return boxDefName.Text; } }
        public float Tickrate { get { return 1 / float.Parse(boxTickrate.Text); } }
        public string DemNaming { get { return boxDemName.Text; } }
        public string SaveDefName{ get { return boxDefSaveName.Text; } }

        public SettingsWindow()
        {
            InitializeComponent();

            SetDefaults();
        }
        
        private void SetDefaults()
        {
            boxWorkDir.Text = Properties.Settings.Default.WorkDir;
            boxFinalDir.Text = Properties.Settings.Default.FinalDir;
            boxTickrate.Text = Properties.Settings.Default.Tickrate;
            boxDefName.Text = Properties.Settings.Default.DemDefName;
            boxGameDir.Text = Properties.Settings.Default.GameDir;
            boxDemName.Text = Properties.Settings.Default.DemNaming;
            boxDefSaveName.Text = Properties.Settings.Default.DemSaveName;
        }

        private void Settings_FormOpen(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void Settings_FormClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default.WorkDir = boxWorkDir.Text;
            Properties.Settings.Default.FinalDir = boxFinalDir.Text;
            Properties.Settings.Default.Tickrate = boxTickrate.Text;
            Properties.Settings.Default.DemDefName = boxDefName.Text;
            Properties.Settings.Default.GameDir = boxGameDir.Text;
            Properties.Settings.Default.DemNaming = boxDemName.Text;
            Properties.Settings.Default.DemSaveName = boxDefSaveName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                boxWorkDir.Text = dialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                boxFinalDir.Text = dialog.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                boxGameDir.Text = dialog.FileName;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

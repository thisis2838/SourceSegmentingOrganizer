using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace source_segmenting_organizer.Forms
{
    public partial class SettingsForm : Form
    {
        public string WorkDir => boxWorkDir.Text;
        public string FinalDir => boxFinalDir.Text;
        public string GameDir => boxGameDir.Text;

        public string DemDefName => boxDefName.Text;
        public string SaveDefName => boxDefSaveName.Text;
        public float Tickrate => 1f / (float)nudTickRate.Value;
        public string SegmentNaming => boxSegName.Text;

        public bool ZerothTick => chkZerothTick.Checked;
        public string EndTag => boxEndTag.Text;

        public SettingsForm()
        {
            InitializeComponent();

            BindToBrowseFolder(boxWorkDir, butWorkDir);
            BindToBrowseFolder(boxFinalDir, butFinalDir);
            BindToBrowseFolder(boxGameDir, butGameDir);

            SettingsHandler.Instance.AddSetting("dir_work",
                (e) => boxWorkDir.Text = e,
                () => boxWorkDir.Text);
            SettingsHandler.Instance.AddSetting("dir_final",
                (e) => boxFinalDir.Text = e,
                () => boxFinalDir.Text);
            SettingsHandler.Instance.AddSetting("dir_game",
                (e) => boxGameDir.Text = e,
                () => boxGameDir.Text);

            SettingsHandler.Instance.AddSetting("name_def_demo",
                (e) => boxDefName.Text = e,
                () => boxDefName.Text);
            SettingsHandler.Instance.AddSetting("name_def_save",
                (e) => boxDefSaveName.Text = e,
                () => boxDefSaveName.Text);
            SettingsHandler.Instance.AddSetting("tickrate",
                (e) => { if (decimal.TryParse(e, out decimal s)) nudTickRate.Value = s; },
                () => nudTickRate.Value.ToString());
            SettingsHandler.Instance.AddSetting("name_seg",
                (e) => boxSegName.Text = e,
                () => boxSegName.Text);

            SettingsHandler.Instance.AddSetting("zero_tick",
                (e) => { if (bool.TryParse(e, out var s)) chkZerothTick.Checked = s; },
                () => chkZerothTick.Checked.ToString());
            SettingsHandler.Instance.AddSetting("end_tag",
                (e) => boxEndTag.Text = e,
                () => boxEndTag.Text);

            boxDefName.KeyPress += (s, e) => RestrictNonPathChars(boxDefName, e);
            boxDefSaveName.KeyPress += (s, e) => RestrictNonPathChars(boxDefSaveName, e);
        }

        private void BindToBrowseFolder(TextBox box, Button browse)
        {
            browse.Click += (s, e) =>
            {
                CommonOpenFileDialog diag = new CommonOpenFileDialog();
                diag.IsFolderPicker = true;

                if (diag.ShowDialog() == CommonFileDialogResult.Ok)
                    box.Text = diag.FileName;
            };
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestrictNonPathChars(TextBox box, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                return;

            var regex = new Regex(@"[<>:""\/\\\|?\*]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace source_segmenting_organizer.Forms
{
    public partial class HelpAndAbout : Form
    {
        public HelpAndAbout()
        {
            InitializeComponent();

            List<(TabPage, string)> pairs = new List<(TabPage, string)>()
            {
                (pFunctions, Properties.Resources.hd_help_functions),
                (pSettingUp, Properties.Resources.hd_help_settingup),
                (pIntro, Properties.Resources.hd_help_intro),
                (pWorkflow, Properties.Resources.hd_help_workflow),
            };

            pairs.ForEach(x =>
            {
                RichTextBox b = new RichTextBox()
                {
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.White,
                    ReadOnly = true,
                    Dock = DockStyle.Fill
                };
                b.Rtf = x.Item2;

                x.Item1.Padding = new Padding(6, 6, 6, 6);
                x.Item1.Controls.Add(b);
            });
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}

using source_segmenting_organizer.Segment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace source_segmenting_organizer.Forms
{
    public partial class MainForm : Form
    {
        public static SettingsForm Settings;

        private List<SegmentFile> _collected = new List<SegmentFile>();
        private List<SegmentFile> _finalized = new List<SegmentFile>();

        private HelpAndAbout _helpForm;

        private bool _isRightClickOnCollected = false;
        private ContextMenu _collectedMenu = new ContextMenu();
        private ContextMenu _finalizedMenu = new ContextMenu();

        public MainForm()
        {
            _helpForm = new HelpAndAbout();
            Settings = new SettingsForm();

            SettingsHandler.Instance.AddSetting("runner_name",
                (e) => boxRunnerName.Text = e,
                () => boxRunnerName.Text);
            SettingsHandler.Instance.AddSetting("seg_num",
                (e) => boxSegNumber.Text = e,
                () => boxSegNumber.Text);

            InitializeComponent();

            Trace.Listeners.Add(new TextBoxTraceListener(boxConsole));
            SetUpDGV();
            SettingsHandler.Instance.LoadSettings();
            this.Shown += (s, e) => butRefresh_Click(null, null);
            this.FormClosing += (s, e) => SettingsHandler.Instance.WriteSettings();
        }

        private void SetUpDGV()
        {
            IEnumerable<SegmentFile> getSelectedSegments(DataGridView dgv, List<SegmentFile> files)
            {
                return dgv.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(x => x.Cells[0].Value.ToString())
                    .Select(x => files.FirstOrDefault(y => y.Demo.Hash == x))
                    .Where(x => x != null);
            }

            var cmsDelete = new MenuItem("Delete selected");
            cmsDelete.Click += (s, e) =>
            {
                var dgv = _isRightClickOnCollected ? dgvCollected : dgvFinalized;
                var files = _isRightClickOnCollected ? _collected : _finalized;

                if (dgv.SelectedRows.Count == 0)
                    return;

                if (MessageBox.Show("Are you sure you want to permanently delete these files?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                getSelectedSegments(dgv, files).ToList().ForEach(x =>
                    {
                        x.Delete();
                    });

                butRefresh_Click(null, null);
            };

            var cmsMove = new MenuItem("Copy selected to game's folder");
            cmsMove.Click += (s, e) =>
            {
                var dgv = _isRightClickOnCollected ? dgvCollected : dgvFinalized;
                var files = _isRightClickOnCollected ? _collected : _finalized;

                if (dgv.SelectedRows.Count == 0)
                    return;

                if (!Directory.Exists(Settings.GameDir))
                {
                    MessageBox.Show("Empty game directory! Please specify a game directory in the Settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                getSelectedSegments(dgv, files).ToList().ForEach(x =>
                {
                    x.RelocateToGameDir(Settings.GameDir);
                    Trace.WriteLine($"Copied to {x.Demo.FileName}");
                });
            };

            var cmsFinal = new MenuItem("Finalize selected");
            cmsFinal.Click += (s, e) =>
            {
                var dgv = dgvCollected;
                var files = _collected;

                if (dgv.SelectedRows.Count == 0)
                    return;

                if (!Directory.Exists(Settings.FinalDir))
                {
                    MessageBox.Show("Please specify the final directory in the Settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                getSelectedSegments(dgv, files).ToList().ForEach(x =>
                {
                    x.RelocateToDirectory(Settings.FinalDir);
                    x.Rename(GetFinalizedName(x.Demo));
                });

                butRefresh_Click(null, null);
            };

            var cmsUnfinal = new MenuItem("Un-finalize selected");
            cmsUnfinal.Click += (s, e) =>
            {
                var dgv =  dgvFinalized;
                var files = _finalized;

                if (dgv.SelectedRows.Count == 0)
                    return;

                if (!Directory.Exists(Settings.FinalDir))
                {
                    MessageBox.Show("Please specify the work directory in the Settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                getSelectedSegments(dgv, files).ToList().ForEach(x =>
                {
                    x.RelocateToDirectory(Settings.WorkDir);
                    x.Rename(x.ToString());
                });

                butRefresh_Click(null, null);
            };

            var cmsRefinal = new MenuItem("Re-finalize selected");
            cmsRefinal.Click += (s, e) =>
            {
                var dgv = dgvFinalized;
                var files = _finalized;

                if (dgv.SelectedRows.Count == 0)
                    return;

                if (!Directory.Exists(Settings.FinalDir))
                {
                    MessageBox.Show("Please specify the work directory in the Settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                getSelectedSegments(dgv, files).ToList().ForEach(x =>
                {
                    x.Rename(GetFinalizedName(x.Demo));
                });

                butRefresh_Click(null, null);
            };

            _collectedMenu.MenuItems.Add(cmsDelete);
            _collectedMenu.MenuItems.Add(cmsMove);
            _collectedMenu.MenuItems.Add(cmsFinal);
            dgvCollected.MouseUp += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    _isRightClickOnCollected = true;
                    _collectedMenu.Show(dgvCollected, e.Location);
                }
            };

            _finalizedMenu.MenuItems.Add(cmsDelete.CloneMenu());
            _finalizedMenu.MenuItems.Add(cmsMove.CloneMenu());
            _finalizedMenu.MenuItems.Add(cmsUnfinal);
            _finalizedMenu.MenuItems.Add(cmsRefinal);
            dgvFinalized.MouseUp += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    _isRightClickOnCollected = false;
                    _finalizedMenu.Show(dgvFinalized, e.Location);
                }
            };

            dgvCollected.SortCompare += (s, e) => SortColumns(true, e);
        }

        const string _defaultFmt = "{seg_id}-{runner_name}-{time_secs}";
        private string GetFinalizedName(DemoFile d)
        {
            string fmt = Settings.SegmentNaming;
            if (string.IsNullOrWhiteSpace(fmt))
            {
                MessageBox.Show($"Empty segment naming scheme, using default of \"{_defaultFmt}\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fmt = _defaultFmt;
            }
            return fmt
                    .Replace("{map_name}", d.MapName)
                    .Replace("{runner_name}", boxRunnerName.Text)
                    .Replace("{time_ticks}", d.MeasuredTicks.ToString())
                    .Replace("{time_secs}", (d.MeasuredTicks * Settings.Tickrate).ToString())
                    .Replace("{seg_id}", boxSegNumber.Text);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.ShowDialog();
            butRefresh_Click(null, null);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _helpForm.Show();
        }

        private void SortColumns(bool isCollect,  DataGridViewSortCompareEventArgs e)
        {
            int colIndex = e.Column.Index - (isCollect ? 1 : 0);

            switch (colIndex)
            {
                case 3:
                case 5:
                    e.SortResult = ((int)e.CellValue1).CompareTo((int)e.CellValue2);
                    e.Handled = true;
                    break;
                case 4: case 6:
                    e.SortResult = ((float)e.CellValue1).CompareTo((float)e.CellValue2);
                    e.Handled = true;
                    break;
            }

        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            _collected.Clear();
            _finalized.Clear();

            dgvCollected.Rows.Clear();
            dgvFinalized.Rows.Clear();

            if (!Directory.Exists(Settings.WorkDir) ||
                !Directory.Exists(Settings.FinalDir) ||
                !Directory.Exists(Settings.GameDir))
            {
                MessageBox.Show("One or more required paths aren't set or doesn't exist. Please set them in the Settings!\nMore info in Help and About!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(Settings.DemDefName) || string.IsNullOrWhiteSpace(Settings.SaveDefName))
            {
                MessageBox.Show("One or more required names aren't set. Please set them in the Settings!\nMore info in Help and About!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            void collect(List<SegmentFile> list, string path)
            {
                Directory.EnumerateFiles(path, "*.dem").ToList().ForEach(x =>
                {
                    var seg = new SegmentFile(x, Utils.ReplaceExtInPath(x, "sav"));
                    if (seg.IsValid())
                        list.Add(seg);
                });
            }
            collect(_collected, Settings.WorkDir);
            collect(_finalized, Settings.FinalDir);

            string demoPath = Path.Combine(Settings.GameDir, Settings.DemDefName + ".dem");
            string savePath = Path.Combine(Settings.GameDir, "SAVE", Settings.SaveDefName + ".sav");
            var newSeg = new SegmentFile(demoPath, savePath);
            bool newAdded = false;
            if (newSeg.IsValid() && 
                !_collected.Concat(_finalized).Any(x => x.Demo.Hash == newSeg.Demo.Hash))
            {
                newSeg.RelocateToDirectory(Settings.WorkDir, true);
                newSeg.Rename(newSeg.ToString());
                _collected.Add(newSeg);
                newAdded = true;
            }

            _collected.Reverse();
            _collected.ForEach(x =>
            {
                x.Rename(x.ToString());
                dgvCollected.Rows.Add(new object[]
                {
                    x.Demo.Hash,
                    newAdded && (_collected.IndexOf(x) == 0),
                    x.Demo.FileName,
                    x.Demo.MapName,
                    x.Demo.TotalTicks,
                    (x.Demo.TotalTicks * Settings.Tickrate),
                    x.Demo.MeasuredTicks,
                    (x.Demo.MeasuredTicks * Settings.Tickrate),
                });
            });

            _finalized.ForEach(x =>
            {
                //x.Rename(GetFinalizedName(x.Demo));
                dgvFinalized.Rows.Add(new object[]
                {
                    x.Demo.Hash,
                    x.Demo.FileName,
                    x.Demo.MapName,
                    x.Demo.TotalTicks,
                    (x.Demo.TotalTicks * Settings.Tickrate),
                    x.Demo.MeasuredTicks,
                    (x.Demo.MeasuredTicks * Settings.Tickrate)
                });
            });

            dgvFinalized.ClearSelection();
            dgvCollected.ClearSelection();
        }
    }
}

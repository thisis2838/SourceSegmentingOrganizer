using demo_organizer.Demo;
using demo_organizer.Window;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demo_organizer
{
    public partial class MainWindow : Form
    {
        public SettingsWindow Settings;
        public HelpandAboutWindow HaB;
        private DemoList _demos;
        private DemoList _pDemos;
        private ControlWriter test;
        public MainWindow()
        {
            InitializeComponent();
            Settings = new SettingsWindow();
            HaB = new HelpandAboutWindow();
            _demos = new DemoList(Settings.WorkDir);
            _pDemos = new DemoList(Settings.FinalDir);
            test = new ControlWriter(this.boxConsole);
            Console.SetOut(test);
        }

        private void UpdateDemoLists()
        {
            _demos.FilePath = Settings.WorkDir;
            _pDemos.FilePath = Settings.FinalDir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.ShowDialog();
        }

        private string BuildDemoName(DemoFile demo)
        {
            string playerName = this.boxRunnerName.Text;
            string count = this.boxSegNum.Text;
            int printTicks = demo.DemoInfo.MTicks == 0 ? demo.DemoInfo.TotalTicks : demo.DemoInfo.MTicks;
            float printTime = printTicks / Settings.Tickrate;

            string layout = String.Copy(Settings.DemNaming);
            if (layout == "")
            {
                Console.WriteLine("Demo naming scheme not set! Using default!");
                return demo.Name;
            }
            layout =
                layout
                .Replace("{map_name}", demo.DemoInfo.MapName)
                .Replace("{time_ticks}", printTicks.ToString())
                .Replace("{time_secs}", printTime.ToString("0.00000"))
                .Replace("{segment_count}", count)
                .Replace("{runner_name}", playerName);
            return layout;
        }

        private IEnumerable<string> EnumerateDemos(string path)
        {
            return Directory
            .EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
            .Where(s => Path.GetExtension(s).TrimStart('.').ToLowerInvariant() == "dem");
        }

        private void DemoGridAdd(DataGridView grid, DemoFile d)
        {
            string[] info = { d.DemoInfo.MapName,
                    d.DemoInfo.TotalTicks.ToString(),
                    (d.DemoInfo.TotalTicks / Settings.Tickrate).ToString("0.00000"),
                    d.DemoInfo.EffectiveTicks.ToString(),
                    (d.DemoInfo.EffectiveTicks / Settings.Tickrate).ToString("0.00000"),
                    BitConverter.ToString(d.FileHash).Replace("-","")};

            grid.Rows.Add(info);
        }

        private void butDLRefresh_Click(object sender, EventArgs e)
        {
            UpdateDemoLists();
            this.boxLatestSeg.Text = "";

            if (Settings.WorkDir == "" || Settings.FinalDir == "" || Settings.GameDir == "")
            {
                Console.WriteLine("Directories not all set!");
                return;
            }
            else if (Settings.DemDefName == "" || Settings.SaveDefName == "")
            {
                Console.WriteLine("Save and Demo name not all set!");
                return;
            }

            gridDemoList.Rows.Clear();
            gridProcessedDemos.Rows.Clear();
            _demos.DemoEntries.Clear();
            _pDemos.DemoEntries.Clear();

            string gameDir = Settings.GameDir;
            string workDir = Settings.WorkDir;

            try
            {
                string g = Path.Combine(gameDir, Settings.DemDefName);
                DemoFile demo = new DemoFile(g);

                demo.CopyTo(workDir, demo.Name, false);
                FileHandling.Copy(Path.Combine(gameDir, "save", Settings.SaveDefName), Path.Combine(workDir, demo.Name + ".sav"));

                this.boxLatestSeg.AppendText($"Map: {demo.DemoInfo.MapName}\r\n\r\n");
                this.boxLatestSeg.AppendText($"Total time:\r\n");
                this.boxLatestSeg.AppendText($"{demo.DemoInfo.TotalTicks} ticks, {(demo.DemoInfo.TotalTicks / Settings.Tickrate):0.00000}s\r\n\r\n");
                this.boxLatestSeg.AppendText($"Measured time:\r\n");
                this.boxLatestSeg.AppendText($"{demo.DemoInfo.EffectiveTicks} ticks, {(demo.DemoInfo.EffectiveTicks / Settings.Tickrate):0.00000}s\r\n\r\n");
                this.boxLatestSeg.AppendText($"Hash:\r\n");
                this.boxLatestSeg.AppendText(BitConverter.ToString(demo.FileHash).Replace("-",""));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Couldn't find {Path.Combine(gameDir, Settings.DemDefName)} \n");
            }

            var myFiles = EnumerateDemos(workDir);

            foreach (string name in myFiles)
            {
                if (name.Contains("_2.dem"))
                    continue;

                DemoFile d = new DemoFile(name);
                _demos.DemoEntries.Add(d);
                DemoGridAdd(gridDemoList, d);
            }

            myFiles = EnumerateDemos(Settings.FinalDir);

            foreach (string name in myFiles)
            {
                if (name.Contains("_2.dem"))
                    continue;

                DemoFile d = new DemoFile(name);
                _pDemos.DemoEntries.Add(d);
                DemoGridAdd(gridProcessedDemos, d);
            }

        }

        private void butDLDelSelected_Click(object sender, EventArgs e)
        {
            UpdateDemoLists();
            foreach (DataGridViewCell sel in gridDemoList.SelectedCells)
            {
                if (sel.RowIndex + 1 < gridDemoList.Rows.Count && sel.RowIndex >= 0)
                {
                    int delete = _demos.GetEntryIndex((string)gridDemoList.Rows[sel.RowIndex].Cells[5].Value);
                    _demos.DeleteAt(delete);
                    gridDemoList.Rows.RemoveAt(sel.RowIndex);
                }
            }
        }

        private void butDLFinalizeSelected_Click(object sender, EventArgs e)
        {
            UpdateDemoLists();

            foreach (DataGridViewCell sel in gridDemoList.SelectedCells)
            {
                if (sel.RowIndex + 1 < gridDemoList.Rows.Count)
                {
                    if (!_pDemos.EntriesInclude(_demos.DemoEntries[sel.RowIndex]))
                    {
                        _pDemos.DemoEntries.Add(_demos.DemoEntries[sel.RowIndex]);
                        string finalName = BuildDemoName(_demos.DemoEntries[sel.RowIndex]);
                        _demos.DemoEntries[sel.RowIndex].CopyTo(Settings.FinalDir, finalName);
                        DemoGridAdd(gridProcessedDemos, _demos.DemoEntries[sel.RowIndex]);
                    }
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.boxRunnerName.Text = Properties.Settings.Default.RunnerName;
            this.boxSegNum.Text = Properties.Settings.Default.SegmentCount;
        }

        private void MainWindow_FormClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default.RunnerName = this.boxRunnerName.Text;
            Properties.Settings.Default.SegmentCount = this.boxSegNum.Text;
            Properties.Settings.Default.Save();
        }

        private void butPDDelSelected_Click(object sender, EventArgs e)
        {
            UpdateDemoLists();
            foreach (DataGridViewCell sel in gridProcessedDemos.SelectedCells)
            {
                if (sel.RowIndex + 1 < gridProcessedDemos.Rows.Count && sel.RowIndex >= 0)
                {
                    int delete = _pDemos.GetEntryIndex((string)gridProcessedDemos.Rows[sel.RowIndex].Cells[5].Value);
                    _pDemos.DeleteAt(delete);
                    gridProcessedDemos.Rows.RemoveAt(sel.RowIndex);
                }
            }
        }

        private void grids_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            //Suppose your interested column has index 1
            if (e.Column.Index == 1 || e.Column.Index == 3)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;//pass by the default sorting
            }
            else if (e.Column.Index != 0 && e.Column.Index != 5)
            {
                e.SortResult = float.Parse(e.CellValue1.ToString()).CompareTo(float.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }
        }

        private void butHelpAndAbout_Click(object sender, EventArgs e)
        {
            HaB.ShowDialog();
        }
    }

    public class ControlWriter : TextWriter
    {
        private TextBox textbox;
        public ControlWriter(TextBox textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            textbox.Text += value;
        }

        public override void Write(string value)
        {
            textbox.Text += value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }
}

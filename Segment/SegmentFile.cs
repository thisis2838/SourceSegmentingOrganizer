using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source_segmenting_organizer.Segment
{
    public class SegmentFile
    {
        public DemoFile Demo { get; private set; }
        public DemoFile Demo_2 { get; private set; }
        public SaveFile Save { get; private set; }

        public SegmentFile(string demo, string save)
        {
            Demo = new DemoFile(demo);
            Save = new SaveFile(save);

            if (Demo.DisplayedTickCount < 0)
                Demo_2 = new DemoFile(Utils.ReplaceNameInPath(Demo.FilePath, Path.GetFileNameWithoutExtension(Demo.FileName) + "_2"));
        }

        public bool IsValid()
        {
            return (Demo.IsValid() && (Demo_2?.IsValid() ?? true)) && Save.IsValid();
        }

        public void Rename(string name)
        {
            Demo.Rename(name);
            Demo_2?.Rename(name + "_2");
            Save.Rename(name);
        }

        public void RelocateToDirectory(string dir, bool copy = false)
        {
            Demo.RelocateToDirectory(dir, copy);
            Demo_2?.RelocateToDirectory(dir, copy);
            Save.RelocateToDirectory(dir, copy);
        }

        public void RelocateToGameDir(string gameDir)
        {
            Demo.RelocateToDirectory(gameDir, true, false);
            Demo_2?.RelocateToDirectory(gameDir, true, false);
            Save.RelocateToDirectory(Path.Combine(gameDir, "SAVE"), true, false);
        }

        public void Delete()
        {
            Demo.Delete();
            Demo_2?.Delete();
            Save.Delete();
        }

        public override string ToString()
        {
            return $"{Demo.MapName}-{Demo.TotalTicks}-{Demo.Hash}";
        }
    }
}

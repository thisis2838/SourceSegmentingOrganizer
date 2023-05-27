using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace source_segmenting_organizer.Segment
{
    public abstract class FileBase
    {
        public string FilePath { get; internal set; } = null;
        public string FileName => FilePath == null ? null : Path.GetFileName(FilePath);
        public string Hash { get; internal set; } = null;

        public FileBase(string path)
        {
            if (!File.Exists(path))
            {
                //MessageBox.Show($"Problem while parsing {Path.GetFileName(path)}, file is missing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            FilePath = path;
            Hash = Utils.GetMD5(path);
        }

        public bool IsValid()
        {
            return FilePath != null && File.Exists(FilePath) && Utils.GetMD5(FilePath) == Hash;
        }

        public void Rename(string newName)
        {
            if (!IsValid())
                return;

            string newPath = Utils.ReplaceNameInPath(FilePath, newName);
            if (newPath == FilePath)
                return;

            if (File.Exists(newPath))
            {
                Trace.WriteLine($"Duplicate {Path.GetFileName(newPath)} deleted.");
                File.Delete(newPath);
            }

            File.Move(FilePath, newPath);
            FilePath = newPath;
        }

        public void RelocateToDirectory(string dir, bool copy = false, bool moveOrigin = true)
        {
            if (!IsValid())
                return;

            Directory.CreateDirectory(dir);

            string newPath = Path.Combine(dir, FileName);
            if (File.Exists(newPath))
            {
                Trace.WriteLine($"Duplicate {Path.GetFileName(newPath)} deleted.");
                File.Delete(newPath);
            }

            if (copy) File.Copy(FilePath, newPath);
            else File.Move(FilePath, newPath);

            if (moveOrigin)
                FilePath = newPath;
        }

        public void Delete()
        {
            if (!IsValid())
                return;

            File.Delete(FilePath);
        }
    }
}

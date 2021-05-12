using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_organizer
{
    class FileHandling
    {
        public static void Copy(string from, string to)
        {
            if (!Exists(from))
                return;

            try
            {
                File.Copy(from, to);
            }
            catch { }
        }

        public static void Delete(string file)
        {
            try
            {
                File.Delete(file);
            }
            catch
            {
                Console.WriteLine($"{file} doesn't exist!");
            }
        }

        public static bool Exists(string file)
        {
            if (!File.Exists(file))
            {
                Console.WriteLine($"{file} doesn't exist!");
                return false;
            }
            return true;
        }

        public static string AddToFilename(string path, string add)
        {
            string ext = Path.GetExtension(path);
            string noExt = path.Replace(ext, "");

            return noExt + add + ext;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.TimeSpan;

namespace source_segmenting_organizer
{
    public static class Utils
    {
        public static string GetMD5(string file)
        {
            if (!File.Exists(file))
                return null;

            using (var md5 = MD5.Create())
            using (var stream = File.OpenRead(file))
            {
                var hash = md5.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        public static string ReplaceNameInPath(string path, string newName)
        {
            string folder = Path.GetDirectoryName(path);
            string ext = Path.GetExtension(path);

            return Path.Combine(folder, newName + ext);
        }

        public static string ReplaceExtInPath(string path, string newExt)
        {
            newExt = newExt.FirstOrDefault() == '.' ? newExt : '.' + newExt;

            string folder = Path.GetDirectoryName(path);
            string name = Path.GetFileNameWithoutExtension(path);

            return Path.Combine(folder, name + newExt);
        }
    }

    public class TextBoxTraceListener : TraceListener
    {
        private TextBoxBase _output;

        public TextBoxTraceListener(TextBoxBase output)
        {
            this._output = output;
        }

        public override void Write(string message)
        {
            Action append = delegate () 
            {
                _output.AppendText(message);
            };

            if (_output.InvokeRequired) _output.BeginInvoke(append);
            else append();

        }

        public override void WriteLine(string message)
        {
            Write(message + Environment.NewLine);
        }
    }
}

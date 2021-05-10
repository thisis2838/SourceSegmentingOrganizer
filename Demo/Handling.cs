using Listdemo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace demo_manager.Demo
{
    class DemoFile
    {
        public string Name => $"{DemoInfo.MapName}-{DemoInfo.MTicks}-{DemoInfo.TotalTicks}-{BitConverter.ToString(FileHash).Replace("-", "")}";
        public string FilePath { get; set; }
        public byte[] FileHash { get; set; }
        public SourceDemoParseResult DemoInfo { get; set; }
        public DemoFile(string path)
        {
            FilePath = path;
            Parse();
            Check2();
        }
        public void Parse()
        {
            DemoInfo = DemoParser.ParseDemo(FilePath);
            CalcHash();
        }
        public void CalcHash()
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(FilePath))
                {
                    FileHash = md5.ComputeHash(stream);
                }
            }
        }
        public bool Compare(string filePath)
        {
            if (!FileHandling.Exists(filePath))
                return false;

            byte[] hash;

            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    hash = md5.ComputeHash(stream);
                }
            }

            return hash == FileHash;
        }
        public bool Check2()
        {
            if (DemoInfo.Pticks < 0 &&
                File.Exists(FileHandling.AddToFilename(FilePath, "_2")))
            {
                DemoFile d2 = new DemoFile(FileHandling.AddToFilename(FilePath, "_2"));
                DemoInfo.TotalTicks += d2.DemoInfo.EffectiveTicks;
                return true;
            }
            return false;
        }

        public void DeleteFile()
        {
            FileHandling.Delete(FilePath);
            FileHandling.Delete(FilePath.Replace(".dem", ".sav"));
            if (DemoInfo.Pticks < 0)
                FileHandling.Delete(FilePath.Replace(".dem", "_2.dem"));
        }

        public void CopyTo(string to, string newName = "", bool copySave = true)
        {
            string name = newName != "" ? newName : Name;
            FileHandling.Copy(Path.Combine(FilePath), Path.Combine(to, name + ".dem"));
            if (copySave)
                FileHandling.Copy(Path.Combine(FilePath.Replace(".dem", ".sav")), Path.Combine(to, name + ".sav"));
            if (DemoInfo.Pticks < 0)
                FileHandling.Copy(Path.Combine(FilePath.Replace(".dem", "_2.dem")), Path.Combine(to, name + "_2.dem"));
        }
    }

    class DemoList
    {
        public List<DemoFile> DemoEntries { get; set; }
        public string FilePath { get; set; }

        public DemoList(string path)
        {
            DemoEntries = new List<DemoFile>();
            FilePath = path;
        }

        public bool EntriesInclude(DemoFile file)
        {
            return DemoEntries.Any(x => x.FileHash.SequenceEqual(file.FileHash));
        }

        public DemoFile GetEntry(string hash)
        {
            foreach (DemoFile file in DemoEntries)
            {
                if (BitConverter.ToString(file.FileHash).Replace("-", "") == hash)
                    return file;
            }
            return null;
        }

        public int GetEntryIndex(string hash)
        {
            for (int i = 0; i < DemoEntries.Count; i++)
            {
                if (BitConverter.ToString(DemoEntries[i].FileHash).Replace("-", "") == hash)
                    return i;
            }

            return -1;
        }

        public bool FilesInclude(DemoFile file)
        {
            var myFiles = Directory
            .EnumerateFiles(FilePath, "*.*", SearchOption.AllDirectories)
            .Where(s => Path.GetExtension(s).TrimStart('.').ToLowerInvariant() == "dem");

            foreach (string name in myFiles)
            {
                DemoFile d = new DemoFile(name);
                if (d.FileHash.SequenceEqual(file.FileHash))
                    return true;
            }
            return false;
        }

        public string GetFileName(DemoFile file)
        {
            var myFiles = Directory
            .EnumerateFiles(FilePath, "*.*", SearchOption.AllDirectories)
            .Where(s => Path.GetExtension(s).TrimStart('.').ToLowerInvariant() == "dem");

            foreach (string name in myFiles)
            {
                DemoFile d = new DemoFile(name);
                if (d.FileHash.SequenceEqual(file.FileHash))
                    return name;
            }
            return "";
        }

        public void DeleteAt(int index)
        {
            if (index < 0 && index >= DemoEntries.Count)
                return;

            string name = GetFileName(DemoEntries[index]);
            if (name != "")
            {
                File.Delete(Path.Combine(FilePath, name));
                File.Delete(Path.Combine(FilePath, name.Replace(".dem", ".sav")));

                if (DemoEntries[index].DemoInfo.Pticks < 0)
                    File.Delete(Path.Combine(FilePath, FileHandling.AddToFilename(name, "_2")));
            }
            DemoEntries.RemoveAt(index);
        }
    }
}

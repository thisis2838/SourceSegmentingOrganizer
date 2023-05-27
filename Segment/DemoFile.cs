using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Text.Encoding;
using static System.Math;
using static System.BitConverter;
using static System.Globalization.CultureInfo;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace source_segmenting_organizer.Segment
{
    public class DemoFile : FileBase
    {
        public string MapName { get; private set; }
        public string PlayerName { get; private set; }

        // NEVER get tick count from ticks list, as there are stray ticks we would wanna include
        // that aren't part of timing
        public int MaxIndex = 0;
        public int TotalTicks => MaxIndex + (Forms.MainForm.Settings.ZerothTick ? 1 : 0);
        public int EndIndex { get; private set; } = -1;
        public int MeasuredTicks => EndIndex + (Forms.MainForm.Settings.ZerothTick ? 1 : 0);
        public int DisplayedTickCount { get; private set; }

        public DemoFile(string filePath) : base(filePath)
        {
            if (!IsValid())
                return;

            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var br = new BinaryReader(fs))
            {
                br.BaseStream.Seek(8 + 4 + 4 + 260, SeekOrigin.Current);
                PlayerName = ASCII.GetString(br.ReadBytes(260)).TrimEnd('\0');
                MapName = ASCII.GetString(br.ReadBytes(260)).TrimEnd('\0');
                br.BaseStream.Seek(260, SeekOrigin.Current);

                br.BaseStream.Seek(4, SeekOrigin.Current);
                DisplayedTickCount = br.ReadInt32();
                br.BaseStream.Seek(4, SeekOrigin.Current);

                var signOnLen = br.ReadInt32();

                try
                {
                    byte command = 0x0;

                    while (command != 0x07)
                    {
                        command = br.ReadByte();
                        if (command == 0x07)
                        {
                            if (EndIndex == -1)
                                EndIndex = MaxIndex;

                            break;
                        }

                        var tick = br.ReadInt32();
                        if (tick >= 0)
                            MaxIndex = tick;

                        switch ((DemoPacketType)command)
                        {
                            case DemoPacketType.SIGNON:
                                {
                                    br.BaseStream.Seek(signOnLen, SeekOrigin.Current);
                                }
                                break;
                            case DemoPacketType.PACKET:
                                {
                                    br.BaseStream.Seek(4, SeekOrigin.Current);
                                    float x = br.ReadSingle();
                                    float y = br.ReadSingle();
                                    float z = br.ReadSingle();
                                    br.BaseStream.Seek(68L, SeekOrigin.Current);
                                    var packetLen = br.ReadInt32();
                                    br.BaseStream.Seek(packetLen, SeekOrigin.Current);
                                }
                                break;
                            case DemoPacketType.CONSOLECMD: // console commands
                                {
                                    var concmdLen = br.ReadInt32();
                                    string cmd = ASCII.GetString(br.ReadBytes(concmdLen - 1)).Trim('\0', ' ');

                                    if (!string.IsNullOrWhiteSpace(Forms.MainForm.Settings.EndTag) && 
                                        cmd.Contains(Forms.MainForm.Settings.EndTag))
                                        EndIndex = MaxIndex;

                                    br.BaseStream.Seek(1, SeekOrigin.Current); // skip null terminator
                                }
                                break;
                            case DemoPacketType.USERCMD: // user commands
                                {
                                    br.BaseStream.Seek(4, SeekOrigin.Current); // skip sequence
                                    var userCmdLen = br.ReadInt32();
                                    br.BaseStream.Seek(userCmdLen, SeekOrigin.Current);
                                }
                                break;
                            case DemoPacketType.STRINGTABLES:
                                {
                                    var stringTableLen = br.ReadInt32();
                                    br.BaseStream.Seek(stringTableLen, SeekOrigin.Current);
                                }
                                break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show($"Problem while parsing {Path.GetFileName(filePath)}, file may be corrupted!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //TotalTicks++;
            }
        }

        public override string ToString()
        {
            return $"{FileName} [{TotalTicks} ticks]";
        }

		public override int GetHashCode()
		{
            return this.Hash.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            if (!(obj is DemoFile)) return false;

            // TODO: may want a more rigirous check than this...
            return ((obj as DemoFile).Hash != Hash);
        }
    }


    public enum DemoPacketType
    {
        SIGNON = 1,
        PACKET,
        SYNCTICK,
        CONSOLECMD,
        USERCMD,
        DATATABLES,
        STOP,
        STRINGTABLES
    }
}

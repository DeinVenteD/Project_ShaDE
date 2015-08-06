using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace TakeOne
{
    public static class LogManager
    {
        private static List<string> Entries = new List<string>();
        public static void Write(string Entry)
        {
            Entries.Add(Entry);
        }
        public static void ClearLog()
        {
            Entries.Clear();
        }
        public static void WriteLog(string FilePath)
        {
            FileStream Stream = new FileStream(FilePath, FileMode.Create);
            StreamWriter Writer = new StreamWriter(Stream);
            for (int i = 0; i < Entries.Count; i++)
                Writer.WriteLine(Entries[i]);
            Writer.Close();
        }
        public static List<string> GetLogEntries()
        {
            return Entries;
        }
    }
}

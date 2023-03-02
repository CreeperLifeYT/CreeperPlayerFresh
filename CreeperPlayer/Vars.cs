using System;
using System.Collections.Generic;

namespace CreeperPlayer
{
    public static class Vars
    {
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;

        public static readonly string BassPlugins = Vars.AppPath + @"\BassPlugins\";

        public static List<string> Files = new List<string>();

        public static int CurrentTrackNumber;

        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }
    }
}

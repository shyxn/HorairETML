using System;
using System.Collections.Generic;
using System.IO;

namespace HorairETML
{
    public class Utils
    {
        public List<string> funWebsites = new List<string>();
        public string currentVersion = "v1.1.2";
        public Utils()
        {
            GetWebSites();
        }
        public void GetWebSites()
        {
            StreamReader websitesReader = new StreamReader(File.OpenRead(Environment.CurrentDirectory + "\\Assets\\websites.csv"));
            while (!websitesReader.EndOfStream)
            {
                funWebsites.Add(websitesReader.ReadLine());
            }
        }
    }
}

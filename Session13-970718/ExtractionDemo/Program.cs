using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            var siteContent = client.DownloadString("https://stackoverflow.com/");
            //client.DownloadFile("https://tpc.googlesyndication.com/simgad/10268872695196585037", "1.jpg");
            using (StreamWriter sw = new StreamWriter("site-content.txt"))
            {
                sw.WriteLine(siteContent);
                //sw.Flush();
            }

            Regex re = new Regex("href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))");
            var matches = re.Matches(siteContent);
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Groups[1]);
            }

            Console.ReadKey();
        }
    }
}

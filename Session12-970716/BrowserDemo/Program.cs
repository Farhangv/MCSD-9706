using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveSelector();
        }

        static void DriveSelector()
        {
            Console.Clear();
            DriveInfo[] drives = 
                DriveInfo.GetDrives()
                .Where(d => d.IsReady).ToArray();//این خط درایو های آماده را انتخاب میکند
            for (int i = 0; i < drives.Length; i++)
            {
                Console.WriteLine($"{i+1}.{drives[i]}[{drives[i].VolumeLabel}]");
            }
            Console.WriteLine("______________");
            Console.Write("Select Drive Item Number:");
            var selectedItem = int.Parse(Console.ReadLine());
            DirectoryBrowser(drives[selectedItem - 1].Name);
        }

        static void DirectoryBrowser(string path)
        {
            Console.Clear();
            DirectoryInfo di = new DirectoryInfo(path);//دایرکتوری جاری
            DirectoryInfo[] subDirectories = di.GetDirectories();
            for (int i = 0; i < subDirectories.Length; i++)
            {
                Console.WriteLine($"{i+1}.{subDirectories[i].Name}");
            }
            FileInfo[] files = di.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                Console.Write($"{subDirectories.Length + i + 1}.{files[i].Name}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[File]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            Console.WriteLine("______________");
            Console.Write("Select Item Number (Or type 0 for parent directory):");
            var selectedItem = int.Parse(Console.ReadLine());
            if (selectedItem == 0)//Parent
            {
                if (di.Parent != null)
                    DirectoryBrowser(di.Parent.FullName);
                else
                    DriveSelector();
            }
            else if (selectedItem <= subDirectories.Length)//Directory
            {
                DirectoryBrowser(subDirectories[selectedItem - 1].FullName);
            }
            else//File
            {
                var filePath = files[selectedItem - subDirectories.Length - 1].FullName;
                Process.Start(filePath);
                DirectoryBrowser(di.FullName);
            }
        }
    }
}

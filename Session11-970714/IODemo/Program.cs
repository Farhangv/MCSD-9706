using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace IODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DriveInfo[] drives = DriveInfo.GetDrives();
            ////foreach (var drive in drives)
            //for (int i = 0; i < drives.Length; i++)
            //{
            //    if(drives[i].IsReady)
            //        Console.WriteLine($"{drives[i]}({drives[i].VolumeLabel})[{drives[i].DriveType}]\t{drives[i].TotalFreeSpace/1024/1024/1024} GB\t{drives[i].TotalSize/1024/1024/1024} GB\t{drives[i].DriveFormat}");
            //    else
            //        Console.WriteLine($"{drives[i]}[{drives[i].DriveType}]\tIs Not Ready!");
            //}

            DirectoryInfo di =  new DirectoryInfo(@"D:\Development\Courses\CourseVideos\MCSD-9706");
            //var subDirectories = di.GetDirectories();
            //for (int i = 0; i < subDirectories.Length; i++)
            //{
            //    Console.WriteLine($"{subDirectories[i].FullName}\t{subDirectories[i].Name} ");

            //}

            var files = di.GetFiles();
            //for (int i = 0; i < files.Length; i++)
            //{
            //    Console.WriteLine($"{files[i].FullName}\t{files[i].Name}\t{files[i].LastWriteTime}");
            //}

            //Console.WriteLine(di.Parent);

            //Process.Start(di.GetFiles()[0].FullName);

            //di.CreateSubdirectory("Test");

            //files[0].CopyTo(@"D:\TestCopy.mp4");


            Console.ReadKey();
        }
    }
}

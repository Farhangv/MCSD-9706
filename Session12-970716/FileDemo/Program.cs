using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////نوشتن
            //using (StreamWriter sw = new StreamWriter(@"myfile.txt", true))
            //{
            //    //sw.AutoFlush = true;
            //    while (true)
            //    {
            //        var input = Console.ReadLine();
            //        if (input == "exit")
            //            break;
            //        sw.WriteLine(input);
            //        sw.Flush();
            //    }
            //}//sw.Close();

            //خواندن
            
            using (StreamReader sr = new StreamReader("myfile.txt"))
            {
                //while (sr.Peek() != -1)
                //{
                //    Console.Write((char)sr.Read());
                //}

                //while (sr.Peek() != -1)
                //{
                //    Console.WriteLine(sr.ReadLine());
                //}

                Console.WriteLine(sr.ReadToEnd());
            }

            
            Console.ReadKey();
        }
    }
}

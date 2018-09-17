using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParameterOptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountDown(10, 4, 2);
            //Console.WriteLine("------------------");
            //CountDown(10);

            //Console.WriteLine("------------------");
            CountDown(10, interval: 2);
            Console.ReadKey();
        }

        static void CountDown(int start, int finish = 0, int interval = 1)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Cyan;
            for (int i = start; i > finish; i = i - interval)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2);
                //Console.Beep(5000, 500);
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }


    }
}

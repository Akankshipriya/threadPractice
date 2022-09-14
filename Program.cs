using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //threading means parallel code execution
            Thread workerThread = new Thread(new ThreadStart(printNumbers));
            workerThread.Start();
            justNamePrint();
            Console.ReadLine();

        }
        static void printNumbers()
        {
            int i = 20;
            Console.WriteLine("Printing from other thread");
            while (i != 0)
            {
                Console.WriteLine("From other thread {0}", i);
                Thread.Sleep(200);
                i--;
            }
        }
        static void justNamePrint()
        {
            Console.WriteLine("Just print Name");
            int i= 50;
            while(i!=60)
            {
                Console.WriteLine("From main thread {0}", i);
                Thread.Sleep(500);
                i++;
            }
        }
    }
}

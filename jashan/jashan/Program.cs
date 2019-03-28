using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jashan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading File");
            download();
            Console.ReadLine();
        }
        static void download()
        {
            Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete");
            });
        }
    }
}
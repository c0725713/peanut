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
            Download();
            Console.ReadLine();
        }
        static async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://ibm.com");

            Console.WriteLine(data);
            List myList = new List();
        }
    }
    class Network
    {
        static public Task Download()
        {

            return Task.Run(() => Thread.Sleep(3000));
        }
    }
}
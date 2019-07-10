using System;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting server");

            RunServerAsync().Wait();
        }

        private static async Task RunServerAsync()
        {
            var server = new SoupBinTCP.NET.Server(new ServerListener());
            server.Start();

            string command = "";
            while (command != "x")
            {
                command = Console.ReadLine();
            }

            await Task.FromResult(false);

            server.Shutdown();
        }
    }
}

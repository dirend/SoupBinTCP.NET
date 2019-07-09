using System;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting server");
            var server = new SoupBinTCP.NET.Server(new ServerListener());
            server.Start();
            var command = "";
            while (command != "x")
            {
                command = Console.ReadLine();
            }
            server.Shutdown();
        }
    }
}

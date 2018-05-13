using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Project_SBO
{
    class Program
    {
        static void Main(string[] args)
        {
            StartServer();
        }
        static void StartServer()
        {
            IWebHost host = new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<Startup>()
            .UseUrls("http://localhost:8080")
            .Build();

            host.Run();
        }
    }
}

using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;
namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            //.UseUrls("http://localhost:5050")
            .UseIISIntegration()
            .UseStartup<Startup>()
            .Build();

            host.Run(); 
        }
    }
}

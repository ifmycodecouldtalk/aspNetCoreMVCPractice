using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetCoreMVCPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();          // Creates IHostBuilder to define how IHost will be built
                                            // .Run() is when we start listening for HTTP requests
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>     // configures Kestrel to listen to HTTP requests
                {
                    webBuilder.UseStartup<Startup>();       // Startup defines most of project's configuration
                });
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace myApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
#pragma warning disable CS0618 // Type or member is obsolete
            WebHost.CreateDefaultBuilder(args)
                .UseApplicationInsights()
#pragma warning restore CS0618 // Type or member is obsolete
                .UseStartup<Startup>();
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace auth0_todo_api
{
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateWebHostBuilder(args).Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args){
        var config = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .Build();
        
        return WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://*:3001")
            .UseConfiguration(config)
            .UseStartup<Startup>();
    }
  }
}

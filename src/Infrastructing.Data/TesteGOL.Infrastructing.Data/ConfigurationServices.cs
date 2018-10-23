using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGOL.Infrastructing.Data
{
    public static class ConfigurationServices
    {
        public static string GetCurrentDirectory()
        {
            return AppContext.BaseDirectory.Remove(AppContext.BaseDirectory.LastIndexOf('\\'));
        }

        public static IConfigurationRoot GetConfiguration()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
               .SetBasePath(AppContext.BaseDirectory)
               .AddJsonFile("appsettings.json")
               .Build();

            return config;
        }
    }
}

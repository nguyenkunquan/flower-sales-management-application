using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AppConfigManager
    {
        private static IConfiguration _configuration;

        public AppConfigManager()
        {
            _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true).Build();     
        }

        public string Password()
        {
            return _configuration["Admin:0:Password"];
        }

        public string Email()
        {
            return _configuration["Admin:0:Email"];
        }
    }
}

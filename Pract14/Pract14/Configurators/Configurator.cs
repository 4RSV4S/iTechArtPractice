using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Pract14
{
    public class Configurator
    {
        private static readonly Lazy<IConfiguration> SConfiguration;
        private static IConfiguration Configuration => SConfiguration.Value;
        

        public static string BaseURL => Configuration[nameof(BaseURL)];
        public static string Password => Configuration[nameof(Password)];
        public static string LoginPage_END_POINT => Configuration[nameof(LoginPage_END_POINT)];
        public static string InventoryPage_END_POINT => Configuration[nameof(InventoryPage_END_POINT)];
        public static string CartPage_END_POINT => Configuration[nameof(CartPage_END_POINT)];

        static Configurator()
        {
            SConfiguration = new Lazy<IConfiguration>(BuildConfiguration);
        }

        private static IConfiguration BuildConfiguration()
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json");
            return builder.Build();
        }
    }
}

using System;
using System.IO;
using System.Threading.Tasks;
//using System.Text.Json;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace Pract6
{
    class Program //: ILogger<T>
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"JSonFiles\info.json");
            string json;
            using (StreamReader sr = new StreamReader(path))
            {
                json = sr.ReadToEnd();
            }
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var shops = JsonConvert.DeserializeObject<RootObject>(json, settings);
            //Console.WriteLine(shops.Shops[0].Id);
            shops.DispalyIfAvaliable();
            var factory = new LoggerFactory();//.AddDebug(LogLevel.Debug);
            ILogger logger = factory.CreateLogger<RootObject>();
            logger.Log(LogLevel.Debug, "Some message to log");
            shops.WantToBuy();

    }
    }
}

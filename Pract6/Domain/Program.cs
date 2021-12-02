using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace Pract6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"JSonFiles\info.json");
            string json;
            ILoggerFactory loggerFactory = LoggerFactory.Create(config =>
            {
                config.AddConsole();
            });
            ILogger<RootObject> logger = loggerFactory.CreateLogger<RootObject>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    json = sr.ReadToEnd();
                }
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                var shops = JsonConvert.DeserializeObject<RootObject>(json, settings);
                shops.DispalyIfAvaliable();
                shops.WantToBuyPhone();
            }
            catch (FileNotFoundException)
            {
                logger.LogError("The file or directory cannot be found.");
            }
            catch (DirectoryNotFoundException)
            {
                logger.LogError("The file or directory cannot be found.");
            }
            catch (DriveNotFoundException)
            {
                logger.LogError("The drive specified in 'path' is invalid.");
            }
            catch (PathTooLongException)
            {
                logger.LogError("'path' exceeds the maxium supported path length.");
            }
            catch (UnauthorizedAccessException)
            {
                logger.LogError("You do not have permission to create this file.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 32)
            {
                logger.LogError("There is a sharing violation.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 80)
            {
                logger.LogError("The file already exists.");
            }
            catch (IOException e)
            {
                logger.LogError($"An exception occurred:\nError code: " +
                                  $"{e.HResult & 0x0000FFFF}\nMessage: {e.Message}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EF_Core_CRM
{
    static class AppSettings
    {
        private static readonly string fileName = "AppSettings.json";
        public static async Task LoadConfiguraion()
        {
            string pathToFile = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            if (File.Exists(pathToFile))
            {
                string json = await File.ReadAllTextAsync(pathToFile);

                Dictionary<string, string> settings = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

                if (settings is not null)
                {
                    foreach (var setting in settings)
                    {
                        Environment.SetEnvironmentVariable(setting.Key, setting.Value);
                    }
                }
                else
                {
                    throw new ArgumentException("The file is empty or the content is not a valid JSON.");
                }
            }
            else
            {
                throw new FileNotFoundException($"The file {pathToFile} does not exist.");
            }
        }
    }
}

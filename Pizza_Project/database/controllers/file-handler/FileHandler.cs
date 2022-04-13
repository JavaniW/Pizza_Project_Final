using System;
using System.IO;
using System.Text.Json;
using Pizza_Project.database.Models;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Pizza_Project.database.controllers.file_handler
{
    public static class DatabaseHandler
    {
        //private static string path = @"database/data-storage/business-data.json";
        //private static string path = Application.StartupPath + @"\\database\data-storage\business-data.json";
         //private static string path = Application.StartupPath + "\\database\\data-storage\\business-data.json";
         //private static string path = @"C:/Users/whard/source/repos/Pizza_Project4-13-22/database/data-storage/business-data.json";
        private static string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
        private static string exeDir = Path.GetDirectoryName(exeFile);
        private static string path = Path.Combine(exeDir, "..\\..\\data-storage\\business-data.json");


        public static async void Write(PizzaDatabase payload) {
            File.WriteAllText(path, "");
            var options = new JsonSerializerOptions {WriteIndented = true};
            await using FileStream writeStream = File.OpenWrite(path);
            await JsonSerializer.SerializeAsync<PizzaDatabase>(writeStream, payload, options);
            await writeStream.DisposeAsync();
        }

        public static async Task<PizzaDatabase> Read() {
            await using FileStream openStream = File.OpenRead(path);
            return await JsonSerializer.DeserializeAsync<PizzaDatabase>(openStream);
        }
    }
}
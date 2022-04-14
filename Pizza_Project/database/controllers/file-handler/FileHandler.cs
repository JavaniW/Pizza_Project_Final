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
        private static string path = System.IO.Path.GetDirectoryName(
         System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + @"\\database\\data-storage\\business-data.json";

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
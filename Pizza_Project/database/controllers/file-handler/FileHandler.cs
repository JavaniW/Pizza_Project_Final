using System;
using System.IO;
using System.Text.Json;
using Pizza_Project.database.Models;
using System.Threading.Tasks;
// using System.Windows.Forms;
using System.Reflection;

namespace Pizza_Project.database.controllers.file_handler
{
    public static class DatabaseHandler
    {
        private static string Path = System.IO.Path.GetDirectoryName(
           System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + @"\\database\\data-storage\\business-data.json";
        
        public static async void Write(PizzaDatabase payload) {
            File.WriteAllText(Path, "");
            var options = new JsonSerializerOptions {WriteIndented = true};
            await using FileStream writeStream = File.OpenWrite(Path);
            await JsonSerializer.SerializeAsync<PizzaDatabase>(writeStream, payload, options).ConfigureAwait(false); ;
            await writeStream.DisposeAsync().ConfigureAwait(false);
        }

        public static async Task<PizzaDatabase> Read() {
            await using FileStream openStream = File.OpenRead(Path);
            return await JsonSerializer.DeserializeAsync<PizzaDatabase>(openStream).ConfigureAwait(false);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project.helper_classes
{
    static class FilePath
    {
        public static string GetPath(string path)
        {
            return System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + path;

        }
    }
}

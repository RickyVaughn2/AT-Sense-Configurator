using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sense_Configurator
{
    class Logger
    {
        public static string DeBug = "nothing";

        public static void WriteLog (string FileName, string Entry)
        {
            using (StreamWriter sw = File.AppendText(FileName))
            {
                sw.WriteLine(Entry);
            }
        }
    }
}

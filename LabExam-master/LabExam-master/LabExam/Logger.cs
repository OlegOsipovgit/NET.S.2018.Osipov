using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabExam
{
    class Logger
    {
        public static void Log(string s)
        {
            File.AppendText("log.txt").Write(s);
        }
    }
}

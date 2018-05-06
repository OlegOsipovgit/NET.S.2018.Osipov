using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace LabExam
{
    class PrinterManager
    {

        public PrinterManager()
        {
            Printers = new List<object>();
        }

        public static List<object> Printers { get; set; }

        public static void Add(Printer printer)
        {
            if (!Printers.Contains(printer))
            {
                Printers.Add(printer);
                Console.WriteLine("Printer added");
            }
        }

        public static void Print(Printer p1)
        {
            if (!Printers.Contains(p1))
            {
                Printers.Add(p1);
            }
            Logger.Log("Printing started");
            
            var o = new OpenFileDialog();
            o.ShowDialog();
            var f = File.OpenRead(o.FileName);
            p1.Print(f);

            Logger.Log("Printing ended");


        }
    }
}

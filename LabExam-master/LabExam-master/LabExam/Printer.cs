using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LabExam
{
    public class Printer:AbstractPrinter
    {
        public Printer(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public override string Name { get; set; }
        public override string Model { get; set; }

        public static event EventHandler<PrinterEventArgs> PrinterEvent;
        protected virtual void Start() => PrinterEvent?.Invoke(this, new PrinterEventArgs(this,"Printing started"));
        protected virtual void End() => PrinterEvent?.Invoke(this, new PrinterEventArgs(this,"Printing ended"));
        public static void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}

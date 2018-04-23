using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2; 

namespace Task2.Tests
{
    class Class1
    {
        public static void Main(string[] args)
        {
            RandomBytesFileGenerator a = new RandomBytesFileGenerator();
            Console.WriteLine(a.WorkingDirectory);
            Console.WriteLine(a.FileExtension);
            a.GenerateFiles(5,5);
            a.WriteBytesToFile("sdsd", a.GenerateFileContent(5));
            RandomCharsFileGenerator b = new RandomCharsFileGenerator();
            Console.WriteLine(b.WorkingDirectory);
            Console.WriteLine(b.FileExtension);
            b.GenerateFileContent(5);
            b.GenerateFiles(5, 5);
            Console.WriteLine(b.RandomString(5));
            Console.ReadKey();

        }
    }
}

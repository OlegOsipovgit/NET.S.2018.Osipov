using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
  
        // класс и его члены объявлены как public
        [Serializable]
        public class Person
        {
          
            public Person()
            { }
            public Person(string[] urlAdresses)
            {
            this.urlAdresses = urlAdresses;
            }

          
          public string[] urlAdresses = new string[100];
          

        }

   

    public class Program
        {
        public string path = @"C:\Users\Ольга\source\repos\NET.S.2018.Osipov\NET.S.2018.Osipov.20\text.txt";
        public string[] urlAdresses = new string[100];
        public void Method()
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    urlAdresses[i] = line; i++;
                }
            }


        }

        static void Main(string[] args)
            {

            Program a = new Program();
            a.Method();
              // объект для сериализации
                Person person = new Person(a.urlAdresses);
              
                Console.WriteLine("Объект создан");

                // передаем в конструктор тип класса
                XmlSerializer formatter = new XmlSerializer(typeof(Person));

                // получаем поток, куда будем записывать сериализованный объект
                using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, person);

                    Console.WriteLine("Объект сериализован");
                }

               
               
            }
        }
    
}

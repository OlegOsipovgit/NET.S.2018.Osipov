using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Broker
    {
        public Stock Stock { get; set; }

        public string Name { get; set; }

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            Stock = stock;
            Stock.changedStocks+=Update;
        }

        public void Update(object info, StockEventArgs newinfo)
        {
           
            if (newinfo.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, newinfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, newinfo.USD);
        }
    }
}

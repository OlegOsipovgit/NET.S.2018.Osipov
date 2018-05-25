using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Bank 
    {
        public Stock Stock { get; set; }

        public string Name { get; set; }

        public Bank(string name, Stock stock)
        {
            this.Name = name;
            Stock = stock;
            stock.changedStocks += Update;
        }

        public void Update(object info, StockEventArgs e)
        {
            

            if (e.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, e.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, e.Euro);
        }
    }
}

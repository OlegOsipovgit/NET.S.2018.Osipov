using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stock
    {

        public event EventHandler<StockEventArgs> changedStocks;

        public void Market()
        {
            StockEventArgs changedstock = new StockEventArgs();
            Random rnd = new Random();
            changedstock.USD = rnd.Next(20, 40);
            changedstock.Euro = rnd.Next(30, 50);
            OnChangedStock(changedstock);
        }

        protected virtual void OnChangedStock(StockEventArgs e) => changedStocks(this, e);
    }
}

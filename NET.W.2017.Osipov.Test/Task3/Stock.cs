using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stock
    {

        public event EventHandler<StockEvent> changedStocks = delegate { };

        public void Market()
        {
            StockEvent changedstock = new StockEvent();
            Random rnd = new Random();
            changedstock.USD = rnd.Next(20, 40);
            changedstock.Euro = rnd.Next(30, 50);
            OnChangedStock(changedstock);
        }

        protected virtual void OnChangedStock(StockEvent e) => changedStocks(this, e);
    }
}

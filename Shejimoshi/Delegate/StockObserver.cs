using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Delegate
{
    class StockObserver
    {
        private string name;
        private Subject sub;

        public StockObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStockmarket()
        {
            Console.WriteLine("{0} {1} close stock", sub.SubjectState, name);
        }
    }
}

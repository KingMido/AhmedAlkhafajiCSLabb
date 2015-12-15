using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Assessment
{
    public class StockItem
    {
        int id;
        string name;
        int stockCount;

        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int StockCount
        {
            get { return stockCount; }
            set { stockCount = value; }
        }

        public StockItem()
        {
            id = this.Id;
            name = this.Name;
            stockCount = this.StockCount;
        }

        //public StockItem(int id, string name, int stockCount )
        //{
        //    id = Id;
        //    name = Name;
        //    stockCount = StockCount;

        //}
        public override string ToString() => $"id: {Id},\nNamn: {Name}, \nAntal: {StockCount}";
    }
}

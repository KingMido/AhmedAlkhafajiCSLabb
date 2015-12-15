using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Assessment
{

    class EcoStockItem : StockItem
    {
        //public bool eco;
        public string ekologisk="";

        //public bool Eco
        //{
        //    get { return eco; }
        //    set
        //    {
        //        ekologisk = eco ? "ja" : "nej";
        //    }
        //}

        public string Ekologisk
        {
            get {return ekologisk;}
            set {ekologisk = value;}
        }

        public EcoStockItem()
        {
      
            Ekologisk = this.ekologisk;
        }

        public override string ToString() => $"Är varan ekologisk: {Ekologisk}" + base.ToString();
    }
}

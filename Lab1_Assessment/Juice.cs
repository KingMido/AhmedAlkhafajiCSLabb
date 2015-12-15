using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Assessment
{
    class Juice : EcoStockItem
    {
        private string typ;

        public string Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public Juice()
        {
            Typ = this.typ;
        }

        public override string ToString()
            => $"Typ av juice: {Typ}" + base.ToString();
    }
}
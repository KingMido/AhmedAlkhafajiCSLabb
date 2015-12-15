using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Assessment
{
    class Plate : StockItem
    {
        public string typ;

        public string Typ
        {
            get { return typ; }
            set
            {
                if(value == "Flat"|| value == "Deep")

                typ = value;
                else
                {
                    Console.WriteLine("Vänligen ange Flat eller Deep!");
                }
            }
        }

        public Plate()
        {
            Typ = this.typ;
            
        }

        public override string ToString()
        {
            return $"Typ: {Typ}" + base.ToString();
        }
    }
}

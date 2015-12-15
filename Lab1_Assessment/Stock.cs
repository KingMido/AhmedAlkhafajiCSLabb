using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Assessment
{
    class Stock
    {
        public static int stockCounter = 0;
        public StockItem[] stockItems = new StockItem[10];
        public StockItem this[int index]
        {
            get { return stockItems[index]; }
            set
            {
                stockItems[index] = value;
            }

        }

        public void AddItem(StockItem item)
        {
            if (stockCounter < stockItems.Length)
                this[stockCounter] = item;
            stockCounter++;
        }

        public StockItem GetItem(int itemId)
        {
            //Console.WriteLine("Skriv in varans ID nr: ");
            for (int i = 0; i < stockItems.Length; i++)
            {

                if (stockItems[i] != null && stockItems[i].Id == itemId)
                    return stockItems[i];
            }

            return null;
        }
    }
}

/*
GetItem(int.parse(console.readline()));

GetItem(itemId)
{
//ta emot int parameter och kolla efter matchande id i indexern
//Den skriver ut itemcount på varan och frågar efter nya värdet som ska änras efter

for(i=0;i< stock.lenght, i++){
	if(stockitems[i] != null){
		console.writeline()
	}
}	
}
*/

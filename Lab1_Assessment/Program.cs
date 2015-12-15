using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stocStock = new Stock();
            Juice juice = new Juice();
            Plate plate = new Plate();
            string alt = "";
            while (alt != "4")
            {
                StockItem nyVara = new StockItem();
                Console.WriteLine("1-Skapa vara.\n2-Inventera vara.\n3-Lista vara.\n4-Avsluta.");
                Console.Write("(Välj mellan 1-4)\n");
                alt = Console.ReadLine();
                switch (alt)
                {
                    case "1":
                        int val;
                        Console.WriteLine("Vill du: 1. Skapa ny vara\n2.Skapa en Juice\n3.Skapa en Plate");
                        val = int.Parse(Console.ReadLine());
                        if (val == 1)
                        {
                            Console.WriteLine("Ange ett id för varan: ");
                            nyVara.Id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ange ett namn för varan: ");
                            nyVara.Name = Console.ReadLine();
                            Console.WriteLine("Ange antal: ");
                            nyVara.StockCount = int.Parse(Console.ReadLine());
                            stocStock.AddItem(nyVara);

                        }
                        else if (val == 2)
                        {
                            Console.WriteLine("Ange ett id för Juice: ");
                            juice.Id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ange ett namn för Juicen: ");
                            juice.Name = Console.ReadLine();
                            Console.WriteLine("Ange antal: ");
                            juice.StockCount = int.Parse(Console.ReadLine());
                            Console.WriteLine("Är varan Ekologisk? ja / nej");
                            juice.ekologisk =(Console.ReadLine());
                            Console.WriteLine("Ange typ av Juice: ");
                            juice.Typ = Console.ReadLine();
                            stocStock.AddItem(juice);


                         }
                        
                        else
                        {
                            Console.WriteLine("Ange ett id för Plate: ");
                            plate.Id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ange ett namn för Plate: ");
                            plate.Name = Console.ReadLine();
                            Console.WriteLine("Ange antal: ");
                            plate.StockCount = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ange typ av Plate: ");
                            plate.Typ = Console.ReadLine();
                            stocStock.AddItem(plate);

                        }
                        break;

                    case "2": // inventera vara
                        Console.WriteLine("Ange ID nr på varan som ska inventeras!");
                        StockItem stockitem = stocStock.GetItem(int.Parse(Console.ReadLine()));
                        Console.WriteLine(stockitem.StockCount);
                        Console.WriteLine("Skriv uppdaterat antal: ");
                        stockitem.StockCount = int.Parse(Console.ReadLine());
                        Console.WriteLine("Uppdaterat antal: " + stockitem.StockCount);

                        
                        break;

                    case "3":
                        //Lista varor
                        Console.WriteLine("Tryck Enter föt att lista varor");
                        for (int i = 0; i < stocStock.stockItems.Length; i++)
                        {
                            Console.WriteLine(stocStock.stockItems[i]);
                        }

                        break;

                    case "4":
                        Console.WriteLine("Hej då!");
                        break;

                    default:
                        Console.WriteLine("Inget alternativ har valts!");
                        break;

                }

            }
        }
    }
}

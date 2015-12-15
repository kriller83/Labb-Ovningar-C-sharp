using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Assement
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            int stockCount;
            string input;
            int result;
            MenuePrinter mainMenue = new MenuePrinter();
            Stock stock = new Stock();
            while (true)
            {
                int menueChoise = mainMenue.StartMenue();
                if (menueChoise == 1)
                {
                    stock = mainMenue.CreateItem(stock);
                }
                else if (menueChoise == 2)
                {
                    Console.WriteLine("Enter the id of the item");
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (int.TryParse(input, out result))
                        {
                            if (result >= 1 && result <= 99)
                            {
                                id = result;
                                break;
                            }
                            else
                                Console.WriteLine("Incorerct input, try again!");
                        }
                    }
                    Console.WriteLine("Amount of the item");
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (int.TryParse(input, out result))
                        {
                            if (result >= 1 && result <= 1000)
                            {
                                stockCount = result;
                                break;
                            }
                            else if (result <= 0)
                                Console.WriteLine("Must be a positive number added to our glorious stock!");
                            else
                                Console.WriteLine("Can't hold more than 1000!");
                        }
                    }
                    mainMenue.InventoryItem(stockitems: stock.StockItems, id: id, stockCount: stockCount);
                } else if (menueChoise == 3)
                {
                    mainMenue.ListItems(stock.StockItems);

                }
                else
                {
                    break;
                }
            }



            //Juice bravo1 = new Juice() {
            //    Type = "orange",
            //    Mark = "Krav",
            //    Id = 1,
            //    Name = "Bravo",
            //    StockCount = 3 };

            //Plate flatPlate1 = new Plate() { Type = "flat", Id = 2, Name = "Flat plate", StockCount = 30 };
            //stock[0] = bravo1;
            //stock[1] = flatPlate1;

            //stock.AddItem(bravo1);
            //stock.AddItem(flatPlate1);
            //Console.WriteLine(stock.GetItem(2));



            //stock.Stockitem[0] = flatPlate;
            //stock.Stockitem[1] = bravo;
        }
    }
}

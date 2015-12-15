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
            stock.AddItem(new Juice { Id = 2, Mark = "krav",  Name = "juice", StockCount = 10, Type = "apple"});
            stock.AddItem(new Juice {Id = 3, Mark = "EG", Name = "juice", StockCount = 20, Type = "orange"});
            stock.AddItem(new Plate {Id = 4, Name = "plate", Type = "deep", StockCount = 15});
            stock.AddItem(new Plate {Id = 5, Name = "plate", Type = "flat", StockCount = 25});
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
        }
    }
}

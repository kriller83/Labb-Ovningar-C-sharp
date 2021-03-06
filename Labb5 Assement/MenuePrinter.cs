﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Assement
{
    class MenuePrinter : Stock
    {
        private string menueChoise;
        int id;
        string name;
        string type;
        int stockCount;
        string mark;

        public string MenueChoise
        {
            get { return menueChoise; }
            set
            {
                if (MenueChoise == "1" || MenueChoise == "2" || MenueChoise == "3" || MenueChoise == "4")
                    menueChoise = value;
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 1 && value <= 99)
                    id = value;
                else
                    Console.WriteLine("Incorerct input, try again!");
            }

        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "juice" || value == "plate")
                    name = value;
                else
                    Console.WriteLine("Invalid name, try again!");
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (value == "apple" || value == "orange" || value == "deep" || value == "flat")
                    type = value;
                else
                    Console.WriteLine("Wrong type!");
            }
        }

        public string Mark
        {
            get { return mark; }
            set
            {
                if (value == "krav" || value == "EG" || value == "other")
                    mark = value;
            }
        }

        public int StockCount
        {
            get { return stockCount; }
            set
            {
                if (value >= 1 && value <= 1000)
                    stockCount = value;
                else if (value <= 0)
                    Console.WriteLine("Must be a positive number added to our glorious stock!");
                else
                    Console.WriteLine("Can't hold more than 1000!");
            }
        }

        public int StartMenue()
        {
            Console.WriteLine(@"1 - Skapa vara
2 - Inventera vara
3 - Lista varor
4 - Avsluta");
            while (true)
            {
                menueChoise = Console.ReadLine();
                if (MenueChoise == "1" || MenueChoise == "2" || MenueChoise == "3" || MenueChoise == "4")
                {
                    break;
                }
                Console.WriteLine("Invalid choise! Chose again!");
            }
            return int.Parse(MenueChoise);
        }

        public Stock CreateItem(Stock stock)  
        {
            StockItem stockitem;
            Console.WriteLine("To make an item we need Id, Name, Type, Stock count and if it's an ecological item.\r\n" +
                              "Enter the new items Id (1-99)");
            int result;
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    Id = result;
                    if (Id > 0 && Id < 100)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Enter the new items Name (plate or juice)");
            while (true)
            {
                Name = Console.ReadLine();
                if (Name == "juice" || Name == "plate")
                {
                    if (Name == "juice")
                    {
                        stockitem = new Juice() { Id = id };
                    }
                    else if (Name == "plate")
                    {
                        stockitem = new Plate() { Id = id };
                    }
                    break;
                }

            }
            if (Name == "juice")
            {
                Console.WriteLine("Enter the type (apple or orange)");
                while (true)
                {
                    Type = Console.ReadLine();
                    if (Type == "apple" || Type == "orange")
                    {
                        break;
                    }
                }
                Console.WriteLine("Is the juice; krav, EG?");
                while (true)
                {
                    Mark = Console.ReadLine();
                    if (Mark == "krav" || Mark == "EG")
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter the type (deep or flat)");
                while (true)
                {
                    Type = Console.ReadLine();
                    if (Type == "deep" || Type == "flat")
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Enter the amount of items you wish to add to the stock");

            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    StockCount = result;
                    if (StockCount >= 1 && StockCount <= 1000)
                    {
                        break;
                    }
                }
            }
            if (name == "juice")
            {
                stockitem = new Juice() { Mark = mark, Id = id, Name = name, StockCount = stockCount, Type = type };
            }
            else
            {
                stockitem = new Plate() { Id = id, Name = name, StockCount = stockCount, Type = type };
            }
            stock.AddItem(stockitem);
            return stock;
        }

        public void InventoryItem(StockItem[] stockitems, int id, int stockCount)
        {
            for (int i = 0; i < stockitems.Length - 1; i++)
            {
                if (stockitems[i] != null && stockitems[i].Id == id)
                {   //Om stockitems inte är lika med noll så kollar den nästa check.
                    stockitems[i].StockCount = stockCount;
                    return;
                }
            }
            Console.WriteLine("No item(s) found!");
        }

        public void ListItems(StockItem[] stockItems)
        {
            foreach (var stockItem in stockItems)
            {
                if (stockItem != null)
                {
                    Console.Write(stockItem);
                    //Console.Write($"Id: {stockItem.Id}, Name: {stockItem.Name} In stock: {stockItem.StockCount}");
                    if (stockItem is EcoStockItem)
                        Console.WriteLine(" This is an ecological item.");
                    else
                        Console.WriteLine();
                }
            }
        }
    }                                                               //Fixa ListItems och lägg till confim meddelanden!
}
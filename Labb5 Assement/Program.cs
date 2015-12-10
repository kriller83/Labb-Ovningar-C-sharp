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
            MenuePrinter mainMenue = new MenuePrinter();
            Stock stock = new Stock();
            int menueChoise = mainMenue.StartMenue();
            if (menueChoise == 1)
            {
                mainMenue.CreateItem();
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

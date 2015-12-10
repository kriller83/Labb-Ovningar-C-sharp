using System;
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
        bool isEco;

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
            get{return id;}
            set
            {
                if (value >= 1 && value <= 99)
                    id = value;
            }
        }

        public int StartMenue()
        {
            bool runTime = true;
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

        public void CreateItem()
        {

            Console.WriteLine("To make an item we need Id, Name, Type, Stock count ad if it's an ecological item.\r\n" +
                                  "Enter the new items Id (1-99)");
            Id = int.TryParse() Console.ReadLine();


            //AddItem();
        }
    }
}

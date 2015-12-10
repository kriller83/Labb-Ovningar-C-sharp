using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Assement
{
    class Stock
    {
        //private StockItem[] stockItem;

        //public StockItem[] Stockitem
        //{
        //    get { return stockItem; }
        //    set { stockItem = value; }
        //}
        int counter = 0;

        public StockItem[] stockItems = new StockItem[10];
        public StockItem this[int index]  //this syftar till instansen
        {
            get
            {
                if (index >= 0 && index < stockItems.Length)   //Kontroll på at man hämtar värden inom arrayns gränser
                    return stockItems[index];
                else
                    throw new Exception("Out of boundary");
            }
           private set
            {
                if (index >= 0 && index < stockItems.Length)
                    stockItems[index] = value;
                throw new Exception("Out of boundary");
            }
        }

        public void AddItem(StockItem item)
        {

            stockItems[counter] = item;
            counter++;
        }

        public StockItem GetItem(int itemId)
        {
            for (int i = 0; i < stockItems.Length; i++)
            {
                if (stockItems[i].Id == itemId)
                    return stockItems[i];
            }
            throw new Exception("No item with that Id!");
        }

    }
}
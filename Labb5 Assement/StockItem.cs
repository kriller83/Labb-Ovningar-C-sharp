using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Assement
{
    class StockItem
    {
        int id;
        string name;
        int stockCount;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int StockCount
        {
            get { return stockCount; }
            set { stockCount = value; }
        }
        public StockItem()
        {
            id = 23;
            name = "bravo";
            stockCount = 1;
        }
        public StockItem(int id, string name, int stockCount)
        {
            Id = id;
            Name = name;
            StockCount = stockCount;
        }
        public override string ToString() => $"Stock count: {StockCount} Name: {Name} Id: {Id}";
    }
}

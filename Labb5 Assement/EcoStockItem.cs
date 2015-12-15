using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Assement
{
    class EcoStockItem : StockItem
    {
        private string mark;

        public string Mark
        {
            get { return mark; }
            set
            {
                if (value == "krav" || value == "EG" || value == "other")
                    mark = value;
                else
                    throw new Exception("Not a ecological!");
            }
        }
        public EcoStockItem()
        {
            mark = "Normal";
        }
        public override string ToString() => $"Mark: {Mark} {base.ToString()}";
    }
}

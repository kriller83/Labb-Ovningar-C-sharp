using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Assement
{
    class Juice : EcoStockItem
    {
        private string type;

        public string Type
        {
            get { return type; }
            set
            {
                if (value == "apple" || value == "orange")
                    type = value;
                else
                    throw new Exception("Wrong fruit!");
            }
        }
        public Juice()
        {
            type = "apple";
        }
        public Juice(string type)
        {
            Type = type;
        }
        public override string ToString() => $"Juice type: {Type} {base.ToString()}";
    }
}

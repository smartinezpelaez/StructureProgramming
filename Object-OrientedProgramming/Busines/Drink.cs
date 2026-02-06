using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientedProgramming.Busines
{
    public abstract class Drink
    {
        public int Quantity { get; set; }

        protected Drink(int quantity)
        {
            this.Quantity = quantity;
        }

        public string GetQuantity()
        {
            return Quantity + " ml";
        }
        public abstract string GetCategory();
    }
}

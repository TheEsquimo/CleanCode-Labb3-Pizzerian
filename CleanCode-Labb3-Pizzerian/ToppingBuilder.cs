using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public abstract class ToppingBuilder
    {
        protected Topping topping;

        public void CreateNewTopping()
        {
            topping = new Topping();
        }

        public Topping GetTopping()
        {
            return topping;
        }

        public abstract void SetId();
        public abstract void SetName();
        public abstract void SetCost();
    }
}

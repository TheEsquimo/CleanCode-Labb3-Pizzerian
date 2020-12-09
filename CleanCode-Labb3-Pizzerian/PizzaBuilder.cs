using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public Pizza GetPizza()
        {
            return pizza;
        }

        public void CreateNewPizza()
        {
            pizza = new Pizza();
        }

        public abstract void SetId();
        public abstract void SetName();
        public abstract void SetCost();
        public abstract void ApplyToppings();
    }
}

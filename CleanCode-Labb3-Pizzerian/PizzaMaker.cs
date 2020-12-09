using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class PizzaMaker
    {
        private readonly PizzaBuilder builder;

        public PizzaMaker(PizzaBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildPizza()
        {
            builder.CreateNewPizza();
            builder.SetId();
            builder.SetName();
            builder.SetCost();
            builder.ApplyToppings();
        }

        public Pizza GetPizza()
        {
            return builder.GetPizza();
        }
    }
}

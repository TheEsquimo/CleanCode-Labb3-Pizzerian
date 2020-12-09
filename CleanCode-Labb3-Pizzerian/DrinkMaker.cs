using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class DrinkMaker
    {
        private readonly DrinkBuilder builder;

        public DrinkMaker(DrinkBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildDrink()
        {
            builder.CreateNewDrink();
            builder.SetId();
            builder.SetName();
            builder.SetCost();
        }

        public Drink GetDrink()
        {
            return builder.GetDrink();
        }
    }
}

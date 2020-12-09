using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public abstract class DrinkBuilder
    {
        protected Drink drink;

        public Drink GetDrink()
        {
            return drink;
        }

        public void CreateNewDrink()
        {
            drink = new Drink();
        }

        public abstract void SetId();
        public abstract void SetName();
        public abstract void SetCost();
    }
}

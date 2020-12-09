using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class CheeseTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 18;
        }

        public override void SetName()
        {
            topping.Name = "Cheese";
        }

        public override void SetCost()
        {
            topping.Cost = 0;
        }
    }
}

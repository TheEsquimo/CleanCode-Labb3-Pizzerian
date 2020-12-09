using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class TomatoSauceTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 19;
        }

        public override void SetName()
        {
            topping.Name = "Tomato Sauce";
        }

        public override void SetCost()
        {
            topping.Cost = 0;
        }
    }
}

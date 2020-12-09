using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class KebabSauceTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 12;
        }

        public override void SetName()
        {
            topping.Name = "Kebab Sauce";
        }

        public override void SetCost()
        {
            topping.Cost = 10;
        }
    }
}

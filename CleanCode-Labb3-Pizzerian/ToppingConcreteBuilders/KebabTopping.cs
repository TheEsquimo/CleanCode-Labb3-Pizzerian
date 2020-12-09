using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class KebabTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 16;
        }

        public override void SetName()
        {
            topping.Name = "Kebab";
        }

        public override void SetCost()
        {
            topping.Cost = 20;
        }
    }
}

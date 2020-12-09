using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class PineappleTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 9;
        }

        public override void SetName()
        {
            topping.Name = "Pineapple";
        }

        public override void SetCost()
        {
            topping.Cost = 10;
        }
    }
}

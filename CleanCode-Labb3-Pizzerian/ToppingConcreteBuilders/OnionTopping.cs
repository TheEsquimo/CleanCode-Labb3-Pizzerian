using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class OnionTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 11;
        }

        public override void SetName()
        {
            topping.Name = "Onions";
        }

        public override void SetCost()
        {
            topping.Cost = 10;
        }
    }
}

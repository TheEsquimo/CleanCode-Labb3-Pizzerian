using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian.Models
{
    class HamTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Cost = 8;
        }

        public override void SetName()
        {
            topping.Name = "Ham";
        }

        public override void SetCost()
        {
            topping.Cost = 10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class ArtichokeTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 15;
        }

        public override void SetName()
        {
            topping.Name = "Artichoke";
        }

        public override void SetCost()
        {
            topping.Cost = 15;
        }
    }
}

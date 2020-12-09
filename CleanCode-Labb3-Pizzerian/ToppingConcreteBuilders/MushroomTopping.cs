using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class MushroomTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 10;
        }

        public override void SetName()
        {
            topping.Name = "Mushrooms";
        }

        public override void SetCost()
        {
            topping.Cost = 10;
        }
    }
}

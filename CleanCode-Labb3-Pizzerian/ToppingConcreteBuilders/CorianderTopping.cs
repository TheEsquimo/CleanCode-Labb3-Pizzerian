using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class CorianderTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 16;
        }

        public override void SetName()
        {
            topping.Name = "Coriander";
        }

        public override void SetCost()
        {
            topping.Cost = 20;
        }
    }
}

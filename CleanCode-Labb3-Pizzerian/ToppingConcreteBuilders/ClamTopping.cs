using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class ClamTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 14;
        }

        public override void SetName()
        {
            topping.Name = "Clams";
        }

        public override void SetCost()
        {
            topping.Cost = 15;
        }
    }
}

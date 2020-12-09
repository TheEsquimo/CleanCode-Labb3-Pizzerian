using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class ShrimpTopping : ToppingBuilder
    {
        public override void SetId()
        {
            topping.Id = 13;
        }

        public override void SetName()
        {
            topping.Name = "Shrimps";
        }

        public override void SetCost()
        {
            topping.Cost = 15;
        }
    }
}

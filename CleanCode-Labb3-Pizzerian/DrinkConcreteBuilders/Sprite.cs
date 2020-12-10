using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class Sprite : DrinkBuilder
    {
        public override void SetId()
        {
            drink.Id = 7;
        }

        public override void SetName()
        {
            drink.Name = "Sprite";
        }

        public override void SetCost()
        {
            drink.Cost = 25;
        }

    }
}

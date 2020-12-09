using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian.Models
{
    public class CocaCola : DrinkBuilder
    {
        public override void SetId()
        {
            drink.Id = 5;
        }

        public override void SetName()
        {
            drink.Name = "Coca Cola";
        }

        public override void SetCost()
        {
            drink.Cost = 20;
        }

    }
}

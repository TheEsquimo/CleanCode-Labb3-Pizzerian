using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian.Models
{
    public class Fanta : DrinkBuilder
    {
        public override void SetId()
        {
            drink.Id = 6;
        }

        public override void SetName()
        {
            drink.Name = "Fanta";
        }

        public override void SetCost()
        {
            drink.Cost = 20;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian.PizzaConcreteBuilders
{
    class MargheritaBuilder : PizzaBuilder
    {
        public override void SetId()
        {
            pizza.Id = 1;
        }

        public override void SetName()
        {
            pizza.Name = "Margherita";
        }

        public override void SetCost()
        {
            pizza.Cost = 85;
        }

        public override void ApplyToppings()
        {
            throw new NotImplementedException();
        }
    }
}

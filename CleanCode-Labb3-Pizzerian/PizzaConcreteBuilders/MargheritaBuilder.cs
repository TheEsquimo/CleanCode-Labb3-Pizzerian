using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
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
            ToppingMaker toppingMaker = new ToppingMaker(new TomatoSauceTopping());
            toppingMaker.BuildTopping();
            var tomatoSauce = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new CheeseTopping());
            toppingMaker.BuildTopping();
            var cheese = toppingMaker.GetTopping();
            List<Topping> toppings = new List<Topping>()
            {
                tomatoSauce,
                cheese
            };

            pizza.Toppings = toppings;
        }
    }
}

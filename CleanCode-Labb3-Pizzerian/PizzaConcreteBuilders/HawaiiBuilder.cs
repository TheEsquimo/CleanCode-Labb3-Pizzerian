using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    class HawaiiBuilder : PizzaBuilder
    {
        public override void SetId()
        {
            pizza.Id = 2;
        }

        public override void SetName()
        {
            pizza.Name = "Hawaii";
        }

        public override void SetCost()
        {
            pizza.Cost = 95;
        }

        public override void ApplyToppings()
        {
            ToppingMaker toppingMaker = new ToppingMaker(new TomatoSauceTopping());
            toppingMaker.BuildTopping();
            var tomatoSauce = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new CheeseTopping());
            toppingMaker.BuildTopping();
            var cheese = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new HamTopping());
            toppingMaker.BuildTopping();
            var ham = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new PineappleTopping());
            toppingMaker.BuildTopping();
            var pineapple = toppingMaker.GetTopping();

            List<Topping> toppings = new List<Topping>()
            {
                tomatoSauce,
                cheese,
                ham,
                pineapple
            };

            pizza.Toppings = toppings;
        }
    }
}

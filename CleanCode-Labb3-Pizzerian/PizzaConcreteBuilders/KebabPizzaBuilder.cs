using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    class KebabPizzaBuilder : PizzaBuilder
    {
        public override void SetId()
        {
            pizza.Id = 3;
        }

        public override void SetName()
        {
            pizza.Name = "Kebab Pizza";
        }

        public override void SetCost()
        {
            pizza.Cost = 105;
        }

        public override void ApplyToppings()
        {
            ToppingMaker toppingMaker = new ToppingMaker(new TomatoSauceTopping());
            toppingMaker.BuildTopping();
            var tomatoSauce = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new CheeseTopping());
            toppingMaker.BuildTopping();
            var cheese = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new KebabTopping());
            toppingMaker.BuildTopping();
            var kebab = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new MushroomTopping());
            toppingMaker.BuildTopping();
            var mushrooms = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new OnionTopping());
            toppingMaker.BuildTopping();
            var onions = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new KebabSauceTopping());
            toppingMaker.BuildTopping();
            var kebabSauce = toppingMaker.GetTopping();
            Topping feferoni = new Topping();
            feferoni.Name = "Feferoni";
            Topping icebergLettuce = new Topping();
            icebergLettuce.Name = "Iceberg Lettuce";
            List<Topping> toppings = new List<Topping>()
            {
                tomatoSauce,
                cheese,
                kebab,
                mushrooms,
                onions,
                feferoni,
                icebergLettuce,
                kebabSauce
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    class QuatroStagioniBuilder : PizzaBuilder
    {
        public override void SetId()
        {
            pizza.Id = 4;
        }

        public override void SetName()
        {
            pizza.Name = "Quatro Stagioni";
        }

        public override void SetCost()
        {
            pizza.Cost = 115;
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
            toppingMaker = new ToppingMaker(new ShrimpTopping());
            toppingMaker.BuildTopping();
            var shrimp = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new ClamTopping());
            toppingMaker.BuildTopping();
            var clams = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new MushroomTopping());
            toppingMaker.BuildTopping();
            var mushrooms = toppingMaker.GetTopping();
            toppingMaker = new ToppingMaker(new ArtichokeTopping());
            toppingMaker.BuildTopping();
            var artichoke = toppingMaker.GetTopping();
            List<Topping> toppings = new List<Topping>()
            {
                cheese,
                tomatoSauce,
                ham,
                shrimp,
                clams,
                mushrooms,
                artichoke
            };

            pizza.Toppings = toppings;
        }
    }
}

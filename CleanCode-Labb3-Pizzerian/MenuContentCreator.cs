﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public sealed class MenuContentCreator
    {
        public static MenuContentCreator MenuContentInstance { get { return menuContentInstance; } }
        private static readonly MenuContentCreator menuContentInstance = new MenuContentCreator();
        
        static MenuContentCreator() { }
        private MenuContentCreator() { }

        public List<IOrdable> GetStandardMenu()
        {
            List<IOrdable> standardMenu = new List<IOrdable>();

            List<PizzaBuilder> pizzaBuilders = new List<PizzaBuilder>()
            {
                new HawaiiBuilder(),
                new KebabPizzaBuilder(),
                new MargheritaBuilder(),
                new QuatroStagioniBuilder()
            };
            foreach (PizzaBuilder pizzaBuilder in pizzaBuilders)
            {
                PizzaMaker pizzaMaker = new PizzaMaker(pizzaBuilder);
                pizzaMaker.BuildPizza();
                standardMenu.Add(pizzaMaker.GetPizza());
            }

            List<DrinkBuilder> drinkBuilders = new List<DrinkBuilder>()
            {
                new CocaCola(),
                new Fanta(),
                new Sprite()
            };
            foreach (DrinkBuilder drinkBuilder in drinkBuilders)
            {
                DrinkMaker drinkMaker = new DrinkMaker(drinkBuilder);
                drinkMaker.BuildDrink();
                standardMenu.Add(drinkMaker.GetDrink());
            }

            List<ToppingBuilder> toppingBuilders = new List<ToppingBuilder>()
            {
                new ArtichokeTopping(),
                new ClamTopping(),
                new CorianderTopping(),
                new HamTopping(),
                new KebabSauceTopping(),
                new MushroomTopping(),
                new OnionTopping(),
                new PineappleTopping(),
                new ShrimpTopping(),
            };
            foreach (ToppingBuilder toppingBuilder in toppingBuilders)
            {
                ToppingMaker toppingMaker = new ToppingMaker(toppingBuilder);
                toppingMaker.BuildTopping();
                standardMenu.Add(toppingMaker.GetTopping());
            }

            return standardMenu;
        }
    }
}

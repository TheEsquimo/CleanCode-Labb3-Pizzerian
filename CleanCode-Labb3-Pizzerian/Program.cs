using System;
using System.Collections.Generic;

namespace CleanCode_Labb3_Pizzerian
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            PizzaMaker pizzaMaker = new PizzaMaker(new MargheritaBuilder());
            pizzaMaker.BuildPizza();
            Pizza margherita = pizzaMaker.GetPizza();
            menu.AddOrdable(margherita);

            pizzaMaker = new PizzaMaker(new HawaiiBuilder());
            pizzaMaker.BuildPizza();
            Pizza hawaii = pizzaMaker.GetPizza();
            menu.AddOrdable(hawaii);

            pizzaMaker = new PizzaMaker(new KebabPizzaBuilder());
            pizzaMaker.BuildPizza();
            Pizza kebabPizza = pizzaMaker.GetPizza();
            menu.AddOrdable(kebabPizza);

            pizzaMaker = new PizzaMaker(new QuatroStagioniBuilder());
            pizzaMaker.BuildPizza();
            Pizza quatroStagioni = pizzaMaker.GetPizza();
            menu.AddOrdable(quatroStagioni);

            Console.WriteLine("=====MENU=====");
            foreach(Pizza pizza in menu.GetPizzas())
            {
                Console.Write(pizza.Name + ":");
                foreach(Topping topping in pizza.Toppings)
                {
                    Console.Write(" " + topping.Name + ",");
                }
                Console.Write(" - " + pizza.Cost + "kr\n");
            }
        }
    }
}

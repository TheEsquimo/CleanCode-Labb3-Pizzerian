using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public static class OrdablesToString
    {
        public static string OrdableToString(IOrdable ordable)
        {
            string ordableToString = "";
            if (ordable is Pizza)
                ordableToString = PizzaToString(ordable as Pizza);
            else if (ordable is Drink)
                ordableToString = DrinkToString(ordable as Drink);
            else
                ordableToString = ToppingToString(ordable as Topping);
            return ordableToString;
        }

        private static string ToppingToString(Topping topping)
        {
            string toppingString = "";
            toppingString += $"ID: {topping.Id}, {topping.Name}: {topping.Cost}kr\n";
            return toppingString;
        }

        private static string DrinkToString(Drink drink)
        {
            string drinkString = "";
            drinkString += $"ID: {drink.Id}, {drink.Name}: {drink.Cost}kr\n";
            return drinkString;
        }

        private static string PizzaToString(Pizza pizza)
        {
            string pizzaString = "";
            pizzaString += $"ID: {pizza.Id}, {pizza.Name}: ";
            foreach (Topping topping in pizza.Toppings)
            {
                pizzaString += (" " + topping.Name + ",");
            }
            pizzaString += (" - " + pizza.Cost + "kr\n");
            return pizzaString;
        }
    }
}

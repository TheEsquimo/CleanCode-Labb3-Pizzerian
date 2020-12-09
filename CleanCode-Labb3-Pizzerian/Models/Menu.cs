using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class Menu
    {
        public List<IOrdable> Ordables { get { return ordables; } }
        List<IOrdable> ordables;
        
        public Menu()
        {
            ordables = new List<IOrdable>();
        }

        public void AddOrdable(IOrdable ordable)
        {
            ordables.Add(ordable);
        }

        public void AddOrdables(IOrdable[] ordables)
        {
            foreach (var ordable in ordables)
            {
                this.ordables.Add(ordable);
            }
        }

        public void RemoveOrdable(IOrdable ordable)
        {
            ordables.Remove(ordable);
        }

        public List<IOrdable> GetPizzas()
        {
            var pizzas = Ordables.Where(ordable => ordable is Pizza).ToList();
            return pizzas;
        }

        public List<IOrdable> GetDrinks()
        {
            var drinks = Ordables.Where(ordable => ordable is Drink).ToList();
            return drinks;
        }

        public List<IOrdable> GetToppings()
        {
            var toppings = Ordables.Where(ordable => ordable is Topping).ToList();
            return toppings;
        }
    }
}

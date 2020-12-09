using NUnit.Framework;
using CleanCode_Labb3_Pizzerian;
using System.Collections.Generic;

namespace CleanCode_Labb3_PizzerianTestsNUnit
{
    [TestFixture]
    class MenuTests
    {
        Menu menu;

        [SetUp]
        public void SetUp()
        {
            menu = new Menu();
        }

        [Test]
        public void TestGetPizzas()
        {
            List<IOrdable> ordables = new List<IOrdable>();
            menu.AddOrdable(new Pizza());
            menu.AddOrdable(new Drink());
            menu.AddOrdable(new Topping());
            menu.AddOrdable(new Pizza());
            var pizzas = menu.GetPizzas();
            Assert.AreEqual(2, pizzas.Count);
            Assert.AreEqual(typeof(Pizza), pizzas[0].GetType());
        }

        [Test]
        public void TestGetDrinks()
        {
            List<IOrdable> ordables = new List<IOrdable>();
            menu.AddOrdable(new Drink());
            menu.AddOrdable(new Pizza());
            menu.AddOrdable(new Topping());
            menu.AddOrdable(new Drink());
            var drinks = menu.GetDrinks();
            Assert.AreEqual(2, drinks.Count);
            Assert.AreEqual(typeof(Drink), drinks[0].GetType());
        }

        [Test]
        public void TestGetToppings()
        {
            List<IOrdable> ordables = new List<IOrdable>();
            menu.AddOrdable(new Topping());
            menu.AddOrdable(new Pizza());
            menu.AddOrdable(new Drink());
            menu.AddOrdable(new Topping());
            var toppings = menu.GetToppings();
            Assert.AreEqual(2, toppings.Count);
            Assert.AreEqual(typeof(Topping), toppings[0].GetType());
        }
    }
}

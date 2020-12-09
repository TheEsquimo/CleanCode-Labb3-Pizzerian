using CleanCode_Labb3_Pizzerian;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode_Labb3_PizzerianTestsNUnit
{
    [TestFixture]
    public class PizzaMakerTests
    {
        [Test]
        public void TestBuildingPizza()
        {
            MockPizzaBuilder testBuilder = new MockPizzaBuilder();
            PizzaMaker pizzaMaker = new PizzaMaker(testBuilder);
            pizzaMaker.BuildPizza();
            Pizza pizza = pizzaMaker.GetPizza();
            Assert.AreEqual(1, pizza.Id);
            Assert.AreEqual("Test Pizza", pizza.Name);
            Assert.AreEqual(100, pizza.Cost);
            Assert.AreEqual(typeof(Topping), pizza.Toppings.First().GetType());
            Assert.AreEqual(2, pizza.Toppings.Count);
        }
    }

    class MockPizzaBuilder : PizzaBuilder
    {
        public override void ApplyToppings()
        {
            List<Topping> toppings = new List<Topping>()
            {
                new Topping(),
                new Topping()
            };
            pizza.Toppings = toppings;
        }

        public override void SetCost()
        {
            pizza.Cost = 100;
        }

        public override void SetId()
        {
            pizza.Id = 1;
        }

        public override void SetName()
        {
            pizza.Name = "Test Pizza";
        }
    }
}
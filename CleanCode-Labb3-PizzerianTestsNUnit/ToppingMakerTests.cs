using CleanCode_Labb3_Pizzerian;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode_Labb3_PizzerianTestsNUnit
{
    [TestFixture]
    public class ToppingMakerTests
    {
        [Test]
        public void TestBuildingTopping()
        {
            MockToppingBuilder testBuilder = new MockToppingBuilder();
            ToppingMaker toppingMaker = new ToppingMaker(testBuilder);
            toppingMaker.BuildTopping();
            Topping topping = toppingMaker.GetTopping();
            Assert.AreEqual(1, topping.Id);
            Assert.AreEqual("Test Topping", topping.Name);
            Assert.AreEqual(100, topping.Cost);
        }
    }

    class MockToppingBuilder : ToppingBuilder
    {
        public override void SetCost()
        {
            topping.Cost = 100;
        }

        public override void SetId()
        {
            topping.Id = 1;
        }

        public override void SetName()
        {
            topping.Name = "Test Topping";
        }
    }
}
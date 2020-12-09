using CleanCode_Labb3_Pizzerian;
using NUnit.Framework;

namespace CleanCode_Labb3_PizzerianTestsNUnit
{
    [TestFixture]
    public class DrinkMakerTests
    {
        [Test]
        public void TestBuildingDrink()
        {
            MockDrinkBuilder testBuilder = new MockDrinkBuilder();
            DrinkMaker drinkMaker = new DrinkMaker(testBuilder);
            drinkMaker.BuildDrink();
            Drink drink = drinkMaker.GetDrink();
            Assert.AreEqual(1, drink.Id);
            Assert.AreEqual("Test Drink", drink.Name);
            Assert.AreEqual(100, drink.Cost);
        }
    }

    class MockDrinkBuilder : DrinkBuilder
    {
        public override void SetCost()
        {
            drink.Cost = 100;
        }

        public override void SetId()
        {
            drink.Id = 1;
        }

        public override void SetName()
        {
            drink.Name = "Test Drink";
        }
    }
}

using CleanCode_Labb3_Pizzerian;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode_Labb3_PizzerianTestsNUnit
{
    [TestFixture]
    class OrderManagerTests
    {
        OrderManager orderManager;

        [SetUp]
        public void SetUp()
        {
            orderManager = OrderManager.OrderManagerInstance;
        }

        [Test]
        public void TestCalculateTotalCost()
        {
            IOrdable[] orderContent = new IOrdable[]
            {
                new Pizza()
                {
                    Cost = 50
                },
                new Pizza()
                {
                    Cost = 80
                },
                new Drink()
                {
                    Cost = 15
                },
                new Topping()
                {
                    Cost = 10
                }
            };

            Order order = new Order()
            {
                Content = orderContent.ToList()
            };

            double costResult = orderManager.CalculateOrderTotalCost(order);
            Assert.AreEqual(155, costResult);
        }

        [Test]
        public void TestAddAndRemoveItemFromOrder()
        {
            Pizza pizza = new Pizza() { Cost = 50 };
            Pizza pizzaTwo = new Pizza() { Cost = 100 };
            orderManager.AddItemToOrder(pizza);
            orderManager.AddItemToOrder(pizzaTwo);
            Assert.AreEqual(true, orderManager.CurrentOrder.Content.Contains(pizza));
            orderManager.RemoveItemFromOrder(pizza);
            Assert.AreEqual(true, !orderManager.CurrentOrder.Content.Contains(pizza));
            Assert.AreEqual(true, orderManager.CurrentOrder.Content.Contains(pizzaTwo));
        }
    }
}

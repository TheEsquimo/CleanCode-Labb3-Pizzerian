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

        [TearDown]
        public void TearDown()
        {
            orderManager.ClearOrder();
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
            Assert.Contains(pizza, orderManager.CurrentOrder.Content);
            orderManager.RemoveItemFromOrder(pizza);
            CollectionAssert.DoesNotContain(orderManager.CurrentOrder.Content, pizza);
            Assert.Contains(pizzaTwo, orderManager.CurrentOrder.Content);
        }

        [Test]
        public void TestCantAddToppingWithoutPizza()
        {
            Topping topping = new Topping();
            orderManager.AddItemToOrder(topping);
            CollectionAssert.DoesNotContain(orderManager.CurrentOrder.Content, topping);
        }

        [Test]
        public void TestCanAddToppingWithPizza()
        {
            orderManager.AddItemToOrder(new Pizza());
            Topping topping = new Topping();
            orderManager.AddItemToOrder(topping);
            Assert.Contains(topping, orderManager.CurrentOrder.Content);
        }

        [Test]
        public void TestCantPlaceOrderWithToppingWithoutPizza()
        {
            Pizza pizza = new Pizza();
            orderManager.AddItemToOrder(pizza);
            orderManager.AddItemToOrder(new Topping());
            orderManager.RemoveItemFromOrder(pizza);
            Order placedOrder = orderManager.PlaceOrder();
            Assert.AreEqual(null, placedOrder);
        }

        [Test]
        public void CanPlaceOrderWithDrinkOnly()
        {
            Drink drink = new Drink();
            orderManager.AddItemToOrder(drink);
            Order placedOrder = orderManager.PlaceOrder();
            Assert.Contains(drink, placedOrder.Content);
        }

        [Test]
        public void SetOrderStatusToCompleted()
        {
            Order order = new Order();
            orderManager.SetOrderStatus(order, Order.OrderStatus.Completed);
            Assert.AreEqual(Order.OrderStatus.Completed, order.Status);
        }

        [Test]
        public void SetOrderStatusToCanceled()
        {
            Order order = new Order();
            orderManager.SetOrderStatus(order, Order.OrderStatus.Canceled);
            Assert.AreEqual(Order.OrderStatus.Canceled, order.Status);
        }
    }
}

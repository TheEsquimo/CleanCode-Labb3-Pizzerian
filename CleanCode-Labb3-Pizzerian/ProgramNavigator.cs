using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public sealed class ProgramNavigator
    {
        public static ProgramNavigator ProgramNavigatorInstance { get { return programNavigatorInstance; } }
        public string UserInput { get { return userInput; } }
        public Menu Menu { get { return menu; } }

        private static readonly ProgramNavigator programNavigatorInstance = new ProgramNavigator();
        private string userInput;
        private OrderManager orderManager = OrderManager.OrderManagerInstance;
        private Menu menu;

        static ProgramNavigator() { }
        private ProgramNavigator() { }

        public void StartProgram(Menu menu)
        {
            this.menu = menu;
            while (true)
            {
                MainMenu();
            }
        }

        string GetUserInput(params string[] validInput)
        {
            string userInput = "";
            while (!validInput.Contains(userInput) || validInput.Length == 0)
            {
                try
                {
                    userInput = Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return userInput;
        }

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1: Make Order");
            Console.WriteLine("2: Display Active Orders");
            Console.WriteLine("3: Set Order Status");
            userInput = GetUserInput("1", "2", "3");
            switch (UserInput)
            {
                case "1":
                    Console.Clear();
                    OrderMenu();
                    break;

                case "2":
                    Console.Clear();
                    ActiveOrdersDisplay();
                    break;

                case "3":
                    Console.Clear();
                    SetOrderStatusMenu();
                    break;
            }
        }

        private void OrderMenu()
        {
            Console.WriteLine("=====ORDER MENU=====");
            Console.ReadKey();
        }

        private void ActiveOrdersDisplay()
        {
            Console.WriteLine("=====ORDERS=====");
            Console.WriteLine(orderManager.GetActiveOrders());
            Console.ReadKey();
        }

        private void SetOrderStatusMenu()
        {
            Console.WriteLine("=====SET ORDER STATUS=====");
            Console.ReadKey();
        }
    }
}

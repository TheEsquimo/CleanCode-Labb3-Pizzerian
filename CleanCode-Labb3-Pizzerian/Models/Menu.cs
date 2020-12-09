using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public sealed class Menu
    {
        private static readonly Menu menuInstance = new Menu();
        public static Menu MenuInstance { get { return menuInstance; } }

        static Menu() { }
        private Menu() { }
    }
}

﻿using System;
using System.Collections.Generic;

namespace CleanCode_Labb3_Pizzerian
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            IOrdable[] standardMenuContent = MenuContentCreator.MenuContentInstance.GetStandardMenu().ToArray();
            menu.AddOrdables(standardMenuContent);
            ProgramNavigator.ProgramNavigatorInstance.StartProgram(menu);
        }
    }
}

using System;
using System.Collections.Generic;
using WhatShouldITest.Interfaces;
using WhatShouldITest.Utilities;

namespace WhatShouldITest.Entities
{
    public class Menu
    {
        private readonly IMenuItemProvider _menuItemProvider;

        public Menu(IMenuItemProvider menuItemProvider)
        {
            _menuItemProvider = menuItemProvider;
            DailySpecial = MenuUtilities.GetDailySpecial(DateTime.Now.DayOfWeek);
        }

        IEnumerable<MenuItem> Items { get; }
        public string DailySpecial { get; }
    }
}

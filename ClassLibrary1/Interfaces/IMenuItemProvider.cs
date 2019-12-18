using System.Collections.Generic;
using WhatShouldITest.Entities;

namespace WhatShouldITest.Interfaces
{
    public interface IMenuItemProvider
    {
        IEnumerable<MenuItem> GetMenuItems();
    }
}
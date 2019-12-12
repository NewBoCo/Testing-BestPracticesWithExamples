using System;
using System.Collections.Generic;
using System.Text;

namespace WhatShouldITest.Entities
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public MenuCategory Category { get; set; }
    }
}

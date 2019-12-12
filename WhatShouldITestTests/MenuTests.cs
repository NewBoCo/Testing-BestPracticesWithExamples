using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WhatShouldITest.Entities;

namespace WhatShouldITestTests
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void Special_AfterConstruction_ShouldReturnValue()
        {
            var menu = new Menu(null);

            menu.DailySpecial.Should().NotBeNullOrEmpty();
        }
    }
}

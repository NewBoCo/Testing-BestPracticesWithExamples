using System;
using System.Linq;

namespace WhatShouldITest.Utilities
{
    public static class MenuUtilities
    {
        public static string GetDailySpecial(DayOfWeek dayOfWeek)
        {
            var _dailySpecials = new[]{
                new {DayOfWeek = DayOfWeek.Monday,
                    Special = "Half price tacos!" },
                new {DayOfWeek = DayOfWeek.Tuesday,
                    Special = "50 cent wings"},
                new {DayOfWeek = DayOfWeek.Wednesday,
                    Special = "2-for-1 Desserts"},
                new {DayOfWeek = DayOfWeek.Thursday,
                    Special = "5$ Burgers"},
                new {DayOfWeek = DayOfWeek.Friday,
                    Special = "All you can eat ribs" },
                new {DayOfWeek = DayOfWeek.Saturday,
                    Special = "Special Brunch" },
                new {DayOfWeek = DayOfWeek.Sunday,
                    Special = "Sunday, funday"}
            };

            return _dailySpecials.Where(s => s.DayOfWeek == dayOfWeek)
                                 .Select(s => s.Special)
                                 .First();
        }
    }
}

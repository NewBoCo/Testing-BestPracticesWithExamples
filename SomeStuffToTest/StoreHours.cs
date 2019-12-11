using System;
using System.Linq;

namespace SomeStuffToTest
{
    public static class StoreHours
    {
        public static bool IsStoreOpen(DateTime dateAndTime)
        {
            var storeHours = new[] {
                new {
                    DayOfWeek = DayOfWeek.Monday,
                    OpenTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 8, 0, 0),
                    CloseTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 22, 0, 0)
                },
                new {
                    DayOfWeek = DayOfWeek.Tuesday,
                    OpenTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 8, 0, 0),
                    CloseTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 22, 0, 0)
                },
                new {
                    DayOfWeek = DayOfWeek.Wednesday,
                    OpenTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 8, 0, 0),
                    CloseTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 22, 0, 0)
                },
                new {
                    DayOfWeek = DayOfWeek.Thursday,
                    OpenTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 8, 0, 0),
                    CloseTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 22, 0, 0)
                },
                new {
                    DayOfWeek = DayOfWeek.Friday,
                    OpenTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 8, 0, 0),
                    CloseTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 23, 0, 0)
                },
                new {
                    DayOfWeek = DayOfWeek.Saturday,
                    OpenTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 10, 0, 0),
                    CloseTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 20, 0, 0)
                },
                new {
                    DayOfWeek = DayOfWeek.Sunday,
                    OpenTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 10, 0, 0),
                    CloseTimeOnDate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day, 18, 0, 0)
                }

            };

            var dayOptions = storeHours.First(sh => sh.DayOfWeek == dateAndTime.DayOfWeek);

            return dayOptions.OpenTimeOnDate <= dateAndTime && dayOptions.CloseTimeOnDate > dateAndTime;
        }
    }
}

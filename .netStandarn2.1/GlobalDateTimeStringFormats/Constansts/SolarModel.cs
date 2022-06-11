using System.Collections.Generic;

namespace GlobalDateTimeStringFormats.Constansts
{
    public static class SolarModel
    {
        public readonly static Dictionary<int, string> WeekDaysSolar = new Dictionary<int, string>()
        {
            [0] = "یکشنبه",
            [1] = "دوشنبه",
            [2] = "سه شنبه",
            [3] = "چهارشنبه",
            [4] = "پنج شنبه",
            [5] = "جمعه",
            [6] = "شنبه",
        }; // Definition of the names of the days of the week in Persian

        public readonly static Dictionary<int, string> MonthSolar = new Dictionary<int, string>()
        {
            [1] = "فروردین",
            [2] = "اردیبهشت",
            [3] = "خرداد",
            [4] = "تیر",
            [5] = "مرداد",
            [6] = "شهریور",
            [7] = "مهر",
            [8] = "آبان",
            [9] = "آذر",
            [10] = "دی",
            [11] = "بهمن",
            [12] = "اسفند",
        }; // Define the names of the months of the year in the Persian calendar       
    }
}

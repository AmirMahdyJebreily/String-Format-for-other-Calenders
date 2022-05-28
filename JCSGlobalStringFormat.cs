﻿using System.Globalization;

/*
 █████╗ ███╗   ███╗██╗██████╗          ██╗ ██████╗███████╗
██╔══██╗████╗ ████║██║██╔══██╗         ██║██╔════╝██╔════╝
███████║██╔████╔██║██║██████╔╝         ██║██║     ███████╗
██╔══██║██║╚██╔╝██║██║██╔══██╗    ██   ██║██║     ╚════██║
██║  ██║██║ ╚═╝ ██║██║██║  ██║    ╚█████╔╝╚██████╗███████║
╚═╝  ╚═╝╚═╝     ╚═╝╚═╝╚═╝  ╚═╝     ╚════╝  ╚═════╝╚══════╝
                Developed by Amir JCS  
        https://github.com/AmirMahdyJebreily                                                       
*/

namespace JSCDateTime
{
    public static class JCSGlobalStringFormat
    {
        private static Dictionary<string,string> _weekDaysSolar = new Dictionary<string, string>()
        {
            ["Sunday"] = "یکشنبه",
            ["Monday"] = "دوشنبه",
            ["Tuesday"] = "سه شنبه",
            ["Wednesday"] = "چهارشنبه",
            ["Thursday"] = "پنج شنبه",
            ["Friday"] = "جمعه",
            ["Saturday"] = "شنبه",
        }; // Definition of the names of the days of the week in Persian
        private static Dictionary<int, string> _maunthSolar = new Dictionary<int, string>()
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

        private static Dictionary<string, string> _weekDaysLunar = new Dictionary<string, string>()
        {
            ["Sunday"] = "الأحد",
            ["Monday"] = "الأثنين",
            ["Tuesday"] = "الثلاثاء",
            ["Wednesday"] = "الأربعاء",
            ["Thursday"] = "الخميس",
            ["Friday"] = "الجمعه",
            ["Saturday"] = "السبت",
        }; // Definition of the names of the days of the week in Arabic
        private static Dictionary<int, string> _maunthLunar = new Dictionary<int, string>()
        {
            [1] = "محرم",
            [2] = "	صفر",
            [3] = "	ربیع‌الاول",
            [4] = "	ربیع‌الثانی",
            [5] = "جمادی‌الاول",
            [6] = "جمادی‌الثانی	",
            [7] = "رجب",
            [8] = "شعبان",
            [9] = "	رمضان",
            [10] = "شوال",
            [11] = "ذیقعده",
            [12] = "ذیحجه",
        }; // Define the names of the months of the year in the Hijri calendar

        // To Solar
        public static string ToLongSolarDateString(this DateTime datetime) // "Sunday, May 28, 2006" To "یکشنبه، 7 خرداد، 1385" (Just Format)
        {
            PersianCalendar pc = new PersianCalendar();
            string[] dateString = datetime.ToLongDateString().Split(", ").ToArray();

            return $"{_weekDaysSolar[dateString[0]]}، {pc.GetDayOfMonth(datetime)} {_maunthSolar[pc.GetMonth(datetime)]}، {pc.GetYear(datetime)}";
        }
        public static string ToShortSolarDateString(this DateTime datetime) // "5/28/2006" To "1385 / 03 / 07" (Just Format)
        {
            PersianCalendar pc = new PersianCalendar();
            string[] dateString = datetime.ToLongDateString().Split(", ").ToArray();

            return $"{pc.GetYear(datetime)} / {pc.GetMonth(datetime).ToString("00")} / {pc.GetDayOfMonth(datetime).ToString("00")}";
        }


        // To Lunar (Hijri)

        public static string ToLongLunarDateString(this DateTime datetime) // "Sunday, May 28, 2006" To "الأحد، 1 جمادی‌الاول، 1427" (Just Format)
        {
            HijriCalendar hc = new HijriCalendar();
            string[] dateString = datetime.ToLongDateString().Split(", ").ToArray();

            return $"{_weekDaysLunar[dateString[0]]}، {hc.GetDayOfMonth(datetime)} {_maunthLunar[hc.GetMonth(datetime)]}، {hc.GetYear(datetime)}";
        }
        public static string ToShortLunarDateString(this DateTime datetime) // "5/28/2006" To "1427 / 05 / 01" (Just Format)
        {
            HijriCalendar hc = new HijriCalendar();
            string[] dateString = datetime.ToLongDateString().Split(", ").ToArray();

            return $"{hc.GetYear(datetime)} / {hc.GetMonth(datetime).ToString("00")} / {hc.GetDayOfMonth(datetime).ToString("00")}";
        }
    }
}

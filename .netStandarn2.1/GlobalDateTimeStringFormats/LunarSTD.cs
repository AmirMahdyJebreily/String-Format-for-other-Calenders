using System;
using System.Globalization;
using GlobalDateTimeStringFormats.Constansts;

namespace GlobalDateTimeStringFormats
{
    public static class LunarSTD
    {
        private static HijriCalendar _hc = new HijriCalendar();

        public static string ToLunarFullTextFormat(this DateTime date)
        {
            string weekDayName = LunarModel.WeekDaysLunar[((int)_hc.GetDayOfWeek(date))];
            string monthName = LunarModel.MonthLunar[(_hc.GetMonth(date))];
            return $"{weekDayName}، {_hc.GetDayOfMonth(date)} {monthName} العام {_hc.GetYear(date)} ه.ق";
        }
        public static string ToLunarFullFormat(this DateTime date)
        {
            string weekDayName = LunarModel.WeekDaysLunar[((int)_hc.GetDayOfWeek(date))];
            string monthName = LunarModel.MonthLunar[(_hc.GetMonth(date))];
            return $"{weekDayName}، {_hc.GetDayOfMonth(date)} {monthName} العام {_hc.GetYear(date)}";
        }
        public static string ToLunarMinTextFormat(this DateTime date)
        {
            string weekDayName = LunarModel.WeekDaysLunar[((int)_hc.GetDayOfWeek(date))];
            string monthName = LunarModel.MonthLunar[(_hc.GetMonth(date))];
            return $"{weekDayName}، {_hc.GetDayOfMonth(date)} {monthName} {_hc.GetYear(date)}";
        }
        public static string ToLunarNoWeekFormat(this DateTime date)
        {
            string weekDayName = LunarModel.WeekDaysLunar[((int)_hc.GetDayOfWeek(date))];
            string monthName = LunarModel.MonthLunar[(_hc.GetMonth(date))];
            return $"{_hc.GetDayOfMonth(date)} {monthName} {_hc.GetYear(date)}";
        }
        public static string ToLunarShortFormat(this DateTime date)
        {
            string weekDayName = LunarModel.WeekDaysLunar[((int)_hc.GetDayOfWeek(date))];
            string monthName = LunarModel.MonthLunar[(_hc.GetMonth(date))];
            return $"{_hc.GetDayOfMonth(date)}/{monthName}/{_hc.GetYear(date)} ه.ش";
        }

    }
}

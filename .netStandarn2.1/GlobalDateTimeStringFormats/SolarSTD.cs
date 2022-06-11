using System;
using System.Globalization;
using GlobalDateTimeStringFormats.Constansts;

namespace GlobalDateTimeStringFormats
{
    public static class SolarSTD
    {
        private static PersianCalendar _pc = new PersianCalendar();

        public static string ToSolarFullTextFormat(this DateTime date)
        {
            string weekDayName = SolarModel.WeekDaysSolar[((int)_pc.GetDayOfWeek(date))];
            string monthName = SolarModel.MonthSolar[(_pc.GetMonth(date))];
            return $"{weekDayName}، {_pc.GetDayOfMonth(date)} {monthName} سال {_pc.GetYear(date)} ه.ش";
        }
        public static string ToSolarFullFormat(this DateTime date)
        {
            string weekDayName = SolarModel.WeekDaysSolar[((int)_pc.GetDayOfWeek(date))];
            string monthName = SolarModel.MonthSolar[(_pc.GetMonth(date))];
            return $"{weekDayName}، {_pc.GetDayOfMonth(date)} {monthName} سال {_pc.GetYear(date)}";
        }
        public static string ToSolarMinTextFormat(this DateTime date)
        {
            string weekDayName = SolarModel.WeekDaysSolar[((int)_pc.GetDayOfWeek(date))];
            string monthName = SolarModel.MonthSolar[(_pc.GetMonth(date))];
            return $"{weekDayName}، {_pc.GetDayOfMonth(date)} {monthName} {_pc.GetYear(date)}";
        }
        public static string ToSolarNoWeekFormat(this DateTime date)
        {
            string weekDayName = SolarModel.WeekDaysSolar[((int)_pc.GetDayOfWeek(date))];
            string monthName = SolarModel.MonthSolar[(_pc.GetMonth(date))];
            return $"{_pc.GetDayOfMonth(date)} {monthName} {_pc.GetYear(date)}";
        }
        public static string ToSolarShortFormat(this DateTime date)
        {
            string weekDayName = SolarModel.WeekDaysSolar[((int)_pc.GetDayOfWeek(date))];
            string monthName = SolarModel.MonthSolar[(_pc.GetMonth(date))];
            return $"{_pc.GetDayOfMonth(date)}/{monthName}/{_pc.GetYear(date)} ه.ش";
        }

    }
}

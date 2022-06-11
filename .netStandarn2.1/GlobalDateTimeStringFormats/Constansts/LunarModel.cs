using System.Collections.Generic;

namespace GlobalDateTimeStringFormats.Constansts
{
    public static class LunarModel
    {
        public static Dictionary<int, string> WeekDaysLunar = new Dictionary<int, string>()
        {
            [0] = "الأحد",
            [1] = "الأثنين",
            [2] = "الثلاثاء",
            [3] = "الأربعاء",
            [4] = "الخميس",
            [5] = "الجمعه",
            [6] = "السبت",
        }; // Definition of the names of the days of the week in Arabic
        public static Dictionary<int, string> MonthLunar = new Dictionary<int, string>()
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
    }
}

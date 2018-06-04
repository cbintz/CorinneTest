using System;

namespace CorinneTest
{
    public static class ExtensionMethods
    {
        public static int DaysAlive(this DateTime date)
        {
            return  Convert.ToInt32((DateTime.Now - date).TotalDays);
        }

        public static int MonthsAlive(this DateTime date)
        {
            return Math.Abs((date.Month - DateTime.Now.Month) + 12 * (date.Year - DateTime.Now.Year));
        }
    }
}

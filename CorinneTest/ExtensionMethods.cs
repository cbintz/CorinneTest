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

        public static string AgeType(this DateTime date)
        {
            string ageType;
            int years = Convert.ToInt32(((DateTime.Today - date).TotalDays) / 365.2425);
            if (years < 18 && years > 12 ) { ageType = "Teenager"; }
            else if (years < 13) { ageType = "Child"; }
            else if (years < 65 && years >= 18) { ageType = "Adult"; }
            else { ageType = "Senior"; }
            return ageType;

        }
    }
}

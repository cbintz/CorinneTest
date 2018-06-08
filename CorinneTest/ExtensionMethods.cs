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

        public static string ZodaicSign(this DateTime date)
        {
            string zodiac;
            int month = date.Month;
            int day = date.Day;
            switch (month)
            {
                case 1:
                    if (day <= 19) { zodiac = "Capricorn"; }
                    else { zodiac = "Aquarius"; }
                    break;
                case 2:
                    if (day < 19) { zodiac = "Aquarius"; }
                    else { zodiac = "Pisces"; }
                    break;
                case 3:
                    if (day < 21) { zodiac = "Pisces"; }
                    else { zodiac = "Aries"; }
                    break;
                case 4:
                    if (day < 20) { zodiac = "Aries"; }
                    else { zodiac = "Taurus"; }
                    break;
                case 5:
                    if (day < 21) { zodiac = "Taurus"; }
                    else { zodiac = "Gemini"; }
                    break;
                case 6:
                    if (day < 21) { zodiac = "Gemini"; }
                    else { zodiac = "Cancer"; }
                    break;
                case 7:
                    if (day < 23) { zodiac = "Cancer"; }
                    else { zodiac = "Leo"; }
                    break;
                case 8:
                    if (day < 23) { zodiac = "Leo"; }
                    else { zodiac = "Virgo"; }
                    break;
                case 9:
                    if (day < 23) { zodiac = "Virgo"; }
                    else { zodiac = "Libra"; }
                    break;
                case 10:
                    if (day < 23) { zodiac = "Libra"; }
                    else { zodiac = "Scorpio"; }
                    break;
                case 11:
                    if (day < 22) { zodiac = "Scorpio"; }
                    else { zodiac = "Sagittarius"; }
                    break;
                default:
                    if (day < 22) { zodiac = "Sagittarius"; }
                    else { zodiac = "Capricorn"; }
                    break;


            }
            return zodiac;

        }

        public static string PrintPretty(this DateTime date)
        {
            int month = date.Month;
            string monthPretty;
            switch (month)
            {
                case 1:
                    monthPretty = "January";
                    break;
                case 2:
                    monthPretty = "February";
                    break;
                case 3:
                    monthPretty = "March";
                    break;
                case 4:
                    monthPretty = "April";
                    break;
                case 5:
                    monthPretty = "May";
                    break;
                case 6:
                    monthPretty = "June";
                    break;
                case 7:
                    monthPretty = "July";
                    break;
                case 8:
                    monthPretty = "August";
                    break;
                case 9:
                    monthPretty = "September";
                    break;
                case 10:
                    monthPretty = "October";
                    break;
                case 11:
                    monthPretty = "November";
                    break;
                default:
                    monthPretty = "December";
                    break;
            }

            string day = date.Day.ToString();
            string year = date.Year.ToString();
            return monthPretty + " " + day + "th, " + year;
        }

        public static string PrintStandardUS(this DateTime date)
        {
            string month = date.Month.ToString();
            string day = date.Day.ToString();
            string year = date.Year.ToString();

            return month + "/" + day + "/" + year; 
        }

        public static string PrintStandardNotUS(this DateTime date)
        {
            string month = date.Month.ToString();
            string day = date.Day.ToString();
            string year = date.Year.ToString();

            return day + "/" + month + "/" + year;
        }

    }
}

using System;

namespace CorinneTest
{
    public static class ExtensionMethods
    {
        public static int DaysAlive(this DateTime date)
        {
            return  Convert.ToInt32((DateTime.Now - date).TotalDays);
        }
    }
}

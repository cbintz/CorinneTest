using System;
using System.Collections.Generic;

namespace CorinneTest
{
    class Factory : IPersonFactory
    {
       
        static Random rnd = new Random();


        public static List<Person> CreateInRange(int lowAge,
                                                 int highAge,
                                                 int numOfPeople)
        {
            var list = new List<Person>();

            return list;
        }

        public static DateTime? GenRanAdultBirthDate(int lowAge, int highAge)
        {
            if (highAge < 18)
                return null;
            DateTime start = new DateTime((2018 - highAge), 5, 29);
            DateTime minDate = new DateTime((2018 - lowAge), 5, 29);
            int range = (minDate - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static DateTime? GenRanChildBirthDate(int lowAge, int highAge)
        {
            if (lowAge >= 18) { return null; }
            if (highAge < 18) { DateTime maxDate = new DateTime((2018 - highAge), 5, 29); }
            else { DateTime maxDate = new DateTime(2000, 5, 29); }
            int range = (DateTime.Today-maxDate).Days;
            return DateTime.Today.AddDays(rnd.Next(range));
        }

        public static DateTime? GenRanSeniorBirthDate(int lowAge, int highAge)
        {
            if (highAge < 6) { return null; }
            if (lowAge > 65) { DateTime minDate = new DateTime((2018 - lowAge), 5, 29);}
            else { DateTime minDate = new DateTime(1953, 5, 29); }
            DateTime start = new DateTime((2018-highAge), 5, 29);
            int range = (minDate - start).Days;
            return start.AddDays(rnd.Next(range));
        }


        public static DateTime GenRanBirthDate(int lowAge, int highAge)
        {
            DateTime start = new DateTime((2018-highAge), 5, 29);
            DateTime minDate = new DateTime((2018 - lowAge), 5, 29);
            int range = (minDate - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static int? GenAdultAge(int highAge)
        {
            if (highAge < 28)
                return null;
            int age = rnd.Next(18, highAge);
            return age;
        }

        public static int? GenChildAge(int lowAge)
        {
            if (lowAge >= 18)
                return null;
            int age = rnd.Next(lowAge, 18);
            return age;
        }

        public static int? GenSeniorAge(int highAge)
        {
            if (highAge < 65)
                return null;
            int age = rnd.Next(65, highAge);
            return age;
        }

        public static int GenAge(int lowAge, int highAge)
        {
            int age = rnd.Next(lowAge, highAge);
            return age;
        }


        // maybe make a random list of names to choose from
        public static Person MakeWoman(int lowAge, int highAge) {
            return new Person("Michelle", GenAdultAge(highAge), Gender.Woman, GenRanAdultBirthDate(lowAge, highAge));
        }
        
        public static Person MakeSomeone(int lowAge, int highAge) {
            return new Person("Bard", GenAge(lowAge, highAge), Gender.GenderNonBinary, GenRanBirthDate(lowAge, highAge));
            
        }

        public static Person MakeMan(int lowAge, int highAge) {
            return new Person("Barack", GenAdultAge(highAge), Gender.Man, GenRanAdultBirthDate(lowAge, highAge));
            
        }


        public static Person MakeGirl(int lowAge, int highAge) {
            return new Person("Micah", GenChildAge(lowAge), Gender.Woman, GenRanChildBirthDate(lowAge, highAge));
        }

        public static Person MakeSeniorWoman(int lowAge, int highAge) {
            return new Person("Pat", GenSeniorAge(highAge), Gender.Woman, GenRanSeniorBirthDate(lowAge, highAge));
            
        }

        public static Person MakeSeniorMan(int lowAge, int highAge)
        {
            return new Person("Allen", GenSeniorAge(highAge), Gender.Man, GenRanSeniorBirthDate(lowAge, highAge));

        }

        public static Person MakeSeniorPerson(int lowAge, int highAge)
        {
            return new Person("Mason", GenSeniorAge(highAge), Gender.GenderNonBinary, GenRanSeniorBirthDate(lowAge, highAge));

        }



    }
}
        



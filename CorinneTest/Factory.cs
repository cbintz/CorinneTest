using System;
using System.Collections.Generic;

namespace CorinneTest
{
    class Factory : IPersonFactory
    {
        static int lowAge = 18;
        static int highAge = 80;
        static Random rnd = new Random();


        public static List<Person> CreateInRange(int lowAge,
                                                 int highAge,
                                                 int numOfPeople)
        {
            var list = new List<Person>();

            return list;
        }

        public static DateTime GenRanAdultBirthDate()
        {
            DateTime start = new DateTime(1918, 5, 29);
            DateTime minDate = new DateTime(2000, 5, 29);
            int range = (minDate - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static DateTime GenRanChildBirthDate()
        {
            DateTime maxDate = new DateTime(2000, 5, 29);
            int range = (DateTime.Today-maxDate).Days;
            return DateTime.Today.AddDays(rnd.Next(range));
        }

        public static DateTime GenRanSeniorBirthDate()
        {
            DateTime start = new DateTime(1918, 5, 29);
            DateTime minDate = new DateTime(1953, 5, 29);
            int range = (minDate - start).Days;
            return start.AddDays(rnd.Next(range));
        }


        public static DateTime GenRanBirthDate()
        {
            DateTime start = new DateTime(1918, 5, 29);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static int GenAdultAge()
        {
            int age = rnd.Next(18, highAge);
            return age;
        }

        public static int GenChildAge()
        {
            int age = rnd.Next(lowAge, 18);
            return age;
        }

        public static int GenSeniorAge()
        {
            int age = rnd.Next(65, highAge);
            return age;
        }

        public static int GenAge()
        {
            int age = rnd.Next(lowAge, highAge);
            return age;
        }


        // maybe make a random list of names to choose from
        public static Person MakeWoman() {
            return new Person("Michelle", GenAdultAge(), Gender.Woman, GenRanAdultBirthDate());
        }
        
        public static Person MakeSomeone() {
            return new Person("Bard", GenAge(), Gender.GenderNonBinary, GenRanBirthDate());
            
        }

        public static Person MakeMan() {
            return new Person("Barack", GenAdultAge(), Gender.Man, GenRanAdultBirthDate());
            
        }


        public static Person MakeGirl() {
            return new Person("Micah", GenChildAge(), Gender.Woman, GenRanChildBirthDate());
        }

        public static Person MakeSeniorWoman() {
            return new Person("Pat", GenSeniorAge(), Gender.Woman, GenRanSeniorBirthDate());
            
        }

        public static Person MakeSeniorMan()
        {
            return new Person("Allen", GenSeniorAge(), Gender.Man, GenRanSeniorBirthDate());

        }

        public static Person MakeSeniorPerson()
        {
            return new Person("Mason", GenSeniorAge(), Gender.GenderNonBinary, GenRanSeniorBirthDate());

        }



    }
}
        



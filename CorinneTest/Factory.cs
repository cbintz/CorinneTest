using System;
using System.Collections.Generic;

namespace CorinneTest
{


    public class Factory 

    {

        static Random rnd = new Random();


        public static List<Person> CreateInRange(int lowAge,
                                                 int highAge,
                                                 int? numOfPeople)
        {
            var list = new List<Person>();
            int i = 0;
            while (i < numOfPeople)
            {
                Person newPerson = null;
                switch (rnd.Next(1, 9))
                {
                    case 1:
                        newPerson = MakeWoman(lowAge, highAge);
                        break;
                    case 2:
                        newPerson = MakeMan(lowAge, highAge);
                        break;
                    case 3:
                        newPerson = MakeSomeone(lowAge, highAge);
                        break;
                    case 4:
                        newPerson = MakeGirl(lowAge, highAge);
                        break;
                    case 5:
                        newPerson = MakeBoy(lowAge, highAge);
                        break;
                    case 6:
                        newPerson = MakeChild(lowAge, highAge);
                        break;
                    case 7:
                        newPerson = MakeSeniorWoman(lowAge, highAge);
                        break;
                    case 8:
                        newPerson = MakeSeniorMan(lowAge, highAge);
                        break;
                    default:
                        newPerson = MakeSeniorPerson(lowAge, highAge);
                        break;


                }
                list.Add(newPerson);
                i++;

            }
            return list;
        }
        #region various genBirthDates
        public static DateTime? GenRanAdultBirthDate(int lowAge, int highAge)
        {
            if (highAge < 18)
                return null;
            var start = new DateTime((2018 - highAge), 5, 29);
            var minDate = new DateTime((2018 - lowAge), 5, 29);
            int range = (minDate - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static DateTime? GenRanChildBirthDate(int lowAge, int highAge)
        {
            DateTime maxDate;
            if (lowAge >= 18) { return null; }
            if (highAge < 18) { maxDate = new DateTime((2018 - highAge), 5, 29); }
            else { maxDate = new DateTime(2000, 5, 29); }
            int range = (DateTime.Today - maxDate).Days;
            return DateTime.Today.AddDays(rnd.Next(range));
        }

        public static DateTime? GenRanSeniorBirthDate(int lowAge, int highAge)
        {
            DateTime minDate;
            if (highAge < 65) { return null; }
            if (lowAge > 65) { minDate = new DateTime((2018 - lowAge), 5, 29); }
            else { minDate = new DateTime(1953, 5, 29); }
            var start = new DateTime((2018 - highAge), 5, 29);
            int range = (minDate - start).Days;
            return start.AddDays(rnd.Next(range));
        }


        public static DateTime GenRanBirthDate(int lowAge, int highAge)
        {
            var start = new DateTime((2018 - highAge), 5, 29);
            var minDate = new DateTime((2018 - lowAge), 5, 29);
            int range = (minDate - start).Days;
            return start.AddDays(rnd.Next(range));
        }
        #endregion

        #region various genAges
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

        #endregion

        #region makePerson
        public static Person MakeWoman(int lowAge, int highAge)
        {
            return new Person("Michelle", GenAdultAge(highAge), Gender.Woman, GenRanAdultBirthDate(lowAge, highAge));
        }

        public static Person MakeSomeone(int lowAge, int highAge)
        {
            return new Person("Bard", GenAge(lowAge, highAge), Gender.GenderNonBinary, GenRanBirthDate(lowAge, highAge));

        }

        public static Person MakeMan(int lowAge, int highAge)
        {
            return new Person("Barack", GenAdultAge(highAge), Gender.Man, GenRanAdultBirthDate(lowAge, highAge));

        }


        public static Person MakeGirl(int lowAge, int highAge)
        {
            return new Person("Micah", GenChildAge(lowAge), Gender.Woman, GenRanChildBirthDate(lowAge, highAge));
        }

        public static Person MakeBoy(int lowAge, int highAge)
        {
            return new Person("Thomas", GenChildAge(lowAge), Gender.Man, GenRanChildBirthDate(lowAge, highAge));
        }

        public static Person MakeChild(int lowAge, int highAge)
        {
            return new Person("Charlie", GenChildAge(lowAge), Gender.GenderNonBinary, GenRanChildBirthDate(lowAge, highAge));
        }

        public static Person MakeSeniorWoman(int lowAge, int highAge)
        {
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

#endregion

    }
}




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
                        if (highAge >= 18) {newPerson = MakeWoman(lowAge, highAge); }
                        else {newPerson = MakeGirl(lowAge, highAge);}
                        break;
                    case 2:
                        if (highAge >= 18) { newPerson = MakeMan(lowAge, highAge); }
                        else { newPerson = MakeBoy(lowAge, highAge); }
                        break;
                    case 3:
                        if (highAge >= 18) { newPerson = MakeSomeone(lowAge, highAge); }
                        else { newPerson = MakeChild(lowAge, highAge); }
                        break;
                    case 4:
                        if (lowAge < 18) { newPerson = MakeGirl(lowAge, highAge); }
                        else { newPerson = MakeWoman(lowAge, highAge); }
                        break;
                    case 5:
                        if (lowAge < 18) { newPerson = MakeBoy(lowAge, highAge); }
                        else { newPerson = MakeMan(lowAge, highAge); }
                        break;
                    case 6:
                        if (lowAge < 18) { newPerson = MakeChild(lowAge, highAge); }
                        else { newPerson = MakeSomeone(lowAge, highAge); }
                        break;
                    case 7:
                        if (highAge < 65)
                        {
                            if (highAge > 18) { newPerson = MakeWoman(lowAge, highAge); }
                            else { newPerson = MakeGirl(lowAge, highAge); }
                        }
                        else { newPerson = MakeSeniorWoman(lowAge, highAge); }
                        break;
                    case 8:
                        if (highAge < 65)
                        {
                            if (highAge > 18) { newPerson = MakeMan(lowAge, highAge); }
                            else { newPerson = MakeBoy(lowAge, highAge); }
                        }
                        else { newPerson = MakeSeniorMan(lowAge, highAge); }
                        break;

                    default:
                        if (highAge < 65)
                        {
                            if (highAge > 18) { newPerson = MakeSomeone(lowAge, highAge); }
                            else { newPerson = MakeChild(lowAge, highAge); }
                        }
                        else { newPerson = MakeSeniorPerson(lowAge, highAge); }
                        break;


                }
                list.Add(newPerson);
                i++;

            }
            return list;
        }
        #region various genBirthDates
        public static DateTime? GenRanAdultBirthDate(int age)
        {
            var start = new DateTime((2018 - age), 1, 1);
            var end = new DateTime((2018 - age), 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static DateTime? GenRanChildBirthDate(int age)
        {
            var start = new DateTime((2018 - age), 1, 1);
            var end = new DateTime((2018 - age), 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static DateTime? GenRanSeniorBirthDate(int age)
        {
            var start = new DateTime((2018 - age), 1, 1);
            var end = new DateTime((2018 - age), 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        #endregion

        #region various genAges
        public static int GenAdultAge(int lowAge, int highAge)
        {
            int age; int min; int max;
            if (lowAge > 18) { min = lowAge; }
            else { min = 18; }
            if (highAge < 65) { max = highAge; }
            else { max = 65; }
            age = rnd.Next(min, max); 
            return age;
        }

        public static int GenChildAge(int lowAge, int highAge)
        {
            int age; int max;
            if (highAge < 18) { max = highAge; }
            else { max = 18; }
            age = rnd.Next(lowAge, max);
            return age;
        }

        public static int GenSeniorAge(int lowAge, int highAge)
        {
            int age; int min;
            if (lowAge > 65) { min = lowAge; }
            else { min = 65; }
            age = rnd.Next(min, highAge);
            return age;
        }


        #endregion

        #region makePerson
        public static Person MakeWoman(int lowAge, int highAge)
        {
            int age = GenAdultAge(lowAge, highAge); 
            return new Person("Michelle", age, Gender.Woman, GenRanAdultBirthDate(age));
        }

        public static Person MakeSomeone(int lowAge, int highAge)
        {
            int age = GenAdultAge(lowAge, highAge); 
            return new Person("Bard", age, Gender.GenderNonBinary, GenRanAdultBirthDate(age));

        }

        public static Person MakeMan(int lowAge, int highAge)
        {
            int age = GenAdultAge(lowAge, highAge); 
            return new Person("Barack", age, Gender.Man, GenRanAdultBirthDate(age));

        }

        public static Person MakeGirl(int lowAge, int highAge)
        {
            int age = GenChildAge(lowAge, highAge);
            return new Person("Micah", age, Gender.Woman, GenRanChildBirthDate(age));
        }

        public static Person MakeBoy(int lowAge, int highAge)
        {
            int age = GenChildAge(lowAge, highAge);
            return new Person("Thomas", age, Gender.Man, GenRanChildBirthDate(age));
        }

        public static Person MakeChild(int lowAge, int highAge)
        {
            int age = GenChildAge(lowAge, highAge);
            return new Person("Charlie", age, Gender.GenderNonBinary, GenRanChildBirthDate(age));
        }

        public static Person MakeSeniorWoman(int lowAge, int highAge)
        {
            int age = GenSeniorAge(lowAge, highAge);
            return new Person("Pat", age, Gender.Woman, GenRanSeniorBirthDate(age));

        }

        public static Person MakeSeniorMan(int lowAge, int highAge)
        {
            int age = GenSeniorAge(lowAge, highAge);
            return new Person("Allen", age, Gender.Man, GenRanSeniorBirthDate(age));

        }

        public static Person MakeSeniorPerson(int lowAge, int highAge)
        {
            int age = GenSeniorAge(lowAge, highAge);
            return new Person("Mason", age, Gender.GenderNonBinary, GenRanSeniorBirthDate(age));

        }

#endregion

    }
}




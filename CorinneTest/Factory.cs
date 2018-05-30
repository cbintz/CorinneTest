using System;
using System.Collections.Generic;

namespace CorinneTest
{
    class Factory : IPersonFactory
    {
        public static List<Person> CreateInRange(int lowAge = 18, 
                                                 int highAge = 80, 
                                                 int numOfPeople = 100) {
            var list = new List<Person>();

            return list;
        }

        public static Person MakeMan() {
            
        }

        public static Person MakeWoman() {
            
        }

        public static Person MakeSomeone() {
            
        }

        public static Person MakeChild() {
            
        }

        public static Person MakeSenior() {
            
        }


    }
}
        



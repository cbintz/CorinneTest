using System;
using System.Collections.Generic;

namespace CorinneTest
// singleton for person list
{
    public class PersonDataSource
    {

        #region Singleton
        private static PersonDataSource instance = null;

        public static void Reset()
        {
            instance = null;
        }

        public static PersonDataSource Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PersonDataSource();
                }
                return instance;
            }
        }

        private PersonDataSource()
        {
            this.People = new List<Person>();
        }

        public void SetList(int lowAge, int highAge, int numPeople){
            if (instance != null)
                this.People = Factory.CreateInRange(lowAge, highAge, numPeople);
        }

        public Person GetPerson(int index){
            if (index < this.People.Count) { return this.People[index]; }
            else { return this.People[this.People.Count-1]; }
        }
        #endregion

        #region Variables
        public List<Person> People { get; set; }
        #endregion
    }
}

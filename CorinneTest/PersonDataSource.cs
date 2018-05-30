using System;
using System.Collections.Generic;

namespace CorinneTest
// singleton for person list
{
    public class PersonDataSource
    {

        #region Singleton
        private static PersonDataSource instance = null;

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
        #endregion

        #region Variables
        public List<Person> People { get; set; }
        #endregion
    }
}

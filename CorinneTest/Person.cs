using System;
namespace CorinneTest
{
    partial class Person
    {
        private string name;
        public string Name
        {
            get => this.name; 
            set { this.name = value; }
        }

        private int age;
        public int Age
        {
            get => this.age;
            set {
                if (value < 1) value = 1;
                else if (value > 100) value = 100;
                this.age = value;
            }
        }

        private Gender _gender;
        public Gender PersonGender
        {
            get => this._gender; 
            set { this._gender = value; }

        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => this.birthDate; 
            set { 
                if birthDate.Month < 1
                this.birthDate = value; }
        }


        public Person(string myName, int myAge, Gender myGender, DateTime myBirthDate) 
        {
            this.name = myName;
            this.age = myAge;
            this._gender = myGender;
            this.birthDate = myBirthDate;
        }
    }
}

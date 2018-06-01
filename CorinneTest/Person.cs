using System;
namespace CorinneTest
{
    public class Person 
    {
        string name;
        public string Name
        {
            get => this.name; 
            set { this.name = value; }
        }

        int? age;
        public int Age
        {
            get { if (this.age == null) this.Age = 1; return this.age.Value; }
            set {
                if (value < 1) value = 1;
                else if (value > 100) value = 100;
                this.age = value;
            }
        }

        Gender gender;
        public Gender Gender
        {
            get => this.gender; 
            set { this.gender = value; }

        }

        DateTime? birthDate;
        public DateTime? BirthDate
        {
            get => this.birthDate; 
        }

        public Person(string myName, int? myAge, Gender myGender, DateTime? myBirthDate)
        {
            this.name = myName;
            this.age = myAge;
            this.gender = myGender;
            this.birthDate = myBirthDate;
        }
    }
}

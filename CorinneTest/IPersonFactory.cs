using System;
namespace CorinneTest
{
    interface IPersonFactory
    {
        Person CreatePerson(string myName, int myAge, Gender myGender, DateTime myBirthDate);
    }
}

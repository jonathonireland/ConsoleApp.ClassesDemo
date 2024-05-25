using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public partial class Person
    {
  
        public Person(string firstName, string lastName, DateOnly dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = dob;
        }

        public int GetAge()
        {
            var age = DateTime.Now.Year - DateofBirth.Year;
            return age;
        }

        public int GetAge(int year) 
        {
            var age = year - DateofBirth.Year;
            return age;
        }
    }
}

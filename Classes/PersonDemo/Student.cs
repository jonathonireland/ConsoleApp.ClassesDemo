using ConsoleApp.ClassesDemo.Utils;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public class Student : Person
    {
        private string _idNumber;

        public void GenerateStudentIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("STU");
        }

    }
}

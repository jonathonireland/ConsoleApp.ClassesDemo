using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public class Student : Person
    {
        public void GenerateStudentIdNumber()
        {
            _idNumber = "STU-" + GetRandomNumber();
        }

    }
}

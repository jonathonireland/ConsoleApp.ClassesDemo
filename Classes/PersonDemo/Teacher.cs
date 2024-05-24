using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public class Teacher : Person
    {

        public void GenerateTeacherIdNumber()
        {
            _idNumber = "TCH-" + GetRandomNumber();
        }
    }
}

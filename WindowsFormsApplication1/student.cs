using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class student
    {
        public string name;
        public string surname;
        public int age;
        public string department;

        public student(string n, string s, int a, string d)
        {
            name = n;
            surname = s;
            age = a;
            department = d;
        }
        public student()
        {
            name = "";
            surname = "";
            age = 0;
            department = "";
        }

        public void printStudent()
        {
            Console.WriteLine(name, " ", surname, " ", age, " ", department);
        }

        public string getStudentInfo()
        {
            return name + " " + surname + " " + age + " " + department;
        }
    }
}

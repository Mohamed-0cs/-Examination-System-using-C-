using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Student
    {
        public string Name { get; set; }
        public Student(string _name)
        {
            Name = _name;
        }
        public void Notify(object sender , string message) {
            Console.WriteLine($"{Name} notified: {message}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    internal class Student : Human
    {
        public int Grade { get; set; }
        public Student(string name, int grade) : base(name)
        {
            Grade = grade;
        }
        public void Telebe(List<Student> students)
        {
            Console.WriteLine("ad");
            string name = Console.ReadLine();
            Console.WriteLine("grade");
            int grade = int.Parse(Console.ReadLine());
            Student student = new Student(name, grade);
            students.Add(student);
        }
    }
}

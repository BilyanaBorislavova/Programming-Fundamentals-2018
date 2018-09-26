using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = data[0];
                List<double> grades = data.Skip(1).Select(double.Parse).ToList();

                Student student = new Student()
                {
                    Name = name,
                    Grades = grades,
                    AverageGrade = grades.Average()
                };

                students.Add(student);
            }

            foreach (var stu in students.Where(a => a.AverageGrade >= 5.00).OrderBy(a => a.Name).ThenByDescending(a => a.AverageGrade))
            {
                Console.WriteLine($"{stu.Name} -> {stu.AverageGrade:f2}");
            }

        }
    }
}

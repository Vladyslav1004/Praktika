using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    public class Teachers : Person
    {
        public static void SetMark<T>(List<T> Student) where T : Students
        {
            while (true)
            {
                string str;
                int mark;
                foreach (T student in Student)
                {
                    Console.WriteLine($"{student.id}: {student.firstName} {student.lastName} ");
                    mark = Convert.ToInt32(Console.ReadLine());
                    student.countMark++;
                    student.sumMark += mark;
                    student.medianMark = student.sumMark / student.countMark;
                }

                Student.Sort((s1, s2) => s2.medianMark.CompareTo(s1.medianMark));

                for (int i = 0; i < Student.Count; i++)
                {
                    Student[i].id = i + 1;
                }

                Console.WriteLine("=== Results ===");
                Utils.PrintStudents(Student);

                Console.WriteLine("Do you want to do it again?");
                str = Console.ReadLine();
                if (str != "y" && str != "Y")
                {
                    break;
                }
            }
           
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    public class Utils
    {
        static public void AInformation<TTeacher, TStudent>(List<TTeacher> teachers, List<TStudent> students, int teachersID) where TTeacher : Person where TStudent : Person
        {
            Console.WriteLine("=== Working with ===");
            for (int i = 0; i < teachers.Count; i++)
            {
                if (teachersID != teachers[i].id)
                {
                    Console.WriteLine($"ID: {teachers[i].id}; FULL NAME: {teachers[i].firstName} {teachers[i].lastName}; AGE: {teachers[i].age};");
                }

            }
            Console.WriteLine("=== His/Her students ===");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"ID: {students[i].id}; FULL NAME: {students[i].firstName} {students[i].lastName}; AGE: {students[i].age}; GROUP: {students[i].group};");
            }
        }

        static public List<T> Grouping<T>(List<T> students, bool isFirst) where T : Person
        {
            List<T> group122 = new List<T>();
            List<T> group123 = new List<T>();
            int count = 0;

            if (isFirst)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].group == "122")
                    {
                        group122.Add(students[i]);
                        group122[count].id = count + 1;
                        count++;
                    }
                }
                return group122;
            }
            else
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].group == "123")
                    {
                        group123.Add(students[i]);
                        group123[count].id = count + 1;
                        count++;
                    }
                }
                return group123;
            }
        }

        static public void PrintPeople<T>(List<T> people) where T : Person
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"ID: {people[i].id}; FULL NAME: {people[i].firstName} {people[i].lastName}; AGE: {people[i].age}; GROUP: {people[i].group}; ");
            }
        }

        static public void PrintStudents<T>(List<T> student) where T : Student
        {
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine($"ID: {student[i].id}; FULL NAME: {student[i].firstName} {student[i].lastName}; MID MARK: {student[i].medianMark}");
            }
        }

    }
}

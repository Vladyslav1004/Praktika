using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    public class Utils
    {
        static public void AdditionalInformation<TTeacher, TStudent>(List<TTeacher> teachers, List<TStudent> students, string firstName, string lastName) where TTeacher : Teacher where TStudent : Student
        {
            foreach (var teacher in teachers)
            {

                var studentsGroup = Data.Groups.Group122;

                if (teacher.group == Data.Groups.Group123T)
                {
                    studentsGroup = Data.Groups.Group123;
                }
                else if (teacher.group == Data.Groups.Group122T)
                {
                    studentsGroup = Data.Groups.Group122;
                }
                if (firstName == teacher.firstName && lastName == teacher.lastName)
                {
                    Console.WriteLine($"ID: {teacher.id}; FULL NAME: {teacher.firstName} {teacher.lastName}; AGE: {teacher.age}; Second High Education {teacher.secondHiEducation} Finshed school {teacher.finishedSchool}");
                    Console.WriteLine("=== Working with ===");
                    foreach (var teacher1 in teachers)
                    {
                        if (teacher.group == teacher1.group && teacher != teacher1)
                        {
                            Console.WriteLine($"ID: {teacher1.id}; FULL NAME: {teacher1.firstName} {teacher1.lastName}; AGE: {teacher1.age};");
                        }
                    }
                    Console.WriteLine("=== His/Her students ===");
                    foreach (var student in students)
                    {
                        if (student.group == studentsGroup)
                        {
                            Console.WriteLine($"ID: {student.id}; FULL NAME: {student.firstName} {student.lastName}; AGE: {student.age};");
                        }
                    }
                }
            }

            foreach (var student in students)
            {
                if (firstName == student.firstName && lastName == student.lastName)
                {
                    var teachersGroup = Data.Groups.Group122;

                    if (student.group == Data.Groups.Group123)
                    {
                        teachersGroup = Data.Groups.Group123T;
                    }
                    else if (student.group == Data.Groups.Group122)
                    {
                        teachersGroup = Data.Groups.Group122T;
                    }

                    Console.WriteLine($"ID: {student.id}; FULL NAME: {student.firstName} {student.lastName}; AGE: {student.age}; Second High Education {student.secondHiEducation} Finshed school {student.finishedSchool}");
                    Console.WriteLine("=== His/Her teachers ===");

                    foreach (var teacher1 in teachers)
                    {
                        if (teacher1.group == teachersGroup)
                        {
                            Console.WriteLine($"ID: {teacher1.id}; FULL NAME: {teacher1.firstName} {teacher1.lastName}; AGE: {teacher1.age};");
                        }
                    }
                    Console.WriteLine("=== Studiing with ===");
                    foreach (var student1 in students)
                    {
                        if (student1.group == student.group && student1 != student)
                        {
                            Console.WriteLine($"ID: {student1.id}; FULL NAME: {student1.firstName} {student1.lastName}; AGE: {student1.age};");
                        }
                    }
                }
            }
        }

        static public List<T> GetGroups<T>(List<T> people, Data.Groups group) where T : Person
        {
            List<T> newGroup = new List<T>();

            for (int i = 0; i < people.Count; i++)
            {
                    if (people[i].group == group)
                    {
                        newGroup.Add(people[i]);
                    }
            }
            return newGroup;
        }

        static public void PrintPeople<T>(List<T> people) where T : Person
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"FULL NAME: {people[i].firstName} {people[i].lastName}; AGE: {people[i].age}; GROUP: {people[i].group}; ");
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

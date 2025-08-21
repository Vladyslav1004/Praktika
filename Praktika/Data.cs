using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{


    public class Data
    {
        public enum Groups
        {
            Group122,
            Group123,
            Group122T,
            Group123T
        }

        private static List<Student> students = new List<Student>() 
        {
            new Student { id = Guid.NewGuid(), firstName = "Ivan", lastName = "Kovalchuk", age = 18, secondHiEducation = false, finishedSchool = true, group = Groups.Group122 },
            new Student { id = Guid.NewGuid(), firstName = "Olena", lastName = "Syvorenko", age = 25, secondHiEducation = true, finishedSchool = true, group = Groups.Group123 },
            new Student { id = Guid.NewGuid(), firstName = "Artem", lastName = "Bondar", age = 17, secondHiEducation = false, finishedSchool = true, group = Groups.Group122 },
            new Student { id = Guid.NewGuid(), firstName = "Maria", lastName = "Lytvynenko", age = 35, secondHiEducation = false, finishedSchool = false, group = Groups.Group123 },
            new Student { id = Guid.NewGuid(), firstName = "Vladyslav", lastName = "Petrenko", age = 20, secondHiEducation = false, finishedSchool = true, group = Groups.Group122 },
            new Student { id = Guid.NewGuid(), firstName = "Anastasiia", lastName = "Moroz", age = 16, secondHiEducation = false, finishedSchool = false, group = Groups.Group123 },
            new Student { id = Guid.NewGuid(), firstName = "Denys", lastName = "Shevchenko", age = 19, secondHiEducation = false, finishedSchool = true, group = Groups.Group122 },
            new Student { id = Guid.NewGuid(), firstName = "Kateryna", lastName = "Ivanova", age = 22, secondHiEducation = false, finishedSchool = true, group = Groups.Group123 },
            new Student { id = Guid.NewGuid(), firstName = "Dmytro", lastName = "Honchar", age = 45, secondHiEducation = false, finishedSchool = true, group = Groups.Group122 },
            new Student { id = Guid.NewGuid(), firstName = "Sofiia", lastName = "Romanenko", age = 29, secondHiEducation = false, finishedSchool = true, group = Groups.Group123 }
        };
        public static List<Student> Students 
        { 
            get 
            {
                return students;
            }
        }

        private static List<Teacher> teachers = new List<Teacher>() {

            new Teacher { id = Guid.NewGuid(), firstName = "Olena", lastName = "Kravchenko", age = 45, secondHiEducation = true, finishedSchool = true, group = Groups.Group123T },
            new Teacher { id = Guid.NewGuid(), firstName = "Petro", lastName = "Shevchenko", age = 39, secondHiEducation = true, finishedSchool = true, group = Groups.Group122T },
            new Teacher { id = Guid.NewGuid(), firstName = "Iryna", lastName = "Koval", age = 50, secondHiEducation = true, finishedSchool = true, group = Groups.Group123T },
            new Teacher { id = Guid.NewGuid(), firstName = "Serhii", lastName = "Bondar", age = 33, secondHiEducation = true, finishedSchool = true, group = Groups.Group122T },
            new Teacher { id = Guid.NewGuid(), firstName = "Tetiana", lastName = "Moroz", age = 41, secondHiEducation = true, finishedSchool = true, group = Groups.Group123T }
        };
        public static List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }
        }

        public static void AddStudents(List<Student> student)
        {
            foreach (Student student1 in student)
            {
                Students.Add(student1);
            }
        }
    }
}

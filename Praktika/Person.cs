using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    abstract public class Person
    {
        public Guid id { get; set; }
        public string firstName;
        public string lastName;
        public int age;
        public Data.Groups group { get; set; }
        public bool secondHiEducation;
        public bool finishedSchool;
    }
}

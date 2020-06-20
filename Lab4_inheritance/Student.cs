using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_inheritance
{
    class Student : Person
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string m_name;
        private int m_age;
        private string m_studentID;

        // PUBLIC PROPERTIES
        public string Name
        {

            get // accessor
            {
                return m_name;
            }

            set // mutator
            {
                m_name = value;
            }
        }

        public int Age
        {
            get
            {
                return m_age;
            }

            set
            {
                m_age = value;
            }
        }



        // CONSTRUCTOR
        public Student(string name, int age, string student_id)
            : base(name, age)
        {
            m_name = name;
            m_age = age;
            m_studentID = student_id;

        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        public new void SaysHello()
        {
            Console.WriteLine($"{Name} says Hello.");
        }

        public void Studies()
        {
            Console.WriteLine($"{Name} is Studying.");
        }
    }
}
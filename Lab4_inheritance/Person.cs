using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_inheritance
{
    class Person
    {
                 // PRIVATE INSTANCE VARIABLES (FIELDS)
            private string m_name;
            private int m_age;

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
            public Person(string name, int age)
            {
                m_name = name;
                m_age = age;
            }

            // PRIVATE METHODS

            // PUBLIC METHODS
            public void SaysHello()
            {
                Console.WriteLine($"{Name} says Hello");
            }

            public override string ToString()
            {
                string outputString = "";

                outputString += "\n++++++++++++++++++++++++\n";
                outputString += $" Name: {Name}         \n";
                outputString += $" Age : {Age}          \n";
                outputString += "++++++++++++++++++++++++\n";

                return outputString;
            }

        }
    }



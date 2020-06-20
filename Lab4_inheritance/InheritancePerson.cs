using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_inheritance
{
    class InheritancePerson
    {
        static void Main(string[] args)
        {
         
                Person Christina = new Person("Tom", 40);

                Christina.SaysHello();

                string christinaString = Christina.ToString();

                Console.WriteLine(christinaString);
                Console.WriteLine();


                Person jacky = new Person("Jacky", 22);

                jacky.SaysHello();

                Console.WriteLine(jacky.ToString());
                Console.WriteLine();

                Person Nina = new Person("Joss", 22);

                Nina.SaysHello();
              

                Console.WriteLine(Nina.ToString());


                // wait for user to enter anything
                Console.ReadLine();
            }
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
}

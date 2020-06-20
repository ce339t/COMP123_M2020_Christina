using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_inheritance
{
    class InheritanceMain
    {
        static void Main(string[] args)
        {
         
                Person Christina = new Person("Christina", 31);

                Christina.SaysHello();

                string christinaString = Christina.ToString();

                Console.WriteLine(christinaString);
                Console.WriteLine();


                Person jacky = new Person("Jacky", 22);

                jacky.SaysHello();

                Console.WriteLine(jacky.ToString());
                Console.WriteLine();

                Person Nina = new Person("Nina", 22);

                Student Kit = new Student("Kit", 31, "301121940");

                Nina.SaysHello();
                Kit.Studies();
              

                Console.WriteLine(Nina.ToString());


                // wait for user to enter anything
                Console.ReadLine();
            }

           
    }
}

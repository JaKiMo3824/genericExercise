using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Strings = new Employee<string>(); 
            Strings.things = new List<string>() {"Dog", "Cat", "Bird", "Mouse" };

            Employee<int> Integers = new Employee<int>();
            Integers.things = new List<int>() { 1, 2, 3, 4 };

            


            foreach (string stri in Strings.things)
            {
                Console.WriteLine(stri);

                
            }
            foreach (int inte in Integers.things)
            {
                    Console.WriteLine(inte);
                    
            }
            Console.ReadLine();
            //Console.WriteLine(Strings.things);
            //Console.WriteLine(Integers.things);
            //Console.ReadLine();


            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //employee.Employed = true;
            //employee.Id = 1234;

            //Employee employee2 = new Employee();
            //employee2.FirstName = "Ample";
            //employee2.LastName = "Tudent";
            //employee2.Employed = true;
            //employee2.Id = 1234;

            //if (employee.Id == employee2.Id)
            //{
            //    Console.WriteLine("The two employee ID's are identical and therefore are invalid.");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("The two employee ID's are not identical.");
            //    Console.ReadLine();
            //}

            //employee.Quit();
        }
    }
}

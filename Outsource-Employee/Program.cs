using System;
using System.Collections.Generic;
using Exercises.Entities;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());
            

            List<Employee> EmployeeList = new List<Employee>();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Employee #" + (i+1) + " data:" );
                Console.Write("Outsourced (y/n): ");
                string ySn = Console.ReadLine();
                
                if (ySn == "n") {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuephour = double.Parse(Console.ReadLine());
                    EmployeeList.Add(new Employee(name, hours, valuephour));
                }
                else
                {
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Hours: ");
                        int hours = int.Parse(Console.ReadLine());
                        Console.Write("Value per hour: ");
                        double valuephour = double.Parse(Console.ReadLine());
                        Console.Write("Additional Charge: ");
                        double additional = double.Parse(Console.ReadLine());
                        EmployeeList.Add(new OutSourcedEmployee(name, hours, valuephour, additional));
                }
            }
            
            foreach (Employee x in EmployeeList)
            {
                Console.WriteLine(x);
            }
         
        }
    }
}

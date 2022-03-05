using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        } 


        public virtual double Payment(int hours, double valuephour)
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return Name + " - U$ " + Payment(Hours, ValuePerHour).ToString("F2");
        }

    }
}

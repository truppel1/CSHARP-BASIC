using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Entities
{
    internal class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment(int hours, double valuephour)
        {
            AdditionalCharge = (AdditionalCharge * 110) / 100;

            return base.Payment(hours, valuephour) + AdditionalCharge;
        }

        public override string ToString()
        {
            return Name + " - U$ " + Payment(Hours, ValuePerHour).ToString("F2");
        }
    }
}

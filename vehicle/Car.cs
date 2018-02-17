using System;
using System.Collections.Generic;
using System.Text;

namespace vehicle
{
    public class Car : Vehicle
    {
        public int NumberOfWheels = 4;
        public string Condition;
        public Car() : base(5)
        {
            Condition = "New";
        }
        public Car(double odo) : base(5, odo)
        {
            Condition = "Used";
        }
        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("This vehicle is a car!");
            Console.WriteLine($"Car Condition is {Condition}");
        }

    }
}

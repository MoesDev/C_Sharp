using System;

namespace vehicle
{
    public class Vehicle
    {
        private int _numPassengers;
        public int numPassengers
        {
            get { return _numPassengers; }
            set { _numPassengers = value; }
        }
        public double distance = 0.0;


        public Vehicle(int val = 0)
        {
            numPassengers = val;
        }
        public Vehicle(int val, double odo)
        {
            numPassengers = val;
            distance = odo;
        }
        
        public int Move(double miles)
        {
            distance += miles;
            return (int)distance;
        }

        public double Move(double miles, bool km) // if the miles is given in kilometers, true to convert
        {
            //Convert the KM measurement to miles
            if (km == true)
            {
                miles = miles * 0.62;
            }
            return Move(miles);
        }
        public void GetInfo()
        {
            Console.WriteLine("This is a basic vehicle.");
            Console.WriteLine("Currently has traveled {0}", distance);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle(4);
            Console.WriteLine("My car can hold " + car.numPassengers + " people");
            Vehicle bike = new Vehicle(1, 10.2);
            Car myRedCar = new Car(30);

            Console.WriteLine("My RED car can hold " + myRedCar.numPassengers + " people");

            Console.WriteLine("My car has gone {0} miles", car.distance);
            Console.WriteLine("My RED car has gone {0} miles", myRedCar.distance);
            Console.WriteLine("My bike has gone {0} miles", bike.distance);

            car.Move(70.8);
            myRedCar.Move(51, true);
            bike.Move(5, true);

            Console.WriteLine("My car has gone {0} miles", car.distance);
            Console.WriteLine("My RED car has gone {0} miles", myRedCar.distance);
            Console.WriteLine("My bike has gone {0} miles", bike.distance);

            Car oldCar = new Car(140500);
            Console.WriteLine("Old Car:");
            Console.WriteLine($"Car Condition: {oldCar.Condition}");
            Console.WriteLine($"Max Number of Passengers: {oldCar.numPassengers}");
            oldCar.Move(6);
            Console.WriteLine($"Current Mileage: {oldCar.distance} miles");
            oldCar.GetInfo();
            Console.WriteLine("Bike Info:");
            bike.GetInfo();
        }
    }
}

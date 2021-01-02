using System;
using System.Collections.Generic;

namespace FirstCSharp
{
    class Car : Vehicle, IRideable
    {
        public string Make;
        public string Model;

        public double DistanceTraveled 
        {
            get { return odometer; }
            set { odometer = value; }
        }

        public void Ride(double distance)
        {
            Console.WriteLine("I am driving!");
            DistanceTraveled += distance;
        }
        public Car(string color, string make, string model) : base(color)
        {
            Make = make;
            Model = model;
        }
        public override void getInfo()
        {
            base.getInfo();
            //Console.WriteLine($"Num Pass: {NumPassengers}");
            //Console.WriteLine($"Color: {color}");
            //Console.WriteLine($"Miles: {odometer}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Miles: {Model}");
        }
    }

    class Person
    {
        public string Name;

        public IRideable Transport;

        public double Miles;
        public List<Vehicle> OwnedVehicles;

        public Person()
        {
            OwnedVehicles = new List<Vehicle>();
        }

        public Person(string name, IRideable trans)
        {
            Name = name;
            Miles = 0;
            Transport = trans;
        }

        public void AddToVehicles(Vehicle newV)
        {
            OwnedVehicles.Add(newV);
        }

        public void DisplayVehicles()
        {
            foreach(var v in OwnedVehicles)
            {
              v.getInfo();
            }
        }

        public void GoSomewhere(double distance)
        {
            Transport.Ride(distance);
            Miles += Transport.DistanceTraveled;
        }

            public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Miles Traveled: {Miles}");
        }
    }
}
using System;

namespace FirstCSharp
{
    class Horse : IRideable
    {
        public string Name;

        public double Endurance;

        public double DistanceTraveled {get;set;}
        public void Ride(double distance)
        {
            Console.WriteLine("I am riding!");
            if(distance >= Endurance)
                distance = Endurance;
            DistanceTraveled += distance;
        }

        public Horse(string name, double endurance)
        {
            Name = name;
            Endurance = endurance;
            DistanceTraveled = 0;
        }
    }
}
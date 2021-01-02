using System;

namespace FirstCSharp
{
  class Vehicle
  {
    public int NumPassengers;

    public string color;

    protected double odometer;

    public Vehicle(int numPas, string col)
    {
      NumPassengers = numPas;
      color = col;
      odometer = 0;
    }

    public Vehicle(string col)
    {
      NumPassengers = 5;
      color = col;
      odometer = 0;
    }

    // Method overloading
    void MakeNoise(string noise)
    {
      Console.WriteLine(noise);
    }

    void MakeNoise()
    {
      Console.WriteLine("BEEP");
    }

    string ColorProp
    {
      get
      {
        if(color == "Green")
          return $"This SWEET thing is {color}";
        return $"This thing is {color}";
      }
      set
      {
        if(value != "Green")
        color = value;
      }
    }

    string Name {get;set;}

    public virtual void getInfo()
    {
      Console.WriteLine($"Num Pass: {NumPassengers}");
      Console.WriteLine($"Color: {color}");
      Console.WriteLine($"Miles: {odometer}");
    }
  }
}
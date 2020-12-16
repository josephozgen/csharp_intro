using System;
using System.Collections.Generic;


namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = "Coding Dojo";
            Console.WriteLine($"Hello {place}");
            Console.WriteLine("The value of pi is " + 3.14159);
            Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");
            Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            //string name = "Todd";
            //int age = 32;
            //double height = 1.875;
            //bool blueEyed = true;

            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double max1 = double.MaxValue;
            double min2 = double.MinValue;
            Console.WriteLine($"The range of double is {min2} to {max1}");        

            decimal min1 = decimal.MinValue;
            decimal max2 = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min1} to {max2}");

            double a1 = 1.0;
            double b1 = 3.0;
            Console.WriteLine(a1 / b1);

            decimal c1 = 1.0M;
            decimal d1 = 3.0M;
            Console.WriteLine(c1 / d1);

            //Declare a variable called rings that is of the Int Type
            int numRings = 5;
            if (numRings >= 5)
            {
                Console.WriteLine("You are welcome to join the party");
            }
            else
            {
                Console.WriteLine("Go win some more rings");
            }
            // loop from 1 to 5 including 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            // loop from 1 to 5 excluding 5
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int start = 0;
            int end = 5;
            // loop from start to end including end
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
            // loop from start to end excluding end
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }
            //int i = 1;
            //while (i < 6)
            //{
            //    Console.WriteLine(i);
            //    i = i + 1;
            //}

            int counter = 0;
            do
            {
              Console.WriteLine($"Hello World! The counter is {counter}");
              counter++;
            } while (counter < 10);

            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The column is {column}");
            }           

            Random rand = new Random();
            for(int val = 0; val < 10; val++)
            {
                //Prints the next random value between 2 and 8
                Console.WriteLine(rand.Next(2,8));
            }

            // Declaring an array of length 5, initialized by default to all zeroes
            int[] numArray = new int[5];
            // Declaring an array with pre-populated values
            // For Arrays initialized this way, the length is determined by the size of the given data
            int[] numArray2 = {1,2,3,4,6};
            int[] array3;
            array3 = new int[] {1,3,5,7,9};
            int[] arrayOfInts = {1, 2, 3, 4, 5};
            Console.WriteLine(arrayOfInts[0]);    // The first number lives at index 0.
            Console.WriteLine(arrayOfInts[1]);    // The second number lives at index 1.
            Console.WriteLine(arrayOfInts[2]);    // The third number lives at index 2.
            Console.WriteLine(arrayOfInts[3]);    // The fourth number lives at index 3.copy
            Console.WriteLine(arrayOfInts[4]);    // The fifth and final number lives at index

            int[] arr = {1, 2, 3, 4};
            Console.WriteLine($"The first number of the arr is {arr[0]}"); 
            arr[0] = 8;
            Console.WriteLine($"The first number of the arr is now {arr[0]}");
            // The array has now changed!

            string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
            // The 'Length' property tells us how many values are in the Array (4 in our example here). 
            // We can use this to determine where the loop ends: Length-1 is the index of the last value. 
            for (int idx = 0; idx < myCars.Length; idx++)
            {
                Console.WriteLine($"I own a {myCars[idx]}");
            }

            var names = new List<string> { "Yusuf", "Ana", "Felipe" };
            foreach (var name in names)
            {
              Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            var index = names.IndexOf("Felipe");
            if (index != -1)
              Console.WriteLine($"The name {names[index]} is at index {index}");
            
            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");            

            foreach (string car in myCars)
            {
                // We no longer need the index, because variable 'car' already represents each indexed value
                Console.WriteLine($"I own a {car}");
            }

            //Initializing an empty list of Motorcycle Manufacturers
            List<string> bikes = new List<string>();
            //Use the Add function in a similar fashion to push
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");
            //Accessing a generic list value is the same as you would an array
            Console.WriteLine(bikes[2]); //Prints "BMW"
            Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

            //Using our array of motorcycle manufacturers from before
            //we can easily loop through the list of them with a C-style for loop
            //this time, however, Count is the attribute for a number of items.
            Console.WriteLine("The current manufacturers we have seen are:");
            for (var idx = 0; idx < bikes.Count; idx++)
            {
                Console.WriteLine("-" + bikes[idx]);
            }
            // Insert a new item between a specific index
            bikes.Insert(2, "Yamaha");
            //Removal from Generic List
            //Remove is a lot like Javascript array pop, but searches for a specified value
            //In this case we are removing all manufacturers located in Japan
            bikes.Remove("Suzuki");
            bikes.Remove("Yamaha");
            bikes.RemoveAt(0); //RemoveAt has no return value however
            //The updated list can then be iterated through using a foreach loop
            Console.WriteLine("List of Non-Japanese Manufacturers:");
            foreach (string manu in bikes)
            {
                Console.WriteLine("-" + manu);
            }

            Dictionary<string,string> profile = new Dictionary<string,string>();
            //Almost all the methods that exists with Lists are the same with Dictionaries
            profile.Add("Name", "Speros");
            profile.Add("Language", "PHP");
            profile.Add("Location", "Greece");
            Console.WriteLine("Instructor Profile");
            Console.WriteLine("Name - " + profile["Name"]);
            Console.WriteLine("From - " + profile["Location"]);
            Console.WriteLine("Favorite Language - " + profile["Language"]);

            foreach (KeyValuePair<string,string> entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

            //The var keyword takes the place of a type in type-inference
            foreach (var entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        // Create a list of 5 strings.
        var animals = new List<string>() { "bird", "dog","Camel","Lion","Elephant" };
        // Insert strings from an array in position 1.
        animals.InsertRange(1, new string[] { "frog", "snake" });
        foreach (string value in animals)
        {
            Console.WriteLine("RESULT: " + value);
        }
    }
}
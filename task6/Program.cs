using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "apple", "orange", "banana" };
        Console.WriteLine(string.Join(", ", names));

        names.Add("mango");
        Console.WriteLine(string.Join(", ", names));

        names.Remove("apple");
        Console.WriteLine(string.Join(", ", names));

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        Dictionary<int, string> fruits = new Dictionary<int, string>
        {
            { 1, "apple" },
            { 2, "orange" },
            { 3, "banana" }
        };

        fruits.Add(4, "mango");

        Console.WriteLine("Dictionary contents:");
        foreach (var kvp in fruits)
        {
            Console.WriteLine($"{kvp.Key} {kvp.Value}");
        }
    }
}
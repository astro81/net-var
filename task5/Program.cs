using System;

class Program
{
    static void Main()
    {
        // Birthday
        DateTime birthday = new DateTime(1995, 8, 15);
        Console.WriteLine("Birthday: " + birthday.ToString("yyyy-MM-dd"));
        
        // Current date and time
        DateTime currentTime = DateTime.Now;
        DateTime currentUtcTime = DateTime.UtcNow;

        Console.WriteLine(currentTime.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine(currentUtcTime.ToString("yyyy-MM-dd HH:mm:ss"));
        
        // Calculate age using TimeSpan
        TimeSpan ageSpan = currentTime - birthday;
        int age = (int)(ageSpan.TotalDays / 365.25);
        Console.WriteLine($"Age: {age} years");

        // Add 10 days to birthday
        DateTime newDate = birthday.AddDays(10);
        Console.WriteLine("Birthday + 10 days: " + newDate.ToString("yyyy-MM-dd"));
    }
}
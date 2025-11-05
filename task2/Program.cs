class  Circle
{
    const double PI = 3.14;

    public static void Main(string[] args)
    {
        // PI = 3;
        // Console.WriteLine(PI);
        // error CS0131: The left-hand side of an assignment must be a variable, property or indexer [/home/astro/Documents/code/dotnet/prj/app-1/src/task2/task2.csproj]
        
        Console.WriteLine(area(2));
        Console.WriteLine(perimeter(3));
    }

    static double area(double radius)
    {
        return PI * radius * radius;
    }

    static double perimeter(double radius)
    {
        return 2 * PI * radius;
    }
    
        
}
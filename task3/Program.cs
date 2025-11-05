using System;

class Program
{
    static void Main()
    {
        byte testByte = 1;          
        short testShort = 2;        
        int testInt = 12;           
        long testLong = 66345L;     
        float testFloat = 3.1f;     
        double testDouble = 3.144;  
        decimal testDecimal = 4.3m; 
        char testChar = 'a';        
        bool testBool = true;

        string conStr = testInt.ToString();
        string sDouble = "3.14";
        double conDouble = Convert.ToDouble(sDouble);

        Console.WriteLine($"Byte value: {testByte}, Type: {testByte.GetType()}");
        Console.WriteLine($"Short value: {testShort}, Type: {testShort.GetType()}");
        Console.WriteLine($"Int value: {testInt}, Type: {testInt.GetType()}");
        Console.WriteLine($"Long value: {testLong}, Type: {testLong.GetType()}");
        Console.WriteLine($"Float value: {testFloat}, Type: {testFloat.GetType()}");
        Console.WriteLine($"Double value: {testDouble}, Type: {testDouble.GetType()}");
        Console.WriteLine($"Decimal value: {testDecimal}, Type: {testDecimal.GetType()}");
        Console.WriteLine($"Char value: {testChar}, Type: {testChar.GetType()}");
        Console.WriteLine($"Bool value: {testBool}, Type: {testBool.GetType()}");
        Console.WriteLine($"Integer as string: {conStr}, Type: {conStr.GetType()}");
        Console.WriteLine($"Converted string to double: {conDouble}, Type: {conDouble.GetType()}");
    }
}
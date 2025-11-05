class Program
{
    static void Main()
    {
        int[] nums = { 1, 3, 5, 4, 8 };
        Console.WriteLine(string.Join(", ", nums));

        Array.Sort(nums);
        Console.WriteLine(string.Join(", ", nums));

        Array.Reverse(nums);
        Console.WriteLine(string.Join(", ", nums));
        
        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }

        int idx = Array.IndexOf(nums, 4);
        Console.WriteLine(idx);

    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 20;
        Console.WriteLine($"Before Swapping {num1} and {num2}");
        Program.Swap( num1, num2);
        Console.WriteLine($"After Swapping {num1} and {num2}");



    }

    private static void Swap(in int x, in int y)
    {
        Console.WriteLine("Cannot be Swappped since we have used in keyword");
    }


}
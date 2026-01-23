internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 20;
        Console.WriteLine($"Before Swapping {num1} and {num2}");
        Program.Swap(ref num1, ref num2);
        Console.WriteLine($"After Swapping {num1} and {num2}");


    }

    private static void Swap(ref  int x, ref int y)
    {
        int temp = x;
        x = y;
        y= temp;
    }


}
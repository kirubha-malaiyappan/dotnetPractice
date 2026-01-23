internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 20;
        //Mandatory to modify
        Console.WriteLine($"Before Swapping {num1} and {num2}");
        Program.Swap(out num1, out num2);
        Console.WriteLine($"After Swapping {num1} and {num2}");


    }

    private static void Swap(out int x, out int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }


}
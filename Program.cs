
using System;

public class Geeks
{
    static public void Main()
    {

        var t1 = Tuple.Create("hii");

        Console.WriteLine("1st element of t1 : " + t1.Item1);
        Console.WriteLine();

        // 4-tuple
        // Using Create Method
        var t2 = Tuple.Create(12, 30, 40, 50);

        =
        // AC=ccesing using Item property
        Console.WriteLine("1st element of t2: " + t2.Item1);
        Console.WriteLine();

        //  8-tuple
        // Using Create Method
        var t3 = Tuple.Create(13, "Geeks",
              67, 89.90, 'g', 39939, "geek", 10);

        // Accessing the element of Tuple
        // Using Item property
        // And print the 8th element of tuple
        // using Rest property
        Console.WriteLine("1st element of t3: " + t3.Item1);
        Console.WriteLine("2nd lement of t3: " + t3.Item2);
        Console.WriteLine("8th element of t3: " + t3.Rest);
    }
}
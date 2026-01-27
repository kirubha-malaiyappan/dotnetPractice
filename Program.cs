using System.Globalization;

internal class Program
{
     public static void Main(string[] args)
    {
        string[] arguments = Environment.GetCommandLineArgs();
        Console.WriteLine("GetCommandLineArgs: {0}",arguments);
        string s = "this is kirubha malaiappan.";
        TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;

        
        Console.WriteLine(s.ToUpper());
        string result = currentTextInfo.ToTitleCase(s);
        Console.WriteLine();
        Console.WriteLine(result);
        InterpolationAndLiteral();


    }

    internal static void Print(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(s[i]); //string considered as an array
        }
    }

    internal static void Formatting(string s)
    {
        string firstName = "Kirubha";
        string lastName = " Malaiappan";
        Console.WriteLine("My name is {0} {1}", firstName, lastName);
        Console.WriteLine($"My name is {firstName} {lastName}");

    }
    internal static void InterpolationAndLiteral()
    {
        string firstName = "Kirubha";
        string path = @$"c:\{firstName}\""Users""";//double quotes in stringLi
        Console.WriteLine(path);

    }


}
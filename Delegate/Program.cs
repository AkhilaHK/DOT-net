using System;

class Program
{
    public delegate void Calculate(int n1, int n2);
    static void Main()
    {
        List<string> names = new List<string>();
        names.Add("Meena");
        names.Add("Rekha");
        names.Add("Reena");
        names.Add("Reena Chakravarthy");

        names.ForEach((str) =>
        {
            Console.WriteLine(str);
        });

        List<string> result = names.Where((str) =>
        {
           // return str.StartsWith("Re") && str.EndsWith("thy");
            return str.StartsWith("Re") || str.EndsWith("na");
        }).ToList();

        Console.WriteLine("Search for 'Re'");
        result.ForEach((str) =>
        {
            Console.WriteLine($"Found match for: {str}");
        });
        Console.WriteLine("----USING LINQ ----");
        var queryOutput = (from str in names
                           where str.Contains("Reena") || str.Contains("Chakravarthy")
                           select str)
        .ToList();
        queryOutput.ForEach((str) =>
        {
            Console.WriteLine(str);
        });

    }

    private static void CallDelegate()
    {
        Calculate Number = new Calculate((int n1, int n2) => { Console.WriteLine("The Addition of n1 and n2 is: " + (n1 + n2)); });
        Number += (int n1, int n2) => { Console.WriteLine("The Subtraction of n1 and n2 is: " + (n1 - n2)); };
        Number += (int n1, int n2) => { Console.WriteLine("The Multiplication of n1 and n2 is: " + (n1 * n2)); };
        Number += (int n1, int n2) => { Console.WriteLine("TheDivision of n1 and n2 is: " + (n1 / n2)); };
        Number(30, 5);
    }

    private static void Subtraction(int n1, int n2)
    {
        Console.WriteLine("The subtraction of n1 and n2 is: " +(n1-n2));
    }

    private static void Multiply(int n1, int n2)
    {
        Console.WriteLine("The Multiplication of n1 and n2 is: " +(n1*n2));
    }

    private static void Division(int n1, int n2)
    {
        Console.WriteLine("The Division of n1 and n2 is: " +(n1/n2));
    }

    private static void Addition(int n1, int n2)
    {
        Console.WriteLine("The Addition of n1 and n2 is: " +(n1+n2));
    }
}

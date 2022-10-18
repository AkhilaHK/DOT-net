using System;
using System.Collections.Generic;
using System.Linq;
using Oops;
using System.Threading;

class Program
{
    // created a new datatype
    //viz, declaration of delegate
    public delegate void PM(string requirement);
    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Hand Movement animation:: y-co-rdinate ={i}");
            }
        });
        t1.Name = "Hand animation";
        Thread t2 = new Thread(() =>
        {
        for (int i = 1000; i > 0; i--)
        {
            Console.WriteLine($"Ball Movement animation:; y-co-rdinate = {i}");
            }
        });
        t2.Name = "Ball Animation";

        //start the threads
        t1.Start();
        t2.Start();
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("==========The game has Completed!!!============");

    }

    private static void LinqLambdaL2()
    {
        //Collection of Rectangles
        List<Rectangle> rectangles = new List<Rectangle>();
        rectangles.Add(new Rectangle(10, 5));
        rectangles.Add(new Rectangle(10, 3));
        rectangles.Add(new Rectangle(20, 7));
        rectangles.Add(new Rectangle(25, 5));

        //Query: Get all rectangles whose length = 10
        rectangles
            .Where((r) => { return r.Length == 10; })
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Length: {r.Length} | Breadth: {r.Breadth}");

            });
        //Using LINQ ~ SQL in .Net
        var searchedRectangles = from r in rectangles
                                 where r.Length == 10
                                 select r;
        //Display
        searchedRectangles
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ: Rectangle Length X Breadth :: {r.Length} X {r.Breadth}");
            });
        rectangles
            .Where((r) => { return r.Breadth == 3; })
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Length: {r.Length} | Breadth: {r.Breadth}");

            });
        //Using LINQ ~ SQL in .Net
        var searchedRectangles1 = from r in rectangles
                                  where r.Breadth == 3
                                  select r;
        //Display
        searchedRectangles1
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ: Rectangle Length X Breadth :: {r.Length} X {r.Breadth}");
            });
        rectangles
            .Where((r) => { return r.Length == 10 && r.Breadth == 5; })
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Length: {r.Length} | Breadth: {r.Breadth}");

            });
        //Using LINQ ~ SQL in .Net
        var searchedRectangles2 = from r in rectangles
                                  where r.Length == 10 && r.Breadth == 5
                                  select r;
        //Display
        searchedRectangles2
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ: Rectangle Length X Breadth :: {r.Length} X {r.Breadth}");
            });
    }

    private static void SimpleLinq()
    {
        List<string> names = new List<string>();
        names.Add("Meena");
        names.Add("Teena");
        names.Add("Reena");
        names.Add("Reena Chakravarthy");

        names.ForEach((str) =>
        {
            Console.WriteLine(str);
        });

        List<string> result = names.Where((str) =>
        {
            return str == "Reena";
        }).ToList();

        Console.WriteLine("Search for 'Reena'");
        result.ForEach((str) =>
        {
            Console.WriteLine($"Found match for: {str}");
        });

        //LINQ => Language Integrated Query == SQL in .Net
        Console.WriteLine("----USING LINQ ----");
        var queryOutput = (from str in names
                           where str.Contains("Reena") && str.Contains("Chakravarthy")
                           select str)
        .ToList();
        queryOutput.ForEach((str) =>
        {
            Console.WriteLine(str);
        });
    }

    private static void CallDelegates()
    {
        //object or instantiation of delegate
        PM Vimal = new PM((requirement) => { Console.WriteLine("I, Akhila  have attended Tax training"); });
        Vimal += (requirement) => { Console.WriteLine("I, Thejushree have attended Tax training"); };
        Vimal += (requirement) => { Console.WriteLine("I, Sharanya have attended Tax training"); };

        //calling vimal
        //invoking delegate
        Vimal("Tax training for team");
    }

    private static void Sharanya(string requirement)
    {
        Console.WriteLine("I, Sharanya have attended Tax training");
    }

    private static void Thejushree(string requirement)
    {
        Console.WriteLine("I, Thejushree have attended Tax training");
    }

    private static void Akhila(string requirement)
    {
        Console.WriteLine("I, Akhila have attended Tax training");
    }
}
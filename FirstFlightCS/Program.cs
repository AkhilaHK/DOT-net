// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.PortableExecutable;
using Oops;

class Program
{

    static void Main(string[] args)
    {
        //Base = new Derived
        //Derived :Base
        IEmpContract Akhila = new KpmgEmployee();
        Console.WriteLine(Akhila.SickLeavesClause());
        Console.WriteLine(Akhila.WorkHoursClause());

        IEmpContract DellEmployee = new DellEmployee();
        Console.WriteLine($"Sick Leaves clause for DellEmployee: " +
            $"{DellEmployee.SickLeavesClause()}");
        Console.WriteLine($"Work hours clause for DellEmployee: " +
            $"{DellEmployee.WorkHoursClause()}");

    }

    private static void UsingAbstract()
    {
        //Base = new Derived
        Shape sh = new Circle() { Radius = 5 };
        sh.Draw();
    }

    private static void VirtualOverriding()
    {
        Console.WriteLine("--Parent p = new Child()--");
        //base class = new DerivedClass()
        Parent Chin = new Child();// with permission overriding
        Chin.ChooseCareer();//without permission hiding

        Console.WriteLine("--Child ch = new Child()--");
        Child nxgenChild = new Child();
        nxgenChild.NoNightOuts(); // child's function will be called
    }

    private static void UseOverloading()
    {
        Todo myTodo = new Todo()
        {
            Name = "Coding",
            StartDate = DateTime.Now.AddDays(-15),
            EndDate = DateTime.Now.AddDays(15),
            IsCompleted = false
        };
        myTodo.Create(0);
        myTodo.Name = "Angular Training";
        myTodo.StartDate = DateTime.Now.AddDays(-10);
        myTodo.EndDate = DateTime.Now.AddDays(-4);
        myTodo.IsCompleted = true;

        myTodo.Create(1);
        //view all todos
        myTodo.ViewTodos();
        myTodo.ViewTodos("Coding");
    }

    private static void UsingInheritance()
    {
        Rectangle r1 = new Rectangle(20, 5);
        float area = r1.CalculateArea();
        Console.WriteLine($"Area of R1 with length" + $"{r1.Length} and breadth {r1.Breadth} is" + $"{area}");

        Square sq1 = new Square(25);
        area = sq1.CalculateArea();
        Console.WriteLine($"Area of sq1 with length" + $"{sq1.Length} and breadth {sq1.Breadth} is" + $"{area}");
    }

    private static void CallParamsAndNullableTypes()
    {
        var empId = 125024;
        Execute("storedProc", "Name: Akhila");
        Execute("query", "select * from emp", $"where id = {empId}");
        DefaultAndNullable("coding", null);
        DefaultAndNullable("Training", "Angular", true);
        OrderFood();
        var currency = 438953666;
        string str = "100";
        decimal decCurrency = (decimal)currency;
        int num = Convert.ToInt32(str);
    }

    static void Execute(params string[] p1)
    {
        Console.WriteLine("Execution Details: ");
        for (int i = 0; i < p1.Length; i++)
        {
            Console.WriteLine(p1[i]);
        }
    }
    static void DefaultAndNullable(string task, string? details, bool isCompleted = false)
    {
        Console.WriteLine(task);
        Console.WriteLine(details); 
        Console.WriteLine(isCompleted);
    }


    private static void TypeFormatters()
    { 
       
        var intNum = 100;
        var doubleNum = 100d;
        var floatNum = 100f;
        var decimalNum = 100m;
        Console.WriteLine($"Datatype of intNum is: {intNum.GetType().ToString()}");
        Console.WriteLine($"Datatype of doubleNum is:{doubleNum.GetType().ToString()}");
        Console.WriteLine($"Datatype of floatNum is:{floatNum.GetType().ToString()}");
        Console.WriteLine($"Datatype of deciamalNum is:{decimalNum.GetType().ToString()}");

    }

    public static void OrderFood()
    {
        Console.WriteLine($"Enter the food: ");
        var food = Console.ReadLine();
        Console.WriteLine($"Enter the cost of food: ");
       
        double cost = Convert.ToDouble(Console.ReadLine());
        double gst = 18;
        double gst1 = gst + cost;
       
       Console.WriteLine($"Thoe total cost of the food is: { gst1} ");
    }


    private static void UseArithmeticOperations()
    {
        try
        {
            Calculate(100, 20, "Add");
            Calculate(100, 25, "Subtract");
            Calculate(100, 25, "Multiply");
            Calculate(100, 25, "Divide");
            Calculate(100, 25, "Exponent");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Something has gone wrong," + $"Please contact support with this error code: {ex.Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    private static void PrintAndRead()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("this code help is a KOOL feature :-)");
        Console.WriteLine("Enter Something: ");
        var input = Console.ReadLine();
        var input1 = Console.ReadLine();
        var input2 = Console.ReadLine();

        Console.WriteLine("The person's name is " + input + "Lives in " + input1 + "Hobbies are " + input2);


        Console.WriteLine(input);
        Console.WriteLine("The user value entered is: " + input);
        Console.WriteLine("Improvised Concatenation: {0}", input); //dotnet old version
        Console.WriteLine($"Latest technique of concatenation: {input}"); // dotnet latest

    }
    public static void Calculate(int num1, int num2, string operationType)
    {
        //take 2 num from user
        //take which operation to perform from user
        //use switch case and write the code for all arithmetic operations

        switch (operationType)
        {
            case "Add":
                Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
                break;

            case "Subtract":
                Console.WriteLine($"The sum of {num1} and {num2} is {num1 - num2}");
                break;

            case "Multiply":
                Console.WriteLine($"The sum of {num1} and {num2} is {num1 * num2}");
                break;

            case "Divide":
                Console.WriteLine($"The sum of {num1} and {num2} is {num1 / num2}");
                break;

            default:
                throw new Exception("ERR - 404!!");

        }
    }
}

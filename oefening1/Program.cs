class Test1
{
    static void Main(string[] args)
    {
        start();
    }
    static void start()
    {
        Console.WriteLine("Calculator active do you wish to use it? (y/n) ");
        string? input = Console.ReadLine();
        if (input == "y")
        {
            Calculate();
        }
        else
        {
            Console.WriteLine("Calculator destruction is startng");
        }
    }
    static void cont(){
        Console.WriteLine("do you wish to continue using the calculator y/n");
        string? ask = Console.ReadLine();
        if (ask == "y")
        {
            Calculate();
        }
        else if (ask == "n")
        {
            Console.WriteLine("calculator clodsed");
        }
      
        
    }
    static void Calculate()
    {
         int a =0;
        int b = 0;
        int answer = 0;
        Console.WriteLine("Enter the first number:");
        a= int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the second number:");
        b= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the operation (+, -, *, /):");
        string? operation = Console.ReadLine();
        if (operation == "+")
        {
            answer += a+b;
            
            Console.WriteLine("the result is: "+ answer);
            cont();
        }
        else if (operation == "/")
        {
            answer =  a/b;
            Console.WriteLine("the result is: "+ answer);
            cont();
        }
        else if (operation == "-")
        {
            answer = a-b;
            Console.WriteLine("the result is: "+ answer);
            cont();
        }
        else
        {
            answer = a*b;
            Console.WriteLine("the result is: "+ answer);
            cont();
        }
        
    }

    } 


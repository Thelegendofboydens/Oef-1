

class Test1
{
    static void Main(string[] args)
    {
        start();
    }
    static void start()
    {
        Console.WriteLine("type C for calculator and D for Dice thrower type anything else to quit the program ");
        string? input = Console.ReadLine();
        if (input == "C")
        {
            Calculate();
        }
        
        else if (input == "D")
        {
            DiceThrower();
        }
        else
        {
            Console.WriteLine("program shutdown");
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

    static void DiceThrower()
    {
        int totalDice = 0;
        Console.WriteLine("How many dice do you  want to throw");
        int amount = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i =0 ; i<amount; i++)
        {
            int dice1 = rnd.Next(1,7);
            Console.WriteLine("dice " + i +"has rolled "+ dice1);
            totalDice += dice1;
        }
        Console.WriteLine("the total amount is: " + totalDice);
        start();
        
    }
    } 


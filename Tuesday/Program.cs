using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number:");
        double x = Convert.ToDouble(Console.Readline());
        Console.Write("Enter second number:");
        double y = Convert.ToDouble(Console.Readline());
        Console.Write("Choose your arethmetic symbol('+','-','/','*'):" + symbol);
        string symbol = Console.ReadLine();
        
        
         double result = 0.0;


        if (symbol = '+')
        {
            add(x, y);
        }
        else if (symbol = '-')
        {
            Subtract(x, y);
        }
        else if (symbol ='*')
        {
            Multiply(x, y);
        }
        else if (symbol = '/')
        {
            Divide(x, y);
        }

        static double add(double x, double y) 
        {
            Console.Write("Enter first number:");
            

            return x + y;


        }

        static double Multiply(double x, double y)
        {



            return x * y;


        }
        static double Divide(double x, double y)
        {
            

             
            return x / y;


        }

        static double Subtract(double x, double y)
        {
            
            

            return x - y;


        }


    } 
}

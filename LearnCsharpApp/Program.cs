// See https://aka.ms/new-console-template for more information
using System.Data;

class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solver();
    }

    public int Solver()
    {
        Console.WriteLine("Enter two numbers: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32((Console.ReadLine()));
        int sum = number + number2;
        int diff = number2 - number;
        int quotient = number2 / number;
        int product = number * number2;
        int remainder = number % number2;
        Console.WriteLine("Enter an operator: ");
        string operate = Console.ReadLine();

        if (operate == "*")
        {
            Console.WriteLine("Answer: "+  product);
        }
        else if (operate == "+")
        {
            Console.WriteLine("Answer: "+  sum);
        }
        else if (operate == "-")
        {
            Console.WriteLine("Answer: "+ diff);
        }
        else if (operate == "/")
        {
            Console.WriteLine("Answer: "+ quotient);
        }
        else if (operate == "%")
        {
            Console.WriteLine("Answer: "+ remainder);
        }
        else
        {
            Console.WriteLine("Invalid Operator");
        }

        return Solver();
        


        
    }
}

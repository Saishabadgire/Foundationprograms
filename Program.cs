using System;

namespace assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lintA, lintB, lintC;

            Console.WriteLine("ENTER VALUE FOR a");
            lintA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER VALUE FOR b");
            lintB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER VALUE FOR c");
            lintC = Convert.ToInt32(Console.ReadLine());


            int lintsum = class1.ADD(lintA, lintB);
            lintsum = class1.ADD(lintsum, lintC);
            Console.WriteLine("Addition =" + lintsum);

            int lintSub = class1.Subtract(lintA, lintB);
            Console.WriteLine("Subtraction =" + lintSub);

            float lintDivision = class1.Division(lintA, lintB);
            Console.WriteLine("DEVISION =" + lintDivision);

            int lintMultiply = class1.Multiply(lintA, lintB);
            Console.WriteLine("MULTIPLICATION =" + lintMultiply);

            // lintmultiply = class1.Multiply(lintmultiply, lintC);
            int lintmod = class1.mod(lintA, lintB);
            Console.WriteLine("mod =" + lintmod);

            int lintAverage = class1.Average(lintA, lintB, lintC);
            Console.WriteLine("Average =" + lintAverage);

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            long factorial = class1.FactorialIterative(number);
            Console.WriteLine($"Factorial of {number} is {factorial}");

           
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (class1.IsPrime(num))
                Console.WriteLine($"{num} is a prime number.");
            else
                Console.WriteLine($"{num} is not a prime number.");

            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = num1;

            if (num2 > max)
                max = num2;
            if (num3 > max)
                max = num3;

            Console.WriteLine($"The maximum number is {max}");


            Console.Write("Enter a number (1-7): ");
            int input = int.Parse(Console.ReadLine());

            string dayName = class1.Day(input);
            Console.WriteLine($"Day: {dayName}");





        }
    }
}

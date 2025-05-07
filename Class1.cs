using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class class1
    {
        public static int Subtract(int aintA, int aintB)
        {
            return aintB - aintA;
        }

        public static int ADD(int aintA, int aintB)
        {
            return aintB + aintA;
        }

        public static float Division(float aintA, float aintB)
        {
            float leftReasult = aintA / aintB;
            return leftReasult;
        }

        public static int Multiply(int aintA, int aintB)
        {
            return aintA * aintB;
        }

        public static int mod(int aintA, int aintB)
        {
            return aintB % aintA;
        }

        public static int Average(int aintA, int aintB, int aintC)
        {
            return aintB + aintA + aintC / 3;
        }

        public static long FactorialIterative(int aintn)
        {
            long result = 1;
            for (int i = 2; i <= aintn; i++)
            {
                result *= i;
            }
            return result;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            int boundary = (int)Math.Sqrt(number);
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }






        public static string Day(int date)
        {
            switch (date)
            {
                case 1: return "Sunday";
                case 2: return "Monday";
                case 3: return "Tuesday";
                case 4: return "Wednesday";
                case 5: return "Thursday";
                case 6: return "Friday";
                case 7: return "Saturday";
                default: return "Invalid day number";
            }

        }

        }
    }


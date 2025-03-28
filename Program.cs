using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion Tasks in C#");
            Console.WriteLine("Write a recursive function to calculate the factorial of a number n.");
            int n = 5;
            Console.WriteLine("Factorial(" + n + ") -> " + nFactorial(n));
            Console.WriteLine("Write a recursive function to find the nth Fibonacci number.");
            n = 6;
            Console.WriteLine("Fibonaaci(" + n + ") -> " + nthFibonaaci(n));
            Console.WriteLine("Write a recursive function to compute the sum of digits of a number.");
            n = 123;
            Console.WriteLine("SumOfDigits(" + n + ") -> " + sumOfDigits(n));
            Console.WriteLine("Write a recursive function to reverse a given string.");
            string s = "hello";
            Console.WriteLine("Reverse(" + s + ") -> " + reverseString(s.ToArray(), 0, s.Length));
            Console.WriteLine("Write a recursive function to calculate x^y (x raised to power y).");
            n = 2; int exponent = 3;
            Console.WriteLine("Power(" + n +"," + exponent + ") -> " + powX(n, exponent));
            Console.ReadLine();
        }

        //Write a recursive function to calculate the factorial of a number n.
        static int nFactorial(int n)
        {
            if (n == 1) { return 1; }
            return n * nFactorial(n - 1);
        }

        //Write a recursive function to find the nth Fibonacci number.
        static int nthFibonaaci(int n)
        {
            if (n == 0) { return 0; }
            if (n == 1) { return 1; } 
            return nthFibonaaci(n - 1) + nthFibonaaci(n-2);
        }

        //Write a recursive function to compute the sum of digits of a number.
        static int sumOfDigits(int n)
        {
            if (n/10 == 0) { return n; }
            int lastDigit = n % 10;
            return lastDigit + sumOfDigits(n / 10);
        }

        //Write a recursive function to reverse a given string.
        static string reverseString(char[] s, int index, int length)
        {
            if (index == length/2)
            {
                return new string(s);
            }
            var temp = s[index];
            s[index] = s[length - index - 1];
            s[length - index - 1] = temp;
            return reverseString(s, index + 1, length);
        }

        //Write a recursive function to calculate x^y(x raised to power y).
        static int powX(int n, int exponent)
        {
            if (n == 0)
            {
                return 0;
            }
            if (exponent == 0) { return 1; }
            return n * powX(n, exponent-1);
        }


    }
}

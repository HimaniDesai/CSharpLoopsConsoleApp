using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Print numbers 1 to 10");
            PrintNumbersOneToTen();
            Console.WriteLine("2. Print even numbers from 1 to 20");
            PrintNumbersOneToTwentyEven();
            Console.WriteLine("3. Print odd numbers from 1 to 20");
            PrintNumbersOneToTwentyOdd();
            Console.WriteLine("4. Calculate the sum of numbers from 1 to N");
            Console.WriteLine("Sum of first 20 numbers: " + (CalculateSumOfN(20)));
            Console.WriteLine("5. Find the factorial of a number");
            Console.WriteLine("Factorial of 6: " + (nFactorial(6)));
            Console.WriteLine("6. Print the multiplication table of a number");
            Console.WriteLine("Multiplication table of 3: ");
            multiplicationTable(3);
            Console.WriteLine("7. Reverse a number using a loop");
            Console.WriteLine("Reverse of 31245: " + reverseNumber(31245));
            Console.WriteLine("8. Check if a number is prime");
            Console.WriteLine("Is 8 prime: " + (isPrime(8)));
            Console.WriteLine("Is 3 prime: " + (isPrime(3)));
            Console.WriteLine("9. Print Fibonacci series up to N terms");
            Console.WriteLine("Fibonaaci series till 9 terms: " + (nFibonaaci(9)));
            Console.WriteLine("10. Find the sum of digits of a number");
            Console.WriteLine("Sum of digits of 31245: " + sumOfDigits(31245));
            Console.ReadLine();
        }
        //1. Print numbers 1 to 10
        public static void PrintNumbersOneToTen() 
        { 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1);
            }
            //Console.ReadLine();
        }

        //2. Print even numbers from 1 to 20
        public static void PrintNumbersOneToTwentyEven()
        {
            for (int i = 0; i < 20; i++)
            {
                if ((i+1)%2 == 0)
                {
                    Console.WriteLine(i + 1);
                }
            }
            //Console.ReadLine();
        }

        //3. Print odd numbers from 1 to 20
        public static void PrintNumbersOneToTwentyOdd()
        {
            for (int i = 0; i < 20; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    Console.WriteLine(i + 1);
                }
            }
            //Console.ReadLine();
        }

        //4. Calculate the sum of numbers from 1 to N
        public static int CalculateSumOfN(int n)
        {
            int total = 0;
            for (int i = 0;i < n; i++)
            {
                total += (i + 1);
            }
            return total;
        }

        //5. Find the factorial of a number
        public static int nFactorial(int n)
        {
            int total = 1;
            for (int i = 0; i < n; i++)
            {
                total *= (i + 1);
            }
            return total;
        }

        //6. Print the multiplication table of a number
        public static void multiplicationTable(int n)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(n + "x" + (i + 1) + "=" + (n*(i+1)));
            }
            //Console.ReadLine();
        }

        //7. Reverse a number using a loop
        public static int reverseNumber(int n)
        {
            int reverse = 0;
            while ( n !=0 )
            {
                int temp = n % 10;
                reverse = reverse* 10 + temp;
                n = n/10;
            }
            return reverse;
        }

        //8. Check if a number is prime
        public static bool isPrime(int n)
        {
            bool prime = true;
            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n% i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }

        //9. Print Fibonacci series up to N terms
        public static string nFibonaaci(int n)
        {   
            if (n == 1)
            {
                return "0";
            }
            if (n > 2)
            {
                int a = 0;
                int b = 1;
                string terms = "0,1";
                for (int i = 0; i < n; i++)
                {
                    int temp = a + b;
                    terms += "," + temp;
                    a=b; b = temp;
                }
                return terms;
            }
            return null;

        }
        //10. Find the sum of digits of a number
        public static int sumOfDigits(int n)
        {
            int total = 0;
            while (n != 0)
            {
                int temp = n % 10;
                total = total + temp;
                n = n / 10;
            }
            return total;
        }
    }
}

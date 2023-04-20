using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        PrintFibonacciNumbers(n);
    }

   

    static void PrintFibonacciNumbers(int n)
    {
        int i = 0;
        while (true)
        {
            int fib = Fibonacci(i);
            if (fib > n)
            {
                break;
            }
            Console.Write(fib + " ");
            i++;
        }
    }


    static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

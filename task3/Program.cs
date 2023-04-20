using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;

        Console.Write(a);

        while (b <= n)
        {
            Console.Write(" " + b);
            int temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine();
    }
}

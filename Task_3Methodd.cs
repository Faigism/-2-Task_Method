using System;
using System.Diagnostics.CodeAnalysis;

namespace Task_1metod
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            var result = Sums(2412);
            Console.WriteLine(result);
        }
        static int Sums(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                var lastdigit = n % 10;
                sum += lastdigit;
                n = (n - lastdigit) / 10;
            }
            return sum;
        }
        
        

    }
}

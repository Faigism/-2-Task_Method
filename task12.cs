using System;
using System.Linq;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod?
            Smallnum();
        }
        static void Smallnum()
        {
            int[] n = { 2, 30, 1, 3, 34, 12, 50 };
            Console.WriteLine(n.Min());
        }
        
        

    }
}

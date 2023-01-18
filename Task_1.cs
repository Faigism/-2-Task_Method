using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Task_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_1
            //-Verilmiş N tam ədədinin rəqəmləri cəmini tapan metod?
            int n = 982;
            int sum = 0;
            while (n>0)
            {
                var lastdigit = n % 10;
                sum+= lastdigit;
                n = (n - lastdigit) / 10;
            }
            Console.WriteLine(sum);
            #endregion
            
        }
    }
}

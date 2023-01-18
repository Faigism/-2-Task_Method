using System;

namespace Task_2Method
{
    internal class Program
    {
        static void Main(string[] args)
        #region MyRegion
        {
            var result = avgsumnum(20, 50);
            Console.WriteLine(result);
        }
        static int avgsumnum(int m, int n)
        {
            int sum = 0;
            int count = 0;
            for (int i = m; i < n; i++)
            {
                if (i % 21 == 0)
                {
                    count++;
                    sum += i;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Bolunmur");
            }
            else
            {
                return (sum / count);
            }
            #endregion
            
            
        }
    }
}

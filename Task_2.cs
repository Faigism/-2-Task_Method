using System;
using System.Threading;

namespace Task_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_2
            //-Verilmiş M dəyərindən verilmiş N dəyərinədək 21 - ə bölünən ədədlərin ədədi ortasını tapan metod?
            int m = 20;
            int n = 50;
            int sum = 0;
            double count = 0;
            for (int i = m; i < n; i++)
            {
                if (i%21==0)
                {
                    count++;
                    sum += i;
                }
            }
            if (count==0)
            {
                Console.WriteLine("Bolunmur");
            }
            else
            {
                Console.WriteLine(sum/count);
            }
            #endregion

        }
    }
}

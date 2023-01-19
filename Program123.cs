using System;

namespace _3_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-Verilmiş yazıda rəqəm olub olmadığını tapan metod?
            var result = Numb("fascx");
            Console.WriteLine(result);
        }
        static bool Numb(string n)
        {
            bool has_Wanted_Int = false;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '0' || n[i] == '1' || n[i] == '2' || n[i] == '3' || n[i] == '4' || n[i] == '5' || n[i] == 6 || n[i] == '7' || n[i] == '8' || n[i] == '9')
                {
                    return true;
                }
            }
            return has_Wanted_Int;
            
        }
    }
}

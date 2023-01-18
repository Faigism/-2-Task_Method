using System;
using System.Xml.Linq;

namespace Task_3Metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Char("Hello");
            Console.WriteLine(result);
        }
        static bool Char(string n)
        {
            bool has_wanted_char = false;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == 'a')
                {
                    has_wanted_char = true;
                    break;
                }return true;
            }
            if (has_wanted_char == false)
            {
                return false;
            }
            
            else
            {
                return true;
            }
        }
    }
}

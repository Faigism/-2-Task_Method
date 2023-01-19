using System;
using System.Diagnostics.Tracing;

namespace _3_.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş yazını əksinə çevirən metod (misalçün metoda "salam" göndərsəniz metod geriyə "malas" return etməlidir)

            Show("S", "a", "l", "a", "m");
        }
        static void Show(string str1,string str2,string str3,string str4,string str5)
        {
            Console.WriteLine(str5+str4+str3+str2+str1);
        }

    }
}

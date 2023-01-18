using System;

namespace Task_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_4
            //-Verilmis yazıda a herfi olub olmadigini tapan metod?

            Console.WriteLine("Yazini daxil edin: ");
            string name=Console.ReadLine();
            bool has_wanted_char=false;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i]=='a')
                {
                    has_wanted_char= true;
                    break;
                }
            }
            if (has_wanted_char==false)
            {
                Console.WriteLine("Icinde a herfi yoxdur");
            }
            else
            {
                Console.WriteLine("Icinde a herfi var");
            }

            #endregion
        }
    }
}

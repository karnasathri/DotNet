using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class Palindrome_String
    {

        static void Main()
        {
            string str = "malayalam";

            int min = 0, max = str.Length - 1;
            Boolean pali = true;

            while (pali)
            {
                char x = str[min];
                char y = str[max];
                if(char.ToLower(x) != char.ToLower(y))
                {
                    pali = false;
                }
                min++;
                max++;
            }
            if(pali == true)
            {
                Console.WriteLine("This ia a Pallidrom");
            }
            else
            {
                Console.WriteLine("This is not a pallidrom");
                Console.ReadLine();
            }
        }
    }
}

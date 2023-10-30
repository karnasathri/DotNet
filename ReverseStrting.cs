using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class ReverseStrting
    {
        static void Main()
        {
            string str = "KarnaSatHri0501@gmail.com";
            int alpha = 0, digit = 0, special = 0, i = 0;

            while (i<str.Length)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alpha++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    special++;
                }
                i++;
            }
            Console.WriteLine(alpha);
            Console.WriteLine(digit);
            Console.WriteLine(special);
            Console.ReadLine();
        }
    }
}

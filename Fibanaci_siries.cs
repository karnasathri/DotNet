using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class Fibanaci_siries
    {
        static void Main()
        {
            int f = 0, f1 = 1, f2;

            for (int i = 1; i <= 10; i++)
            {
                f2 = f + f1;
                Console.WriteLine(f2 + " ");
                //System.out.print(f2 + " ");
                f = f1;
                f1 = f2;
                Console.ReadLine();
            }
        }
    }
}

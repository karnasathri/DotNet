using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
     class MethodParamiters : ArrayParamiters
    {
       static void Main()
        {
            //int x = 20;

            //Demomethod(x);
            ////int x = 20;
            //Demomethod(x);
            //Console.WriteLine(x);
            //Console.ReadLine();
            int totalsum, totalproduct;
            Demomethod2(4, 6, out totalsum, out totalproduct);
            Console.WriteLine(totalproduct);
            Console.WriteLine(totalsum);
            Console.ReadLine();
        }
        public static void Demomethod(int x)
        {
            x = 30;

        }
        public static void Demomethod2(int x, int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;

        }
    }
}

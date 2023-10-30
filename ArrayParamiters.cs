using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
     class   ArrayParamiters
    {
        static void Main(string[] args)
        {
            int[] EvenNumbers = new int[3];
            EvenNumbers[0] = 20;
            EvenNumbers[1] = 22;
            EvenNumbers[2] = 24;

            ParamsDemo(101,102,103);
        }
        public static void ParamsDemo(params int[] ListEvenNumbers)
        {
            foreach (int i in ListEvenNumbers)
            {
                Console.WriteLine(i);
               //Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

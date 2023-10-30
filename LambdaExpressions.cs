using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MethodHiding.AnnanimouseMethods;

namespace MethodHiding
{
    class LambdaExpressions
    {
        //public static string Greetings(string name)
        //{
        //    return "Hello " + name + " a very good morning";
        //}
        static void Main()
        {
            GreetingsDelegates obj = (name) =>
            {
                return "Hello " + name + " a very good morning";
            };
            string str = obj.Invoke("Karna");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}

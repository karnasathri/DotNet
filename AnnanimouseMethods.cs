using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class AnnanimouseMethods
    {
        public delegate string GreetingsDelegates(string name);

        static void Main()
        {
            GreetingsDelegates obj = delegate (string name)
            {
                return "Hello " + name + " very good morning!";
            };
            string str = obj.Invoke("Karna");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}

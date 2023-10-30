using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class GenaricDelegates
    {

        static void Main()
        {
            Func<int, float, double, double> obj1 = (x, y, z) =>x + y + z; 
            double result = obj1.Invoke(100, 34.5f, 193.465);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x, y, z) => Console.WriteLine(x + y + z);
            obj2.Invoke(100, 34.5f, 193.465);

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool status = obj3.Invoke("Hello World ");
            Console.WriteLine(status);

            Console.ReadLine();
        }
    }
}

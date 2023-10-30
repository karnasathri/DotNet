using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
     interface ITestinterface1
    {
        void Add(int a, int b);
    }
    interface ITestinterface2:ITestinterface1
    {
        void Sub(int a, int b);
    }
    class Implimenting : ITestinterface2 
    { 
        
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main()
        {
            Implimenting obj = new Implimenting();
            ITestinterface2 i = obj;
            obj.Add(100, 30); obj.Sub(50, 20);
            Console.ReadLine();
        }
    }

}

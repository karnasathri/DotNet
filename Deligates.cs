using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    //Step 1:Defining a delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    class Deligates
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello" + name;
        }
        static void Main()
        {
            Deligates dl = new Deligates();
            AddDelegate ad = new AddDelegate(dl.AddNums);
            ad.Invoke(100, 20);
            SayDelegate sd = new SayDelegate(Deligates.SayHello);
            string str = sd.Invoke("Karna");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}

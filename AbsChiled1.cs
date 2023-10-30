using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class AbsChiled1 : AbsParent1
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            AbsChiled1 abc = new AbsChiled1();
            AbsParent1 abp = abc;
            abp.Add(50, 100); abp.Sub(100, 50);
            abp.Mul(88, 99); abp.Div(250,50 );
            Console.ReadLine();
        }

    }
}

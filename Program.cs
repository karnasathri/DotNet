using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{

     public class MethodHiding
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }
    public class ParttimeEmployye : MethodHiding
    {
        public void PrintFullName1()
        {
            //base.PrintFullName();
            Console.WriteLine(FirstName + " " + LastName + " -- contractor ");
        }

        public new void PrintFullName()
        {
            base.PrintFullName();
            //Console.WriteLine(FirstName + " " + LastName + " -- contractor 1234 ");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ParttimeEmployye pte = new ParttimeEmployye();
            MethodHiding pte1 = new ParttimeEmployye();
            //pte.PrintFullName();
            pte.FirstName = " Karna";
            pte.LastName = " satri";
            pte.PrintFullName();
            pte.PrintFullName1();
            //((MethodHiding)pte).PrintFullName();
            Console.ReadLine();
        }

    }
    
}

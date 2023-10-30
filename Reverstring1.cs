using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class Reverstring1
    {
        static void Main()
        {
			String str = "Hellokarna";
			String rever = "";
			Console.WriteLine(str.Length);
			//System.out.println(str.length());

			for (int i = str.Length - 1; i >= 0; i--)
			{
				rever = rever + str[i];

			}
			Console.WriteLine("Revercestring: " + rever);
			Console.ReadLine();
			
			//System.out.println("Revercestring :" + rever);
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public enum Days
    {
        
        Monday=1,Tuesday=11,Wednesday=21,Thursday=31,Friday=51,Saturday=61

    }
    internal class TestClass
    {
        public static Days MeetingDate {get; set;} = Days.Monday;
        static void Main()
        {
            //Days d = Days.Tuesday;
            //Console.WriteLine((int)d);
            //foreach (int i in Enum.GetValues(typeof(Days))) 
            //Console.WriteLine(i+":"+ (Days)i);

            //foreach (string s in Enum.GetNames(typeof(Days)))
            //    Console.WriteLine(s);

            //Console.WriteLine(MeetingDate);
            //MeetingDate = Days.Saturday;
            Console.WriteLine(MeetingDate);

            Console.ReadLine();
        }
    }
}

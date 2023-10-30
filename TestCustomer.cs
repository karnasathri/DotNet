using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class TestCustomer
    {
        static void Main() 
        {
            Customer obj = new Customer(101, false, "karna", 5000.00,Cities.Bengalure, "Karnataka");
            Console.WriteLine("Custid:" + obj.Custid);
            //obj.Custid = 121;
            //Console.WriteLine("Custid:" + obj.Custid);
            if (obj.Status == true)
                Console.WriteLine("Customer status : Active");
            else
                Console.WriteLine("Customer status : In-Active");

            Console.WriteLine("Customer Name: " + obj.Cname);
            obj.Cname += " satri";//failed
            Console.WriteLine("Customer Modified Name: " + obj.Cname);
            Console.WriteLine("Customer Balence : " + obj.Balence);
            obj.Balence -= 3000;//failed
            Console.WriteLine("Customer Balence : " + obj.Balence);

            obj.Status = true;
            if (obj.Status == true)
                Console.WriteLine("Customer status : Active");
            else
                Console.WriteLine("Customer status : In-Active");
            obj.Cname += " satri";
            Console.WriteLine("Customer Modified Name: " + obj.Cname);

            obj.Balence -= 3000;
            Console.WriteLine("Customer Balence : " + obj.Balence);
            obj.Balence = obj.Balence - 1600;
            Console.WriteLine("Balence when assighn ment failed: " + obj.Balence);
            obj.Balence = obj.Balence - 1400;
            Console.WriteLine("Balence when assighn ment failed: " + obj.Balence);

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("Current City : " + obj.City);
            obj.City = Cities.Hyderabad;
            Console.WriteLine("Mosifyied  City : " + obj.City);

            Console.WriteLine("Current State : " + obj.State);
            //obj.State = "Telangana";// Invalied, b'coz current class is not a chailed class of customer
            Console.WriteLine("Modified  State : " + obj.State);

            Console.WriteLine(" Country : " + obj.Country);
            Console.ReadLine();
        }
    }
}

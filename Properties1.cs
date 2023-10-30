using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Properties1
    {
        //public double Redius = 12.34;
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    throw new ArgumentException("Name cannot be empty.");
            }
        }
    }
    public class TestCircle
    {
        static void Main()
        {
            Properties1 pr = new Properties1();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class Rectangle
    {
        public delegate void RectDelegate(double Width, double Height);
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of Rectngle : " + Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimiter of Rectangle : " + 2 * ( Width + Height));
        }

        static void Main()
        {
            Rectangle rect = new Rectangle();
            RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter;
            obj.Invoke(12.34, 56.78);
            Console.WriteLine();
            obj.Invoke(47.87, 34.89);

            Console.ReadLine();
        }
    }
}

using System;
namespace Me
{
    struct Mystruct
    {
        int i;
        public Mystruct(int i)
        {
            this.i = i;
        }
        public void Display()
        {
            Console.WriteLine("Method in a struct");
        }
        static void Main()
        {
            Mystruct m1; m1.i = 10;
            m1.Display();

            Mystruct m2 = new Mystruct();
            m2.Display();

            Mystruct m3 = new Mystruct(30);
            m3.Display();
        }
    }
}
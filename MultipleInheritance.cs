﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    interface Interface1
    {
        void Test();
        void Show();
    }
    interface Interface2 
    {
        void Test();
        void Show();
    }
    class MultipleInheritance : Interface2, Interface1
    {
        public void Test() 
        {
            Console.WriteLine("Interface method implemented in chailed class.");
        }
        void Interface1.Show()
        {
            Console.WriteLine("Decliered in Interface2 and Implimented in class.");
        }
        void Interface2.Show()
        {
            Console.WriteLine("Decliered in Interface2 and Implimented in class.");
        }
        static void Main()
        {
            MultipleInheritance obj = new MultipleInheritance();
            obj.Test();
            Interface1 i1 = obj; i1.Show();
            Interface2 i2 = obj; i2.Show();
            Console.ReadLine();
        }
    }
}

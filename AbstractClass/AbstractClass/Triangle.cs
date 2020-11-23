using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Triangle : Shape 
    {
        public override void show()
        {
            Console.WriteLine("We're in triangle..");
        }
    }
}

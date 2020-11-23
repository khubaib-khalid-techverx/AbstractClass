using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Rectangle();
            s.show();
            s = new Triangle();
            s.show();
        }
    }
}

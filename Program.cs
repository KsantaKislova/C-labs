
using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            Console.WriteLine(obj.C);
        }
    }
    class A
    {
        private float a = 10f;
        private float b = 2.5f;

        public float C
        {
            get { return a / ( a - b ); }
            set { a = value; b = value; } 
        }
    }
}
using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            Console.WriteLine(obj.C);
            B obj2 = new B();
            Console.WriteLine(obj2.d);
        }
    }
    class A
    {
        public float a = 10f;
        public float b = 2.5f;

        public float C
        {
            get { return a / (b - a); }
            set { a = value; b = value; }
        }
        public A()
        {
            a = 6.5f;
            b = 8.5f;
        }
        public A(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
    }

    class B : A
    {
        public float d;
        public float c2
        {
            get { return b / a - d; }
            set { a = value; b = value; d = value; }
        }
        public B()
        {
            a = 10f;
            b = 2.5f;
            d = 5f;
        }
        public B (float a, float b, float d):base(a, b)
            {
                this.d = d;
            }
    }
}

using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //A obj = new A(10, 2);
            B obj2 = new B(10,2);
            Console.WriteLine(obj2.c2);
            foreach (float i in obj2.arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
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
        public B(float a, float b, float d) : base(a, b)
        {
            this.d = d;
        }

        public float[] arr;
        public B(float _a, float _b)
        {
            this.a = _a;
            this.b = _b;
            this.d = 0;
            this.arr = new float[(int)this.a];
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.arr[i] = i * this.c2;
            }
        }
    }
}

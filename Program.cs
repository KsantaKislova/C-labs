using System;

/*namespace task4
{
    class Program
    {

        static void Main(string[] args)
        {
            //A obj = new A(10, 2);
            //B obj2 = new B(10, 2);
            //Console.WriteLine(obj2.c2);
            //foreach (float i in obj2.arr)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.ReadLine();


            B obj3 = new B();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(obj3[i, -1] + " ");
                obj3[-1, i] += obj3[i, -1];
            }

            Console.WriteLine();

            CC<string> str = new CC<string>();
            //C<int> val = new C<int>();
            Console.WriteLine(CC.str);
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

        private int[] imyArray = { 1, 1, 1, 1, 1 };
        private int[] imyArray_v2= { 0, 0, 0, 0 , 0};
        

        public int this[int ind1, int ind2] //индексатор
            {
                get
                    {
                        if (ind1 == -1) { return imyArray_v2[ind2]; }
                        else if (ind2 == -1) { return imyArray[ind1]; }
                        else { return imyArray[ind1] + imyArray_v2[ind2]; }
                    }
                set
                    {
                        if (ind1 == -1) { imyArray_v2[ind2] = value; }
                        else if (ind2 == -1) { imyArray[ind1] = value; }
                    }

        }
    }

    public class СC<T>// параметрезированный класс
        {
            //private T[] imyArray = new T[20];
            public static string str = "LoL";
        }
}*/



using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task4
{
    class Program
    {

        public class B
        {
            private int[] m1 = { 0, 1, 2, 3, 4 };
            private int[] m2 = { 5, 6, 7, 8, 9 };

            public int this[int index1, int index2]
            {
                get { return m1[index1]; }
                set { m1[index1] = value; }
            }

        }


        static void Main(string[] args)
        {
            C<string> str_arr = new C<string>();
            C<int> int_arr = new C<int>();

            B example = new B();

            

        }

        public class C<T>
        {
            public static string str = "Hello";
            private T[] tempArray = new T[20];
        }
    }
}


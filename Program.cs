using System;

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


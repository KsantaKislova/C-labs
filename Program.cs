using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //A obj = new A();
            //Console.WriteLine(obj.C);
            //B obj2 = new B();
            //Console.WriteLine(obj2.d);

            B obj3 = new B();
            Console.Write("obj3 = ");
            Console.WriteLine(obj3.a + "," + obj3.b);

            B obj4 = new B();
            Console.Write("obj4 = ");
            Console.WriteLine(obj4.a + "," + obj4.b);

            
            if (obj3)
                Console.WriteLine("Все значения obj3 положительные");
            else
                Console.WriteLine("В obj3 присутствуют отрицательные значения");

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


        public static bool operator false(B obj3)
        {
            if ((obj3.a <= 0) || (obj3.b <= 0) || (obj3.d <= 0))
                return true;
            return false;
        }


        public static bool operator true(B obj3)
        {
            if ((obj3.a > 0) && (obj3.b > 0) && (obj3.d > 0))
                return true;
            return false;
        }

        public static B operator |(B obj3, B obj4)
        {
            if (((obj3.a > 0) || (obj3.b > 0) || (obj3.d > 0))
                | ((obj4.a > 0) || (obj4.b > 0) || (obj4.d > 0)))
                return obj3;
            return obj4;
        }
    }


}


// Все поля объекта obj3 положительны
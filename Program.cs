using System;

namespace task6._1
{
    //class Person : IComparable<Person>
    class Person
    {
        public string lastname;
        public int year;
        public string status;

        public Person()
        {
            this.lastname = "Иванов";
            this.year = 1990;
            this.status = "student";
        }

        public Person(string lastname0, int year0, string status0)
        {
            this.lastname = lastname0;
            this.year = year0;
            this.status = status0;
        }

        public virtual int Info()
        {

            int current = DateTime.Now.Year;
            return (current - this.year);
        }

        public void output()
        {
            Console.WriteLine($"Фамилия: {lastname}", this.lastname);
            Console.WriteLine($"Дата рождения: {year}", this.year);
            Console.WriteLine($"Статус: {status}", this.status);
            Console.WriteLine("Возраст: {0}", this.Info());
        }
    }

    //public interface IComparable
    //{
    //    int CompareTo(object o)
   //     {
   //         Person p = o as Person;
            
   //     }
   // }

    public interface IComparer
    {
        int Compare(object o1, object o2);
    }




    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person(); // конструктор без параметров
            tom.output();
            Person ksa = new Person("Кислова", 1999, "студент");//конструктор с параметрами
            ksa.output();

        }
    }
}

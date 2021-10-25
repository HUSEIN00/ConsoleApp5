/*Халидов Хусейн ПИ-1-19*/
using System;

namespace ConsoleApp5
{
    class Parents
    {
        public string name;
        public int age;
        public int height;

        public Parents(string name, int age, int height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Имя: {name}\nВозраст: {age}\nРост: {height}");
        }
    }
    class Son : Parents
    {
        public string Designer;

        public Son(string name, int age, int height, string Designer) : base(name, age, height)
        {
            this.Designer = Designer;
        }
        public override void Info()
        {
            Console.WriteLine("\nСын: ");
            base.Info();
            Console.WriteLine($"Профессия: {Designer}\n");
        }
    }
    class Doughter : Parents
    {
        public string sing;

        public Doughter(string name, int age, int height, string sing) : base(name , age, height)
        {
            this.sing = sing;
        }

        public override void Info()
        {
            Console.WriteLine($"\nДочь: ");
            base.Info();
            Console.WriteLine($"Профессия: {sing}\n");
        }
    }

    class Cat : Parents
    {
        public string prof;

        public Cat(string name, int age, int height, string prof) : base(name, age, height)
        {
            this.prof = prof;
        }

        public override void Info()
        {
            Console.WriteLine($"\nКотяра");
            base.Info();
            Console.WriteLine($"Профессия: {prof}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parents par = new Parents("Андрей" , 49 , 185);
            par.Info();

            Son s = new Son("Паша", 26, 185, "Web-дизайнер");
            s.Info();

            Doughter j = new Doughter("Наташа", 29, 180, "Певица");
            j.Info();

            Cat с = new Cat("Кошак", 2, 45, "Жить и ленится");
            с.Info();

        }
    }
}

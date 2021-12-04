using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если ваше животное кошка, введите цифру 1.");
            Console.WriteLine("Если ваше животное собака, введите цифру 2.");
            Console.Write("Ваш выбор: ");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите имя животного: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            if (type == 1)
            {
                Cat cat = new Cat(name);
                cat.ShowInfo();
            }
            else if (type == 2)
            {
                Dog dog = new Dog(name);
                dog.ShowInfo();
            }
            else Console.WriteLine("Нужно было выбрать между кошкой и собакой и ввести соответствующую цифру. Попробуйте снова.");
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine("Имя животного: {0}", Name);
            Console.Write("Животное говорит: ");
            Say();
        }
    }
    class Cat : Animal
    {
        public override string Name { get; set; }
        public Cat(string name)
            : base(name)
        {

        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
    class Dog : Animal
    {
        public override string Name { get; set; }
        public Dog(string name)
            : base(name)
        {

        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}

using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog fido = new Dog();
            Puppy puppy = new Puppy();
            Cat cat = new Cat();

            Console.WriteLine("Fido:");
            fido.Eat();
            fido.Bark();
            Console.WriteLine();

            Console.WriteLine("Puppy:");
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            Console.WriteLine();

            Console.WriteLine("Cat:");
            cat.Eat();
            cat.Meow();
        }
    }
}
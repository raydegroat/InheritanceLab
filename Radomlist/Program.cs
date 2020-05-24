using System;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("dog");
            list.Add("cat");
            list.Add("bird");
            list.Add("fish");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Random string was: " + list.RandomString);
            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}

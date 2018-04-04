using System;

namespace fifo_animal_shelter
{
    public class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter testShelter = new AnimalShelter(new Cat() { Name = "kat" }, new Dog() { Name = "Apollo" });

            testShelter.Enqueue(new Node() { Value = new Cat() { Name = "fluffy" } });
            testShelter.Enqueue(new Node() { Value = new Cat() { Name = "kitty" } });
            testShelter.Enqueue(new Node() { Value = new Dog() { Name = "Spot" } });
            testShelter.Enqueue(new Node() { Value = new Cat() { Name = "Tiger" } });
            testShelter.Enqueue(new Node() { Value = new Dog() { Name = "Rover" } });

            Console.WriteLine(testShelter.Dequeue("cat").Name);
            Console.WriteLine(testShelter.Dequeue("dog").Name);
            Console.WriteLine(testShelter.Dequeue("").Name);
            Console.ReadLine();
        }
    }
}

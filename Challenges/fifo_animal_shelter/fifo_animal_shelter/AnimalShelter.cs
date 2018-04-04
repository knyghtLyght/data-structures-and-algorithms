using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class AnimalShelter
    {
        public static Animal BaseCat { get; set; }
        public static Animal BaseDog { get; set; }

        public AnimalShelter(Cat cat, Dog dog)
        {
            BaseCat = cat;
            BaseDog = dog;
        }

        MyQueue catQueue = new MyQueue(new Node { Value = BaseCat });

        MyQueue DogQueue = new MyQueue(new Node { Value = BaseDog });

        public void Enqueue(Node node)
        {
            if (node.Value is Cat)
            {
                catQueue.Enqueue(node);
            }
            else
            {
                DogQueue.Enqueue(node);
            }
        }

        public Animal Dequeue(string pref)
        {
            if (pref == "cat")
            {
                return catQueue.Dequeue().Value;
            }
            else if (pref == "dog")
            {
                return DogQueue.Dequeue().Value;
            }
            else
            {
                Random rand = new Random();
                int choice = rand.Next(0, 1);
                return choice != 0 ? catQueue.Dequeue().Value : DogQueue.Dequeue().Value;
            }
        }

        public Animal Peek(string pref)
        {
            if (pref == "cat")
            {
                return catQueue.Peek().Value;
            }
            else
            {
                return DogQueue.Peek().Value;
            }
        }
    }
}

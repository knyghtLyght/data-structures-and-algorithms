using System;
using TowersOfHanoi;

namespace TowersOfHanoi
{
    public class Program
    {
        static void Main(string[] args)
        {
            int disks = 5;
            MyStack a = new MyStack(new Node() { Value = 5 }) { Name = "A" };
            a.Push(new Node() { Value = 4 });
            a.Push(new Node() { Value = 3 });
            a.Push(new Node() { Value = 2 });
            a.Push(new Node() { Value = 1 });
            a.PrintStack();
            Console.ReadLine();
            MyStack b = new MyStack() { Name = "B" };
            MyStack c = new MyStack() { Name = "C" };

            TowersOfHanoi(disks, a, b, c);
            Console.WriteLine();
            c.PrintStack();
            Console.ReadLine();
        }

        public static void TowersOfHanoi(int n, MyStack fromT, MyStack auxT, MyStack toT)
        {
            if (n == 1) //Exit condition
            {
                //Move disk
                toT.Push(fromT.Pop());
                //Print move
                Console.WriteLine($"Move disk 1 from tower {fromT.Name} to tower {toT.Name}");
                return;
            }
            else
            {
                //Switch towers and call the method again while decrementing n
                TowersOfHanoi(n - 1, fromT, toT, auxT);
                //Move disk
                toT.Push(fromT.Pop());
                //Print move
                Console.WriteLine($"Move disk {n} from tower {fromT.Name} to tower {toT.Name}");
                //Switch towers and call the method again while decrementing n
                TowersOfHanoi(n - 1, auxT, fromT, toT);
            }
        }
    }
}

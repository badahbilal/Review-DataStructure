using System;

namespace Linear_D_S_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack stackTest = new Stack();

            stackTest.Push(1);
            stackTest.Push(2);
            stackTest.Push(3);
            stackTest.Push(4);
            stackTest.Push(5);
            stackTest.Push(6);
            stackTest.Push(7);
            stackTest.Push(8);
            stackTest.Push(9);

            while (!stackTest.isEmpty())
            {
                Console.WriteLine(stackTest.TopValue());
                stackTest.Pop();

            }
        }
    }
}

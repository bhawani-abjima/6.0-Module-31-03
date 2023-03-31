using System;

namespace test
{
    public class SimpleStack<T>
    {
        private readonly T[] _item;
        private int _currentIndex = -1;
        public SimpleStack() => _item = new T[10];
        public int Count => _currentIndex + 1;
        public void Push(T item) => _item[++_currentIndex] = item;
        public T Pop() => _item[--_currentIndex];


    }
    class test
    {
        public static void Main(string[] args)
        {
            var stack = new SimpleStack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;
            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item:{item}");
                sum += item;

            }
            Console.WriteLine($"Sum:{sum}");
            Console.ReadLine();
        }
    }
}
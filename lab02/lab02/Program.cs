using System;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Lesson 2 {DateTime.Now.ToShortDateString()}\n");
            Console.WriteLine("Task 3");
            Tasks.ThirdTask();
            Console.ReadKey();
            Console.Clear();
            Tasks.SecondTask();

        }
    }
}

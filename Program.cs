using System;
using static Controller;

namespace SPZ_Lab_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.CreateMachine("THEFIRST", 100, 100, 100, 100);
        }
    }
}

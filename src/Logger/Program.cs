using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();

            calculator.Divide(5, 0);

            Console.ReadKey();

        }
    }
}

using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calc = new Calculator();
            int result = calc.Add(5, 5);

            Console.WriteLine($"5 + 5 = {result}");
        }
    }

    public class Calculator 
    {
        public int Add(int a, int b) => a + b;
    }
}

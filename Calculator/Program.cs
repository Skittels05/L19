using System;

namespace App;

public class Calculator
{
    public int Add(int a, int b) => a + b;
    
    public int Subtract(int a, int b) => a - b;
    
    public int Multiply(int a, int b) => a * b;
    
    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Делить на ноль нельзя!");
        }
        return (double)a / b;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Калькулятор готов к работе!");
    }
}
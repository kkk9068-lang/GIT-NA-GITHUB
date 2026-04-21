using System;

class Program
{
    static int Square(int x)
    {
        return x * x;
    }

    static void Main()
    {
        Console.Write("Введіть число: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Квадрат числа: {Square(n)}");
    }
}

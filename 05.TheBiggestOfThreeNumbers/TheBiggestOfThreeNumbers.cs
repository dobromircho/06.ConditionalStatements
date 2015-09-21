using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float biggest = a;
        if (b > a)
        {
            biggest = b;
        }
        if (c > b)
        {
            biggest = c;
        }
        Console.WriteLine(biggest);
    }
}
// Write a program that finds the biggest of three numbers.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = b;
        if (a > b)
        {
            b = a;
            a = c;
        }
        Console.WriteLine("{0} {1}" ,a, b);
    }
}
//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space

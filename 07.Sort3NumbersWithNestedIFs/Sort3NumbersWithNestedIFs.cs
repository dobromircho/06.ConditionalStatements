using System;

class Sort3NumbersWithNestedIFs
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        float biggest = 0;
        float middle = 0;
        float smallest = 0;

        if (a >= b && a >= c)
        {
            biggest = a;

            if (b >= c)
            {
                middle = b;
                smallest = c;
            }
            if (c >= b)
            {
                middle = c;
                smallest = b;
            }
        }

        if (b >= c && b >= a)
        {
            biggest = b;

            if (a >= c)
            {
                middle = a;
                smallest = c;
            }
            if (c >= a)
            {
                middle = c;
                smallest = a;
            }
        }

        if (c >= a && c >= b)
        {
            biggest = c;

            if (a >= b)
            {
                middle = a;
                smallest = b;
            }
            if (b >= a)
            {
                middle = b;
                smallest = a;
            }
        }
        Console.WriteLine("{0} {1} {2}", biggest, middle, smallest);
    }
}
// Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality.

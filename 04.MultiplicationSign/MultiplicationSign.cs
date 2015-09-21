using System;

class MultiplicationSign
{
    static void Main()
    {
        int countNegative = 0;
        float a = float.Parse(Console.ReadLine());
        if (a < 0)
        {
            countNegative++;
        }
        float b = float.Parse(Console.ReadLine());
        if (b < 0)
        {
            countNegative++;
        }
        float c = float.Parse(Console.ReadLine());
        if (c < 0)
        {
            countNegative++;
        }
        bool isZero = a == 0 || b == 0 || c == 0;
        if (!isZero && (countNegative == 1 || countNegative == 3))
        {
            Console.WriteLine("-");
        }
        else if (!isZero && (countNegative == 0 || countNegative == 2))
        {
            Console.WriteLine("+");
        }
        else if (isZero)
        {
            Console.WriteLine("0");
        }
    }
}
// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators

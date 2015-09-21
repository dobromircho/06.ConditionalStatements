﻿using System;

class BonusScore
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int multiplier = 0;

        if (number >= 1 && number <= 3)
        {
            multiplier = 10;
        }
        else if (number >= 4 && number <= 6)
        {
            multiplier = 100;
        }
        else if (number >= 7 && number <= 9)
        {
            multiplier = 1000;
        }
        else
        {
            Console.WriteLine("Invalid Score");
        }

        if (multiplier != 0)
        {
            Console.WriteLine("{0}", number * multiplier);
        }
    }
}
/* Write a program that applies bonus score to given score in the range [1…9] by the following rules:
•	If the score is between 1 and 3, the program multiplies it by 10.
•	If the score is between 4 and 6, the program multiplies it by 100.
•	If the score is between 7 and 9, the program multiplies it by 1000.
•	If the score is 0 or more than 9, the program prints “invalid score”.*/


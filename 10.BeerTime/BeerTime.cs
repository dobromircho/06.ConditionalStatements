using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time in format (hh:mm AM/PM): ");
        string inputTime = Console.ReadLine();
        DateTime input;
        bool isCorrectTime = DateTime.TryParse("1.1.1999 " + inputTime, out input);
        if (!isCorrectTime)
        {
            Console.WriteLine("Invalid Time !!!");
            return;
        }
        DateTime minTimeDown = new DateTime(1999, 1, 1, 13, 0, 0);
        DateTime minTimeUp = new DateTime(1999, 1, 1, 23,59, 0);

        DateTime maxTimeDown = new DateTime(1999, 1, 1, 0, 0, 0);
        DateTime maxTimeUp = new DateTime(1999, 1, 1, 3, 0, 0);

        bool isBeerTime = (input <= minTimeUp && input > minTimeDown) || (input >= maxTimeDown && input < maxTimeUp);
        if (isBeerTime)
        {
            Console.WriteLine("BEER TIME !!!");
        }
        else
        {
            Console.WriteLine("Non beer time");
        }
        
    }
}


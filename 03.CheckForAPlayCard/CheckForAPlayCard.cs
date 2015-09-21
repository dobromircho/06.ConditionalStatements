using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        bool isCardSign = false;

        for (int i = 0; i < cards.Length; i++)
        {
            if (input == cards[i])
            {
                isCardSign = true;
            }
        }
        if (isCardSign)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}
// Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

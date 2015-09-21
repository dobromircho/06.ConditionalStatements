using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string choice = (Console.ReadLine());

        switch (choice)
        {
            case "1":
                Console.WriteLine("Please enter a int: ");
                int inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}" , inputInt + 1); break;
            case "2":
                Console.WriteLine("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("{0}", inputDouble + 1); break;
            case "3":
                Console.WriteLine("Please enter a string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine("{0}" , inputString + "*"); break;
            default:
                Console.WriteLine("Invalid choice !!!");
                break;
        }
    }
}
// Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 

using System;

class Programm
{
    static void Main2()
    {
        try
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a numeric value.");
        }
    }
}

using System;

class Program2
{
    static void Main4()
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;

            Console.WriteLine("Result = " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter numbers only.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Some other error occurred.");
            Console.WriteLine(ex.Message);
        }
    }
}

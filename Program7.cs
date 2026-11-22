using System;

class InvalidLoginException : Exception
{
    public InvalidLoginException(string message)
        : base(message)
    {
    }
}

class Program6
{
    static void Main7()
    {
        string correctUsername = "admin";
        string correctPassword = "1234";

        try
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username != correctUsername ||
                password != correctPassword)
            {
                throw new InvalidLoginException(
                    "Invalid username or password.");
            }

            Console.WriteLine("Login successful.");
        }
        catch (InvalidLoginException ex)
        {
            Console.WriteLine("Login failed: " + ex.Message);
        }
    }
}

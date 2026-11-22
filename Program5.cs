using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}

class Program3
{
    static void Main5()
    {
        try
        {
            Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > balance)
            {
                throw new InsufficientBalanceException(
                    "Insufficient balance for withdrawal.");
            }

            balance = balance - amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining Balance = " + balance);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Enter valid numeric values.");
        }
        finally
        {
            Console.WriteLine("ATM transaction completed.");
        }
    }
}

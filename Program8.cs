using System;

class BankInsufficientBalanceException : Exception
{
    public BankInsufficientBalanceException(string message)
        : base(message)
    {
    }
}

class BankAccount
{
    private double balance;

    public BankAccount(double balance)
    {
        this.balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new BankInsufficientBalanceException("Insufficient balance.");
        }

        balance -= amount;

        Console.WriteLine("Withdrawal successful.");
        Console.WriteLine("Remaining Balance = " + balance);
    }
}

class program8
{
    static void Main8()
    {
        try
        {
            BankAccount account = new BankAccount(10000);

            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (BankInsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid amount.");
        }
        finally
        {
            Console.WriteLine("Bank transaction completed.");
        }
    }
}
public class BankAccount
{
    public string AccountHolder { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string holderName, decimal initialBalance)
    {
        AccountHolder = holderName;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Enter a Valid Amount");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Enter a Valid Amount");
        }
    }
}
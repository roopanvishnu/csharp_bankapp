using System;

class Program
{
    static void Main()
    {
        BankAccount[] accounts = new BankAccount[10];
        int accountCounter = 0;
        while (true)
        {
            Console.Write("\n 1. Create a new account \n 2. Access your account \n 3. Exit the Bank \n 4. List All Accounts");
            Console.WriteLine("Enter your Choice: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.Write("Enter account holder name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter your initial balance: ");
                    decimal initialBalance;
                    while (!decimal.TryParse(Console.ReadLine(), out initialBalance) || initialBalance < 0)
                    {
                        Console.WriteLine("Incorrect input");
                    }
                    accounts[accountCounter] = new BankAccount(name, initialBalance);
                    accountCounter++;
                    Console.WriteLine($"Account for {name} created with balance {initialBalance}.");
                    break;
                case "2":
                    Console.Write("Enter your account holder name: ");
                    string accountholder = Console.ReadLine();
                    BankAccount account = null;
                    for (int i = 0; i < accountCounter; i++)
                    {
                        if (accounts[i].AccountHolder == accountholder)
                        {
                            account = accounts[i];
                            break;
                        }
                    }

                    if (account == null)
                    {
                        Console.WriteLine("Account not found");
                        break;
                    }
                    Console.WriteLine($"Welcome, {accountholder}. Your current balance is {account.Balance}.");
                    Console.WriteLine("1. Deposit\n2. Withdraw\n3. Exit");
                    Console.Write("Choose an option: ");
                    string transactionChoice = Console.ReadLine();
                    switch (transactionChoice)
                    {
                        case "1":
                            Console.Write("Enter deposit amount: ");
                            decimal depositAmount;
                            while (!decimal.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
                            {
                                Console.Write("Invalid input. Enter a valid deposit amount: ");
                            }
                            account.Deposit(depositAmount);
                            break;

                        case "2":
                            Console.Write("Enter withdrawal amount: ");
                            decimal withdrawalAmount;
                            while (!decimal.TryParse(Console.ReadLine(), out withdrawalAmount) || withdrawalAmount <= 0)
                            {
                                Console.Write("Invalid input. Enter a valid withdrawal amount: ");
                            }
                            account.Withdraw(withdrawalAmount);
                            break;

                        case "3":
                            Console.WriteLine("Exiting transaction.");
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please choose again.");
                            break;
                    }
                    break;
                case "3":
                    Console.Write("Good byee!");
                    return;
                case "4":
                    Console.Write("All Available accounts! ");
                    if (accountCounter == 0)
                    {
                        Console.Write("There are no accounts available. \n create new account");
                    }
                    else
                    {
                        for (int i = 0; i < accountCounter; i++)
                        {
                            Console.Write($"\n Accounts holders are: {accounts[i].AccountHolder}. , Balance: {accounts[i].Balance}.");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
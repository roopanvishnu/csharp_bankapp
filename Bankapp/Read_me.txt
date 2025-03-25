Banking Console Application (C# OOP Project)
Project Description
This is a simple console-based banking application built in C# using Object-Oriented Programming (OOP) concepts. It allows users to:

Create a bank account with an initial balance

Access an existing account and perform transactions

Deposit and withdraw money (with insufficient balance checks)

List all available accounts

OOP Concepts Used
Encapsulation 🛡️

Balance and AccountHolder are private for modification and can only be changed through class methods (Deposit(), Withdraw()).

Abstraction 🎭

Users interact with Deposit() and Withdraw() without needing to know how balance calculations work internally.

Class & Objects 🏗️

BankAccount class defines account properties and behaviors.

Each user gets a separate object of BankAccount.

Polymorphism 🔄

Deposit() and Withdraw() methods behave differently based on the account object they are called on.

Arrays & Loops 🔁

Stores multiple accounts in an array and iterates to find or list accounts.

How to Run
Compile the C# file (Program.cs) in any C# environment (VS Code, Visual Studio, or terminal).

Run the program and interact using the menu options.

Future Enhancements
Use a List<BankAccount> instead of an array for dynamic storage.

Implement file or database storage for persistent data.

Add unique account numbers instead of using names as identifiers.


using System;

namespace SystemOfBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount("aswdsa", 1000); // Создание пользователя
            Console.WriteLine($"Account {account1.Number.Value} was created for {account1.Owner} with {account1.Balance} initial balance.");
            var account2 = new BankAccount("aswd", 2000); // Создание пользователя
            Console.WriteLine($"Account {account2.Number.Value} was created for {account2.Owner} with {account2.Balance} initial balance.");

            account1.MakeDeposit(100m, DateTime.Now, "asdas"); // 100m - тип decimal, просто 100 - int
            account1.MakeDeposit(20000m, DateTime.Now, "asdas");
            account1.MakeWithdrawal(5000m, DateTime.Now, "sdg");
            Console.WriteLine($"Account {account1.Number.Value} was created for {account1.Owner} with {account1.Balance} initial balance.");
        }
    }
}


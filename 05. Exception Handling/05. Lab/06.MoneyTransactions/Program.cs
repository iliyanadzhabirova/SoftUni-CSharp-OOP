namespace _06.MoneyTransactions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<int,double> bankAccounts = new Dictionary<int, double>();
            string[] accountsInfo = Console.ReadLine().Split(",");
            for (int i = 0; i < accountsInfo.Length; i++)
            {
                string[] accountData = accountsInfo[i].Split("-",StringSplitOptions.RemoveEmptyEntries);
                int accountNumber = int.Parse(accountData[0]);
                double accountMoney = double.Parse(accountData[1]);
                bankAccounts.Add(accountNumber, accountMoney);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] inputArgs = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                    string command = inputArgs[0];
                    int bankAccount = int.Parse(inputArgs[1]);
                    double bankMoney = double.Parse(inputArgs[2]);
                    switch (command)
                    {
                        case "Deposit":
                            bankAccounts[bankAccount] += bankMoney;
                            Console.WriteLine($"Account {bankAccount} has new balance: {bankAccounts[bankAccount]:f2}");
                            break;
                        case "Withdraw":
                            if (bankMoney > bankAccounts[bankAccount])
                            {
                                throw new InvalidOperationException("Insufficient balance!");
                            }
                            else
                            {
                                bankAccounts[bankAccount] -= bankMoney;
                                Console.WriteLine($"Account {bankAccount} has new balance: {bankAccounts[bankAccount]:f2}");
                            }
                            break;
                        default:
                            throw new InvalidOperationException("Invalid command!");
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Invalid account!");
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }

            }
        }
    }
}
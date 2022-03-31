using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount newAccount = new BankAccount();
            bool responseCheck;
            int response;

            do
            {
                Console.WriteLine("Hello, what would you like to do today? Select an option");
                Console.WriteLine("1. Deposit Money\n2. Check Balance\n3. Exit");
                

                do
                {
                    responseCheck = int.TryParse(Console.ReadLine(), out response);
                    if (!responseCheck || response > 3)
                    {
                        Console.WriteLine("Invalid Response");
                        Console.WriteLine("-----------------");
                        Console.WriteLine("1. Deposit Money\n2. Check Balance\n3. Exit");
                    }
                } while (!responseCheck || response > 3);

                bool depositCheck;
                double deposit;

                if (response == 1)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("How much money would you like to deposit?");
                    do
                    {
                        depositCheck = double.TryParse(Console.ReadLine(), out deposit);
                        if (!depositCheck)
                        {
                            Console.WriteLine("Invalid Response");
                            Console.WriteLine("How much money would you like to deposit?");
                        }
                        else if (deposit < 0)
                        {
                            Console.WriteLine("Deposit cannot be less than 0");
                        }
                    } while (!depositCheck || deposit < 0);
                    BankAccount.Deposit(deposit);
                    BankAccount.GetBalance();
                    //Console.WriteLine(BankAccount.GetBalance());
                }

                if (response == 2)
                {
                    Console.WriteLine($"Your current balance is ${BankAccount.GetBalance()}");
                }
            } while (response != 3);
            
            
            


            //var newAccount = new BankAccount();
            //Console.WriteLine(BankAccount.GetBalance());
            //BankAccount.Deposit(100);
            //Console.WriteLine(BankAccount.GetBalance());
        }
    }
}

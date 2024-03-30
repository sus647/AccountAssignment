using System;

namespace opp.object_oriented_project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount account1 = new BankAccount(1000, "checking");
            Console.WriteLine("Account Number: {0}, Balance: {1}, Type: {2}", account1.AccountNumber, account1.Balance, account1.Type);

            account1.Deposit(500);
            account1.Withdraw(200);

            Console.ReadLine(); 
        }
    }

    public class BankAccount
    {
        private static readonly Random random = new Random();

        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public string Type { get; private set; }

        // Constructors
        public BankAccount() : this(0, "checking") { }

        public BankAccount(decimal initialBalance, string accountType)
        {
            this.AccountNumber = RandomAccountNumber();
            this.Balance = initialBalance;
            this.Type = accountType;
        }

        // Methods
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                this.Balance += amount;
                Console.WriteLine("You deposited: ${0}. New balance: ${1}", amount, this.Balance);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (this.Balance >= amount)
                {
                    this.Balance -= amount;
                    Console.WriteLine("Withdrawal amount: ${0}. Your current balance is: ${1}", amount, this.Balance);
                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }

        // Private method to generate random account number
        private int RandomAccountNumber()
        {
            return random.Next(10000000, 99999999);
        }
    }
}

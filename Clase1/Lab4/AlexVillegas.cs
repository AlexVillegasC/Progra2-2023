using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab4
{

    public class BankAccount
    {
        private string accountNumber;
        private double balance;
        private double interestRate;

        public string AccountNumber
        {
            get { return accountNumber; }

            // "AccountNumber" can only be set once and cannot be changed thereafter.
            set
            {
                if (string.IsNullOrEmpty(accountNumber))
                {
                    accountNumber = value;
                }
                else
                {
                    throw new InvalidOperationException("Account number cannot be changed.");
                }
            }
        }

        public double Balance
        {
            get { return balance; }
            
            // "Balance" can be set and retrieved as usual, but if a negative value is attempted to be set, an exception should be thrown.
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be negative.");
                }
                balance = value;
            }
        }

        public double InterestRate
        {
            get { return interestRate; }

            // "InterestRate" can be set and retrieved as usual, but if a negative value is attempted to be set, it should be converted to a positive value before being set.
            set
            {
                if (value < 0)
                {
                    interestRate = -value;
                }
                else
                {
                    interestRate = value;
                }
            }
        }
    }


    internal class AlexVillegas
    {
        public static void Run()
        {
            //Set the account number to "12345"
            //Set the balance to -100 (which should cause an exception)
            //Set the balance to 500
            //Set the interest rate to -0.05 (which should be converted to 0.05)
            //Print out the account number, balance, and interest rate

            BankAccount account = new BankAccount();

            // Set account number
            account.AccountNumber = "12345";

            // Try to set negative balance (should throw exception)
            try
            {
                account.Balance = -100;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Set positive balance
            account.Balance = 500;

            // Set negative interest rate (should be converted to positive)
            account.InterestRate = -0.05;

            // Print account info
            Console.WriteLine("Account Number: {0}", account.AccountNumber);
            Console.WriteLine("Balance: {0}", account.Balance);
            Console.WriteLine("Interest Rate: {0}", account.InterestRate);
        }
    }
}

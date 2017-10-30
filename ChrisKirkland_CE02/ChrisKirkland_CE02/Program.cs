using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisKirkland_CE02
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerName = null;

            //Ask the user for input
            Console.WriteLine("Please choose an option from below.");

            //Validate user input and proceed
            int validation = 0;
            while (validation != 5)
            {
                string userSelection = null;
                do
                {
                    Console.WriteLine("\n1. Create Customer\n2. Create Account\n3. Set Account Balance\n4. Display Account Balance\n5. Exit\n");
                    Console.Write("Please enter the number that corresponds to your selection: ");
                    userSelection = Console.ReadLine();
                }
                while (!(Int32.TryParse(userSelection, out validation) && (validation < 6) && (validation > 0)));

                //If 1 create customer
                if (validation == 1)
                {
                    Console.Write("Please enter the customer's name: ");
                    customerName = Console.ReadLine();
                    Customer cust = new Customer(customerName);
                }

                //If 2 create account
                else if (validation == 2)
                {
                    if (customerName != null)
                    {
                        int verifyAccount;
                        string validateString;
                        do
                        {
                            Console.Write("Please create an account number: ");
                            validateString = Console.ReadLine();
                        }
                        while (!(Int32.TryParse(validateString, out verifyAccount)));
                        CheckingAccount checking = new CheckingAccount(verifyAccount);
                    }
                }

                //If 3 set account balance
                else if (validation == 3)
                {
                    if (customerName != null)
                    {
                        decimal verifyBalance;
                        string validateString;
                        do
                        {
                            Console.Write("Please set the account balance: ");
                            validateString = Console.ReadLine();
                        }
                        while (!(Decimal.TryParse(validateString, out verifyBalance)));
                        CheckingAccount checking = new CheckingAccount(verifyBalance);
                    }
                }

                //If 4 display account balance
                else if (validation == 4)
                {
                    Console.WriteLine($"The balance for {customerName} from account #{CheckingAccount.accountNumber} is: ${CheckingAccount.accountBalance}");
                    Console.WriteLine("Press any key to return to the menu.");
                    Console.ReadKey();
                }

                //If 5 close the application
                else
                {
                    //Application closes
                }

            }

        }

    }
}
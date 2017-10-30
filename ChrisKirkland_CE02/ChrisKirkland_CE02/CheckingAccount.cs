using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisKirkland_CE02
{
    public class CheckingAccount
    {

        decimal accountBalance;
        int accountNumber;

        public CheckingAccount(decimal accountBalance)
        {
            this.accountBalance = accountBalance;
        }

        public CheckingAccount(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public decimal AccountBalance
        {
            get
            {
                return accountBalance;
            }

            set
            {
                accountBalance = value;
            }
        }

        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }

            set
            {
                accountNumber = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisKirkland_CE02
{
    public class Customer
    {

        string customerName;
        CheckingAccount customerAccount;

        public Customer(string customerName)
        {
            this.customerName = customerName;
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public CheckingAccount CustomerAccount
        {
            get
            {
                return customerAccount;
            }

            set
            {
                customerAccount = value;
            }
        }
    }
}

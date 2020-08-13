using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public class PayableProcessor
    {
        private Account salesAccount;
        private Account expensesAccount;

        public PayableProcessor(Account salesAccount, Account expensesAccount)
        {
            SalesAccount = salesAccount;
            ExpensesAccount = expensesAccount;
        }

        public Account SalesAccount
        {
            get
            {
                return salesAccount;
            }
            set
            {
                salesAccount = value;
            }
        }

        public Account ExpensesAccount
        {
            get
            {
                return expensesAccount;
            }
            set
            {
                expensesAccount = value;
            }
        }

        public virtual void Process(List<IPayAble> payables)
        {
            foreach(IPayAble payable in payables)
            {
                switch(payable is Sale)
                {
                    case true:
                        // Withdraw the expense
                        salesAccount.Deposit(payable.GetAmount());
                        // Set IsProcessed to true


                        break;
                    case false:
                        // Withdraw the expense
                        expensesAccount.Withdraw(payable.GetAmount());


                        break;
                }
            }
        }
    }
}
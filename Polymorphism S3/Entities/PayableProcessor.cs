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

        public Account SalesAccount { get; set; }

        public Account ExpensesAccount { get; set; }

        public void Process(List<IPayAble> payables)
        {
            foreach(IPayable payable in payables)
            {
                switch(payable is Sale)
                {
                    case true:
                        // Withdraw the expense
                        salesAccount.Deposit(payable.GetAmount());
                        // Set IsProcessed to true
                        payable.IsProcessed = true;
                        // Stop
                        break;
                    case false:
                        // Withdraw the expense
                        expensesAccount.Withdraw(payable.GetAmount());
                        // Set IsProcessed to true
                        payable.IsProcessed = true;
                        // Stop
                        break;
                }
            }
        }
    }
}
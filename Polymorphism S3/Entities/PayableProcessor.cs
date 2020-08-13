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
            foreach(IPayAble payable in payables)
            {
                salesAccount.Deposit(payable.GetAmount());
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public class PayableProcessor: IPayable
    {
        public PayableProcessor(Account salesAccount, Account expensesAccount)
        {
            SalesAccount = salesAccount;
            ExpensesAccount = expensesAccount;
        }

        public Account SalesAccount { get; set; }

        public Account ExpensesAccount { get; set; }

        public decimal GetAmount()
        {
            throw new NotImplementedException();
        }

        public bool IsProcessed()
        {
            throw new NotImplementedException();
        }

        public static void Process(List<IPayable> payables)
        {
            throw new NotImplementedException();
        }
    }
}

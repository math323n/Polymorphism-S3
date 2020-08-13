using System.Collections.Generic;

namespace Polymorphism_S3.Entities
{
    public class PayableProcessor
    {
        public PayableProcessor(Account salesAccount, Account expensesAccount)
        {
            SalesAccount = salesAccount;
            ExpensesAccount = expensesAccount;
        }

        public Account SalesAccount { get; set; }

        public Account ExpensesAccount { get; set; }

        /// <summary>
        /// Method to process deposit & withdraw to accounts
        /// </summary>
        /// <param name="payables"></param>
        public virtual void Process(List<IPayable> payables)
        {
            
            foreach(IPayable payable in payables)
            {
                // Get amount
                decimal amount = payable.GetAmount();

                if(payable is Sale)
                {
                    // Withdraw the expense
                    SalesAccount.Deposit(amount);         
                }

                else if(payable is Expense)
                {
                    // Withdraw the expense
                    ExpensesAccount.Withdraw(amount);             
                }

                // Set IsProcessed to true
                payable.IsProcessed = true;
            }
          
        }
    }
}
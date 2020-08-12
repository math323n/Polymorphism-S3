using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public abstract class Expense : IPayable
    {
        protected DateTime date;
        protected decimal amount;


        public Expense(DateTime date, decimal amount)
        {
            Date = date;
            Amount = amount;
        }

        protected DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        protected decimal Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public virtual bool IsProcessed()
        {
            throw new NotImplementedException();
        }

        public virtual decimal GetAmount()
        {
            throw new NotImplementedException();
        }
    }
}

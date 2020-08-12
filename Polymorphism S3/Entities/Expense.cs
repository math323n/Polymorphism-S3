﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public class Expense : IPayAble
    {
        protected DateTime date;
        protected decimal amount;


        public Expense(DateTime date, decimal amount)
        {
            Date = date;
            Amount = amount;
        }

        public DateTime Date
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

        public decimal Amount
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
            return amount;
        }
    }
}

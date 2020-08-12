using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public class ServiceSale
    {
        protected decimal amount;

        public ServiceSale(decimal amount)
        {
            Amount = amount;
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
    }
}

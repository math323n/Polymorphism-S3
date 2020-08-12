using System;

namespace Polymorphism_S3.Entities
{
    public class ServiceSale : Sale
    {
        protected decimal amount;

        public ServiceSale(decimal amount, DateTime date, int employeeId)
            :base(date, employeeId)
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
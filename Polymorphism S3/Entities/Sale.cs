using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public abstract class Sale : IPayAble
    {
        protected DateTime date;
        protected int employeeId;

        protected Sale(DateTime date, int employeeId)
        {
            Date = date;
            EmployeeId = employeeId;
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

        public int EmployeeId
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        public abstract decimal GetAmount();

        public virtual bool IsProcessed()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public class Salary : Expense
    {
        protected int employeeId;
        protected int month;
        protected int year;
        protected byte salaryCode;

        protected Salary(int employeeId, int month, int year, byte salaryCode, DateTime date, decimal amount)
            :base(date, amount)
        {
            EmployeeId = employeeId;
            Month = month;
            Year = year;
            SalaryCode = salaryCode;
        }

        protected int EmployeeId
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

        protected int Month
        {
            get
            {
                return month;
            }

            set
            {
                month = value;
            }
        }

        protected int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        protected byte SalaryCode
        {
            get
            {
                return salaryCode;
            }

            set
            {
                salaryCode = value;
            }
        }

        public override decimal GetAmount()
        {
            return salaryCode switch
            {
                9 => 17000,
                8 => 15000,
                4 => 18000,
                3 => 27000,
                2 => 25000,
                _ => 0,
            };
        }

    }
}

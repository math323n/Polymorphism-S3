using System;

namespace Polymorphism_S3.Entities
{
    public class Salary: Expense
    {
        protected int employeeId;
        protected int month;
        protected int year;
        protected byte salaryCode;

        public Salary(int employeeId, int month, int year, byte salaryCode, DateTime date, decimal amount)
            : base(date, amount)
        {
            EmployeeId = employeeId;
            Month = month;
            Year = year;
            SalaryCode = salaryCode;
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

        public int Month
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

        public int Year
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

        public byte SalaryCode
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
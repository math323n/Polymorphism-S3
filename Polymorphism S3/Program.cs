using Polymorphism_S3.Entities;
using System;
using System.Collections.Generic;

namespace Polymorphism_S3
{
    public class Program
    {
        public static void Main()
        {
            /*
            // Make accounts
            Account acc = new Account(0);
            Account exp = new Account(400);

            // make list of interface
            List<IPayable> payAbles = new List<IPayable>() {
               new Salary(1, 1, 2020, 3, DateTime.UtcNow, 2100),
                new ProductSale(new Dictionary<Product, int>() {
                    {
                        new Product("Kaffekop", 1000),
                        5
                    },
                },
                DateTime.UtcNow, 1),
                new ServiceSale(250, DateTime.UtcNow, 1),
            };

            PayableProcessor processor = new PayableProcessor(acc, exp);
            processor.Process(payAbles);
            Console.WriteLine($"Expenses Account: {processor.ExpensesAccount.Balance}");
            Console.WriteLine($"Sales Account: {processor.SalesAccount.Balance}");*/
            TestEqual();
        }

        private static void TestEqual()
        {
            string a1 = "a";
            string a2 = "a";

            string a3 = null;
            string a4 = null;

            if(a3 == a4) Console.WriteLine("1");

            if(a1 == a2) Console.WriteLine("2");

            if(a1.Equals(a2)) Console.WriteLine("3");

            try
            {
                if(a3.Equals(a4)) Console.WriteLine("4");
            }
            catch(System.NullReferenceException e)
            {
                Console.WriteLine(e);
            }

            if(string.Equals(a1, a4)) Console.WriteLine("5");
            if(a1.Equals(a4)) Console.WriteLine("6");
        }
    }
}
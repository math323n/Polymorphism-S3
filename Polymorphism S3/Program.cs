using Polymorphism_S3.Entities;
using System;
using System.Collections.Generic;

namespace Polymorphism_S3
{
    public class Program
    {
        public static void Main()
        {

            Account acc = new Account(200);
            Account exp = new Account(400);

            List<IPayAble> payAbles = new List<IPayAble>() {
               new Salary(1, 1, 2020, 3, DateTime.UtcNow, 27000),
                new ProductSale(new Dictionary<Product, int>() { { new Product("Starship", 5), 5 }, }, DateTime.UtcNow, 1),
                new ServiceSale(250, DateTime.UtcNow, 1),
            };

            PayableProcessor processor = new PayableProcessor(acc, exp);
            processor.Process(payAbles);
            Console.WriteLine($"Expenses Account: {processor.ExpensesAccount.Balance}");
            Console.WriteLine($"Sales Account: {processor.SalesAccount.Balance}");

            

     









        }
    }
}

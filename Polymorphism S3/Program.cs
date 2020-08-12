using Polymorphism_S3.Entities;
using System;
using System.Collections.Generic;

namespace Polymorphism_S3
{
    class Program
    {
        public static void Main()
        {

            Account acc = new Account(200);
            Account exp = new Account(100);

            List<IPayAble> payAbles = new List<IPayAble>() {
               new Expense(new DateTime(1920,1,1), 100),
               new ServiceSale(200 ,new DateTime(1920,1,1), 100)
            };

           PayableProcessor processor = new PayableProcessor(acc, exp);
           processor.Process(payAbles);
        










        }
    }
}

using Polymorphism_S3.Entities;
using System;

namespace Polymorphism_S3
{
    class Program
    {
        static void Main()
        {
            Account acc = new Account(23);
            acc.Deposit(3);
            Console.WriteLine(acc.Balance);
        }
    }
}

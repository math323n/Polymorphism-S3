namespace Polymorphism_S3.Entities
{
    public class Account
    {
        private decimal balance;

        public Account(decimal balance)
        {
            Balance = balance;
        }


        public virtual decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public virtual void Deposit(decimal amount)
        {
            balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            balance -= amount;
        }

    }
}
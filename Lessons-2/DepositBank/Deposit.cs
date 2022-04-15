using System;

namespace DepositBank
{
    public class Deposit
    {
        public Guid Id { get; set; }
        public decimal Balance { get; set; }
        public Type Type { get; set; }

        public Deposit() : this(1, Type.Current)
        {
        }
        public Deposit(decimal balance) : this(balance, Type.Current)
        {
        }
        public Deposit(Type type) : this(1, type)
        {
        }
        public Deposit(decimal balance, Type type)
        {
            CreateId();
            Balance = balance;
            Type = type;
        }

        private void CreateId()
        {
            Id = Guid.NewGuid();
        }
        public bool TransferMoneyFromTheAccount(Deposit deposit, decimal amount)
        {

            if (deposit != null & amount > 0)
            {
                if (deposit.GetCash(amount))
                {
                    SetCash(amount);

                    return true;
                }
            }
            return false;
        }
        public bool GetCash(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;

                return true;
            }
            return false;
        }
        public void SetCash(decimal amount)
        {
            Balance += amount;
        }
        public new void ToString()
        {
            Console.WriteLine($"ID deposit - {Id}");
            Console.WriteLine($"Type deposit - {Type}");
            Console.WriteLine($"Balance deposit - {Balance.ToString("# ### ###.##")}");
        }
    }
}

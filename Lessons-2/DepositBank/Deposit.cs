using System;

namespace DepositBank
{
    public class Deposit
    {
        public Guid Id { get; set; }
        public decimal Balance { get; set; }
        public DepositType Type { get; set; }

        public Deposit() : this(1, DepositType.Current)
        {
        }
        public Deposit(decimal balance) : this(balance, DepositType.Current)
        {
        }
        public Deposit(DepositType type) : this(1, type)
        {
        }
        public Deposit(decimal balance, DepositType type)
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

        public static bool operator ==(Deposit depositA, Deposit depositB)
        {
            if (depositA is null)
            {
                return depositB is null;
            }

            return depositA.Equals(depositB);
        }
        public static bool operator !=(Deposit depositA, Deposit depositB)
        {
            if (depositA is null)
            {
                return true;
            }

            return !depositA.Equals(depositB);
        }
        public override string ToString()
        {
            return $"ID deposit - {Id}\nType deposit - {Type}\nBalance deposit - {Balance.ToString("# ### ###.##")}\n";
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Deposit);
        }
        public bool Equals(Deposit other)
        {
            if (other is null)
            {
                return false;
            }
            return other != null && other.Id == Id
                && other.Balance == Balance
                && other.Type == Type;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Balance, Type);
        }
    }
}

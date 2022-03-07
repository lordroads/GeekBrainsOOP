using System;

namespace DepositBank
{
    public class Deposit
    {
        private Guid _id;
        private decimal _balacne;
        private Type _type;

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
            _balacne = balance;
            _type = type;
        }

        private void CreateId()
        {
            _id = Guid.NewGuid();
        }
        public Guid GetId()
        {
            return _id;
        }
        public decimal GetBalance()
        {
            return _balacne;
        }
        public new Type GetType()
        {
            return _type;
        }
    }
}

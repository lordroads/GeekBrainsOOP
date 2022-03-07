using System;

namespace DepositBank
{
    public class Deposit
    {
        public static Guid id;
        private decimal _balacne;
        private Type _type;
        

        public void CreateId()
        {
            id = Guid.NewGuid();
        }
        public void SetBalacne(decimal balance)
        {
            _balacne = balance;
        }
        public decimal GetBalance()
        {
            return _balacne;
        }
        public void SetType(Type type)
        {
            _type = type;
        }
        public new Type GetType()
        {
            return _type;
        }
    }
}

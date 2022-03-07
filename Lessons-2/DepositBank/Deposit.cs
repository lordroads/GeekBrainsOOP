using System;

namespace DepositBank
{
    public class Deposit
    {
        private Guid _id;
        private decimal _balacne;
        private Type _type;

        public void SetId(Guid guid)
        {
            _id = guid;
        }
        public Guid GetId()
        {
            return _id;
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

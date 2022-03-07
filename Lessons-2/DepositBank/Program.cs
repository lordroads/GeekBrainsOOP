using System;
using System.Text;

namespace DepositBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deposit defaultDeposit = new Deposit();
            Deposit JohnDeposit = new Deposit(Type.Calculated);
            Deposit BenDeposit = new Deposit(1000);
            Deposit StenDeposit = new Deposit(1000000, Type.Deposit);

            defaultDeposit.ToString();
            JohnDeposit.ToString();
            BenDeposit.ToString();
            StenDeposit.ToString();
        }
    }
}

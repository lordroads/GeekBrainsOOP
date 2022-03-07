using System;
using System.Text;

namespace DepositBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deposit deposit = new Deposit();
            deposit.CreateId();
            deposit.SetType(Type.Current);
            deposit.SetBalacne(1000000.05m);

            StringBuilder viewDeposit = new StringBuilder();
            viewDeposit.AppendLine($"ID deposit - {Deposit.id}");
            viewDeposit.AppendLine($"Type deposit - {deposit.GetType()}");
            viewDeposit.AppendLine($"Balance deposit - {deposit.GetBalance().ToString("# ### ###.##")}");

            Console.WriteLine(viewDeposit);
        }
    }
}

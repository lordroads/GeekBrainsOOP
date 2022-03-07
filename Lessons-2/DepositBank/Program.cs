using System;
using System.Text;

namespace DepositBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deposit deposit = new Deposit(100, Type.Calculated);

            StringBuilder viewDeposit = new StringBuilder();
            viewDeposit.AppendLine($"ID deposit - {deposit.GetId()}");
            viewDeposit.AppendLine($"Type deposit - {deposit.GetType()}");
            viewDeposit.AppendLine($"Balance deposit - {deposit.GetBalance().ToString("# ### ###.##")}");

            Console.WriteLine(viewDeposit);
        }
    }
}

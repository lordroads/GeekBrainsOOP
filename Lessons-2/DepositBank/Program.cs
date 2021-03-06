using System;
using System.Text;

namespace DepositBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deposit defaultDeposit = new Deposit();
            Deposit JohnDeposit = new Deposit(DepositType.Calculated);
            Deposit BenDeposit = new Deposit(1000);
            Deposit StenDeposit = new Deposit(1000000, DepositType.Deposit);

            defaultDeposit.ToString();
            JohnDeposit.ToString();
            BenDeposit.ToString();
            StenDeposit.ToString();

            Deposit deposit = new Deposit(1000000);
            Deposit depositForShopping = new Deposit();

            Console.WriteLine();
            //Positive test
            bool transferStatus = depositForShopping.TransferMoneyFromTheAccount(deposit, 500000);
            Console.WriteLine($"Transfer status - {transferStatus}");
            deposit.ToString();
            depositForShopping.ToString();

            Console.WriteLine();
            //Negative test
            transferStatus = depositForShopping.TransferMoneyFromTheAccount(deposit, 500001);
            Console.WriteLine($"Transfer status - {transferStatus}");
            deposit.ToString();
            depositForShopping.ToString();

            //Тесторование сравнений
            Deposit depositA = new Deposit();
            Deposit depositB = new Deposit();
            bool equality = depositA == depositB;   //false
            bool inequality = depositA != depositB; //true
            int hashA = depositA.GetHashCode();
            int hashB = depositB.GetHashCode();
            bool equalityHash = hashA == hashB;     //false
        }
    }
}

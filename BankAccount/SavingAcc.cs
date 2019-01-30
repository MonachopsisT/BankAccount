using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class SavingAcc
    {
        public int accNum;
        public decimal accBalance;
        public int intRate;

        //Account Number
        public SavingAcc()
        {
            Random rand = new Random();
            accNum = rand.Next(0, 100000);

            intRate = rand.Next(0, 100);

            accBalance = rand.Next(0, 999999);
        }

        //public void Intrest()
        //{
        //    Random rand = new Random();
        //    intRate = rand.Next(0, 100);
        //}

        //public void Balance()
        //{
        //    Random rand = new Random();
        //    accBalance = rand.Next(0, 999999);
        //}

        public void PrintSavings()
        {
            Console.WriteLine(" Account Number: {0} \n Intrest Rate: {1} \n Account Balance: {2}",accNum,intRate,accBalance);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class BankAcc
    {
        public string myName;
        public string myAddres;
        public decimal myBalance;

        SavingAcc[] myArrOfSavingAcc = new SavingAcc[2];

        public BankAcc()
        {
            myArrOfSavingAcc[0] = new SavingAcc();
            myArrOfSavingAcc[1] = new SavingAcc();
        }

       public void accName(string name)
        {
            myName = name;
        }

        public void accAddress(string address)
        {
            myAddres = address;
        }

        public void accBalance(decimal balance)
        {
            myBalance = balance;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Detalis of the Bank account\n Account name: {0} \n Account Address: {1} \n Account balance: {2}", myName,myAddres,myBalance);
            Console.WriteLine();

            Console.WriteLine("Saving Account Details");
            Console.WriteLine();

            for(int j = 0; j < myArrOfSavingAcc.Length; j++)
            {
                myArrOfSavingAcc[j].PrintSavings();
                Console.WriteLine();
            }
        }
    }
}

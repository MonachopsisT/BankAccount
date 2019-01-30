using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc acc1 = new BankAcc();
            acc1.accName("Whatever");
            acc1.accAddress("Somewhere");
            acc1.accBalance(200000.2m);

            acc1.PrintDetails();
            Console.WriteLine( );

            Console.ReadLine();

        }
    }
}

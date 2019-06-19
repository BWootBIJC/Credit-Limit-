using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class CreditLimit
    {
        static void Main(string[] args)
        {
            int accountNum;
            double begBalance, charge, credit, credLimit;
            double newBalance;
            

            Console.Write("Enter the account number:");
            accountNum = int.Parse(Console.ReadLine());

            Console.Write("Enter the balance: $");
            begBalance = double.Parse(Console.ReadLine());

            Console.Write("Enter the charge: $");
            charge = double.Parse(Console.ReadLine());

            Console.Write("Credit: $");
            credit = double.Parse(Console.ReadLine());

            Console.Write("Enter the Credit Limit: $");
            credLimit = double.Parse(Console.ReadLine());


            newBalance = (begBalance + charge) - credit;
            Console.WriteLine("$" + newBalance);

            if (newBalance > credLimit)
            {
                Console.WriteLine("Your credit has exceeded the credit limit.");
            }
            else if (newBalance < credLimit)
            {
                Console.WriteLine("Your credit has not exceeded the credit limit.");
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();


        }
    }
}

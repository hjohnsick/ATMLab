using System;
using System.Collections.Generic;

namespace ATM_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus ATM");

            List<string> atmOptions = new List<string>
            {
                "\t1.  Register", "\t2.  Login", "\t3.  Logout", "\t4.  Check Balance", "\t5.  Deposit", "\tWithdraw"
            };
            PrintList(atmOptions);
        }

        public static void PrintList(List<string> atmOptions)
        {
            for (int i = 0; i < atmOptions.Count; i++)//have to input the fields from the duties class
            {
                Console.WriteLine();
                Console.WriteLine((i + 1) + ":");
                Console.WriteLine($"\t{atmOptions[i]}");

            }
        }
    }
}


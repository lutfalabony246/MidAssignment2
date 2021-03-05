using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MidAssignment2
{
    class Bank
    {
        private string bankName;
        private static Account[] myBank;
        public static int size;

        public Bank(string bankName, int size = 5)
        {
            Bank.size = size;
            this.bankName = bankName;
            myBank = new Account[size];
        }
        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        /*public Account[] MyBank
        {
            get
            {
                return myBank;
            }
            set
            {
                myBank = value;
            }
        }*/
        public Account[] MyBank
        {
            set { Bank.myBank = value; }
            get { return Bank.myBank; }
        }
        public void PrintAllAccounts()
        {
            Console.WriteLine("-----------------" + BankName + "-----------------");
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].PrintAccount();
            }
            Console.WriteLine("-----------------" + "######" + "-----------------");
        }



        public void AddAccount1(Account account, [Optional] int ammountforwithdrwal)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                // int remainbalance=0;
                if (myBank[i] == null && account.Balance != 0)
                {
                    myBank[i] = account;
                    break;
                }
                // int ammountforwithdrwal = 0;
                if (ammountforwithdrwal >= account.Balance)
                {
                    Console.WriteLine("Sorry!Withdrwal can not be accepted .Your balance can't be 0");
                }
                else
                {
                    account.Balance = account.Balance - ammountforwithdrwal;
                    Console.WriteLine("Your withdrwal is successful!");
                }
            }
        }
        public void AddAccount2(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                // int remainbalance=0;
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }

            }
        }
        /*public void Yy(double amount)
        {
            Console.WriteLine("-----------------" + BankName + "-----------------");
            for (int i = 0; i < myBank.Length; i++)
            {
                
                myBank[i].Deposite(amount);
            }
            Console.WriteLine("-----------------" + "######" + "-----------------");
        }*/
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MidAssignment2
{
	class Account
	{
		private int accountNumber;
		private string accountName;
		private string dateOfBirth;
		private double balance;
		private Address address;
		public Account()
		{
			Console.WriteLine("parameterless");
		}
		public Account( string accountName, string dateOfBirth,  Address addres,double balance, int acn)
		{
			this.accountName = accountName;
			this.balance = balance;
			this.address = addres;
			this.accountNumber = acn;
		}
		public string AccountName
		{
			get { return this.accountName; }
			set { this.accountName = value; }
		}
		public string DateOfBirth
		{
			get { return this.accountName; }
			set { this.accountName = value; }
		}
		public Address Address
		{
			get { return this.address; }
			set { this.address = value; }
		}
		public double Balance
		{
			get { return this.balance; }
			set { this.balance = value; }
		}
		public int AccountNumber
		{
			get { return this.accountNumber; }
			set { this.accountNumber = value; }
		}
		public void Deposite(double amount)
		{

			this.balance = this.balance + amount;
			Console.WriteLine("Depisited!!");


		}
		public void Withdraw(double amount)
		{
			if (this.balance >= amount)
			{
				this.balance = this.balance - amount;
				Console.WriteLine("Withdaw Successful");
			}
			else
			{
				Console.WriteLine("Withdaw Not possible");
			}
			// return balance;


		}

		//public void Transfer(Account receiver,double amount)
		public void Transfer(Account receiver, double amount)
		{
			receiver.Deposite(amount);
			this.Withdraw(amount);
			Console.WriteLine("Transfer Successfully Completed");

		}

		public void Show()
		{
			Console.WriteLine("Balance"+ this.Balance);
		}

		public void PrintAccount()
		{

			Console.WriteLine("\nAccount No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
			this.address.PrintAddress();
		}


	}
}

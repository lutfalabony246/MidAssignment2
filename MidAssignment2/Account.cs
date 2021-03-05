using System;
using System.Collections.Generic;
using System.Linq;
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
		public Account(string accountName, string dateOfBirth, Address addres, double balance, int acn)
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
		public void PrintAccount()
		{

			Console.WriteLine("\nAccount No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
			this.address.PrintAddress();
		}


	}
}

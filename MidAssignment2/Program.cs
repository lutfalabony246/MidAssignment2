using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidAssignment2
{
	class Program
	{
		static void Main(string[] args)
		{
			 int AccountNumberGen1(int inc1)
			{
				int start = 999;
				int an = start + inc1;
				return an;
			}
			 int AccountNumberGen2(int inc2)
			{
				int start = 999;
				int an = start + inc2;
				return an;
			}

			bool flag = true;
			int num2;
			int num;
			int num1;
			int num3;
	
			//Console.WriteLine("Bank Limit ");
			//num = Convert.ToInt32(Console.ReadLine());
			Bank ourBank = new Bank("Developer's bank", 5);

			while (flag)
			{
				Console.WriteLine("1) Open a bank account \n2) Perform transiction for an account\n3) exit the application");
				int choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Console.WriteLine("Open a bank account \n1)Savings Account\n2)Checking Account\n3)Quit");
						int choice1 = Convert.ToInt32(Console.ReadLine());
						switch (choice1)
						{
							case 1:
								Console.WriteLine("******SAVINGS ACCOUNT******* ");
								Console.WriteLine("How many accounts do you want to create? ");
								num1 = Convert.ToInt32(Console.ReadLine());
								for (int i = 0; i < num1; i++)
								{
									Console.WriteLine("\nAccount " + (i + 1));
									Console.WriteLine("Name: ");
									string name = Console.ReadLine();
									Console.WriteLine("Date Of Birth: ");
									string dateofbirth = Console.ReadLine();
									Console.WriteLine("House no: ");
									int houseNo = Convert.ToInt32(Console.ReadLine());
									Console.WriteLine("Road no: ");
									int roadNo = Convert.ToInt32(Console.ReadLine());
									Console.WriteLine("City: ");
									string city = Console.ReadLine();
									Console.WriteLine("Country: ");
									string country = Console.ReadLine();
									Console.WriteLine("Ammount: ");
									double ammount = Convert.ToInt32(Console.ReadLine());
									ourBank.AddAccount1(new Account(name, dateofbirth, new Address(houseNo, roadNo, city, country), ammount, AccountNumberGen1(i)));
									ourBank.PrintAllAccounts();
								}
								break;

							case 2:
								Console.WriteLine("******CHECKING ACCOUNT******* ");
								Console.WriteLine("How many accounts do you want to create? ");
								num2 = Convert.ToInt32(Console.ReadLine());
								for (int i = 0; i < num2; i++)
								{
									Console.WriteLine("Name: ");
									string name = Console.ReadLine();
									Console.WriteLine("Date Of Birth: ");
									string dateofbirth = Console.ReadLine();
									Console.WriteLine("House no: ");
									int houseNo = Convert.ToInt32(Console.ReadLine());
									Console.WriteLine("Road no: ");
									int roadNo = Convert.ToInt32(Console.ReadLine());
									Console.WriteLine("City: ");
									string city = Console.ReadLine();
									Console.WriteLine("Country: ");
									string country = Console.ReadLine();
									Console.WriteLine("Ammount: ");
									double ammount = Convert.ToInt32(Console.ReadLine());
									ourBank.AddAccount2(new Account(name, dateofbirth, new Address(houseNo, roadNo, city, country), ammount, AccountNumberGen2(i)));
									ourBank.PrintAllAccounts();
								}
								break;
							case 3:
								break;
							default:
								continue;

						}
						break;
					case 2:
						Console.WriteLine("Open a bank account \n1)Deposit\n2)Withdraw\n3)Transfer\n4)Show\n5)Quit");
						int choice2 = Convert.ToInt32(Console.ReadLine());
						switch(choice2)
						{
							case 1:
								/*Console.WriteLine("How much amount you want to deposit?");
								double ammount = Convert.ToInt32(Console.ReadLine());
								//4Account acc = new Account();
								num3 = Convert.ToInt32(Console.ReadLine());
								for (int i = 0; i < num3; i++)
								{
									ourBank.Deposite(ammount);
								}

									/*for (int i = 0; i < ourBank.)
								{
									myBank[i].Deposite(10);

								}*/

								//ourBank.Yy(500.00);
								Console.WriteLine("Please enter  the amount");
								double ammount1 = Convert.ToInt32(Console.ReadLine());
								Account acc = new Account();
								acc.Deposite(ammount1);
								break;
							case 2:
								Console.WriteLine("Please enter  the amount");
								double ammount2 = Convert.ToInt32(Console.ReadLine());
								Account acc1 = new Account();
								acc1.Withdraw(ammount2);
								break;
							case 3:
								Console.WriteLine("Please enter  the account number of receiver");
								int receiveraccount = Convert.ToInt32(Console.ReadLine());
								Console.WriteLine("Please enter  the amount");
								double ammount3 = Convert.ToInt32(Console.ReadLine());
								//Console.WriteLine("Please enter  the amount");
								Account acc2 = new Account();
								acc2.Transfer(receiveraccount, ammount3);
								break;
							case 4:
								//for(int i=0;i<=)
								//==Account acc3 = new Account();
								//,j.j,h/--yewqaF2 ;;
								break;
							case 5:
								
								break;
							default:
								continue;
						}

						break;
					case 3:

						flag = false;
							break;
					default:
						continue;
				}

			}

		}

	}
}

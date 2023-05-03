using System;
namespace AccountDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("*********************************");
                Console.WriteLine("*********ACCOUNT DETAILS*********");
                Console.WriteLine("*********************************");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Display Account Information");
                Console.WriteLine("3. Deposit Amount");
                Console.WriteLine("4. Withdraw Amount");
                Console.WriteLine("5. Check Balance");
                Console.WriteLine("0. Quit");
                Console.WriteLine("Enter your choice:");
                ch = int.Parse(Console.ReadLine());

                switch(ch)
                {
                    case 1: 
                        Console.WriteLine("Enter your id:");
                        int id=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your name:");
                        string name=Console.ReadLine();
                        Console.WriteLine("Enter opening balance:");
                        decimal balance=decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.CreateAccount(id,name,balance);
                        break;
                    case 2:
                        if (a != null)
                        {
                            a.DisplayInfo();
                        }
                        else
                        {
                            Console.WriteLine("***Open Account First***");
                        }
                        break;
                    case 3:
                        if (a != null)
                            a.Deposit(5000);
                        else
                            Console.WriteLine("*** Open Account First ***");
                        break;
                    case 4:
                        if (a != null)
                            a.Withdraw(5000);
                        else
                            Console.WriteLine("*** Open Account First ***");
                        break;
                    case 5:
                        if (a != null)
                        {
                            a.CheckBalance();
                        }
                            
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("*** Wrong Choice ***");
                        break;
                }
            }
            while (ch != 0);
            Console.WriteLine("***Thanks for using the application***");
        }
    }
}

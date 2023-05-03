using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Locker> ls = new List<Locker>();
            Console.WriteLine("Enter the name of the Bank:");
            string bname = Console.ReadLine();
            Bank b = new Bank(bname,ls);
            Locker l = new Locker();
            while (true)
            {
                Console.WriteLine("1. Add Locker");
                Console.WriteLine("2. Delete Locker");
                Console.WriteLine("3. Display Lockers");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the details in csv format");
                        string parts = Console.ReadLine();
                        l = Locker.CreateLocker(parts);
                        b.AddLockerToBank(l);
                        Console.WriteLine("Locker successfully added");
                        break;
                    case 2:
                        Console.WriteLine("Enter the locker number to be deleted");
                        int number = int.Parse(Console.ReadLine());
                        b.RemoveLockerFromBank(number);
                        Console.WriteLine("Locker successfully deleted");
                        break;
                    case 3:
                        b.DisplayLockers();
                        break;
                    case 4:
                        break;
                }
            }
        }
    }
}


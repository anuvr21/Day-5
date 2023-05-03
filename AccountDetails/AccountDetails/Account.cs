using System;
using System.CodeDom;
using System.Xml.Linq;

namespace AccountDetails
{
    class Account
    {
        public int id;
        private string _name;

        public string Name
        {
            set {
                _name = value;
                
                if (value.Length>15) 
                {
                    throw new ApplicationException("Name too long");
                }
                
            }
        }
        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            
        }

        public void CreateAccount(int id, string name, decimal balance)
        {
            this.id = id;
            this._name = name;
            this._balance = balance;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("***** Account Information *****");
            Console.WriteLine("Account Id:" + id);
            Console.WriteLine("Name:" + _name);
            Console.WriteLine("Opening Balance:" + _balance);
        }

        public void Deposit(decimal amount)
        { 
           _balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (_balance - amount < 500)
                throw new ApplicationException("Insufficient Balance");
            else
                this._balance -= amount;
        }
        public void CheckBalance()
        {
            //Console.WriteLine("Your balance is " + _balance);
            _balance += 1000;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Locker
    {
		private int _number;

		public int Number
		{
			get { return _number; }
			set { _number = value; }
		}
		private string _lockType;

		public string LockType
		{
			get { return _lockType; }
			set { _lockType = value; }
		}
		private string _password;

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}
		private double _amount;

		public double Amount
		{
			get { return _amount; }
			set { _amount = value; }
		}
		private DateTime _lastOpened;

		public DateTime LastOpened
		{
			get { return _lastOpened; }
			set { _lastOpened = value; }
		}
		//default constructor
		public Locker()
		{

		}

		//parameterized constructor
		public Locker(int _number, string _lockType, string _password, double _amount, DateTime _lastOpened)
		{
			this._number = _number;
			this._lockType = _lockType;
			this._password = _password;
			this._amount = _amount;
			this._lastOpened = _lastOpened;
		}

        public override string ToString()
        {
            return string.Format("{0,-8} {1,-15} {2,-8} {3,-10:F1} {4:dd-MM-yyyy}", _number, _lockType, _password, _amount, _lastOpened);
        }

        public static Locker CreateLocker(string detail)
        {
            string[] parts = detail.Split(',');
            int number = int.Parse(parts[0].Trim());
            string lockType = parts[1].Trim();
            string password = parts[2].Trim();
            double amount = double.Parse(parts[3].Trim());
            DateTime lastOpened = DateTime.Parse(parts[4].Trim());

            return new Locker(number, lockType, password, amount, lastOpened);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankApplication
{
    public class Bank
    {
        private string _bname;

        public string Bname
        {
            get { return _bname; }
            set { _bname = value; }
        }
        private List<Locker> _lockerList;

        public List<Locker> LockerList
        {
            get { return _lockerList; }
            set { _lockerList = value; }
        }

        public Bank()
        {

        }
        public Bank(string _bname, List<Locker> _lockerList)
        {
            this._bname = _bname;
            this._lockerList = _lockerList;
        }
        public void AddLockerToBank(Locker locker)
        {
            LockerList.Add(locker);
        }

        public bool RemoveLockerFromBank(int number)
        {
            int count = 0;
            foreach (var Item in _lockerList)
            {
                if (Item.Number == number)
                {
                    LockerList.Remove(Item);
                    count++;
                    break;
                }

                if (count == 1)
                {
                    return true;

                }
                
            }            
                return false;           
        }
        public void DisplayLockers()
        {
            if (LockerList.Count == 0)
            {
                Console.WriteLine("No lockers to show");
            }
            else
            {
                foreach (var Item in _lockerList)
                {
                    Console.WriteLine("Lockers in {0}", Bname);
                    Console.WriteLine(Item.ToString());
                }
            }

        }
    }
}

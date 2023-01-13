using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBank1
{
    public class Checking
    {
        public string Name;
        public string Surname;
        public decimal Initial_balance;

        public Checking(string name, string surname, decimal initial_balance)
        {
            this.Name = name;
            this.Surname = surname;
            this.Initial_balance = initial_balance;
        }

        public string AccountOwner(string Name, string Surname)
        {
            return Name + " " + Surname;
        }

        public decimal Deposit(decimal money)
        {
            return Initial_balance += money;
        }

        int comissioncount = 0;
        public decimal Withdraw(decimal money)
        {
            if (comissioncount >= 1)
            {
                return Initial_balance = Initial_balance - (money + 35);
            }

            else
            {
                comissioncount = comissioncount + 1;
                return Initial_balance = Initial_balance - money;
            }
        }
    }
}

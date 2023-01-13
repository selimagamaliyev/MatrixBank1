using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBank1
{
    public class Savings
    {
        public string Name;
        public string Surname;
        public decimal Interest;
        public decimal Initial_balance;
        public Savings(string name, string surname, decimal interest, decimal initial_balance)
        {
            this.Name = name;
            this.Surname = surname;
            this.Interest = interest;
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

        //public decimal Withdraw(decimal money)
        //{
        //    return Initial_balance -= money;
        //}

        public decimal ApplyInterest(decimal money)
        {
            return Initial_balance = (Initial_balance * 2.5m) / 100 + Initial_balance;
        }


        int comissioncount = 0;
        public decimal Withdraw(decimal money)
        {
            if (money < Initial_balance)
            {
                if (comissioncount >= 3)
                {
                    return Initial_balance = Initial_balance - (money + 2);
                }

                else
                {
                    comissioncount = comissioncount + 1;
                    return Initial_balance = Initial_balance - money;
                }
            }
            else
                Console.WriteLine("Insufficient Balance");
            return 0;
        }
    }
}

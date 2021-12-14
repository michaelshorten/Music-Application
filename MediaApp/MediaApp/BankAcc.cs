using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApp
{
    class BankAcc : IMedia
    {
        //fields
        protected string accNum, name;
        protected double balance;
        protected static string bankname = "Belfast Met Finance";

        //constructor
        public BankAcc(string accNum, string accName, double balance)
        {
            this.accNum = accNum;

            name = accName;
            balance = 0;
        }
        public BankAcc()
        {
            this.name = "No name assigned";
            balance = 0;
           
        }

        public static string Bankname
        {
            get
            {
                return bankname;
            }
            set
            {
                bankname = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;  
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

        }

        //other methods
        public void deposit(double money)
        {
            balance = balance + money;
        }

        public bool withdraw(double money)
        {
            if (balance >= money)
            {
                balance = balance - money;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual string displayStatement()
        {
            return "Name : " +  " "
                + name + "\nCurrent Balance: £" + balance.ToString();
        }

        //communicate with Media Account 
        public void transfer(double money, IMedia acc)
        {
            if (withdraw(money))
            {
                acc.deposit(money);
            }
        }
        public override string ToString()
        {
            return String.Format("Name: {0} has balance £{1}", name, balance);
        }

        public virtual string identify()
        {
            return "Bank Account";
        }



    }
}

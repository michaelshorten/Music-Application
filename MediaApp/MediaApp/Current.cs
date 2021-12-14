using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApp
{
    class Current : BankAcc
    {
        public Current (string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }


    }
}

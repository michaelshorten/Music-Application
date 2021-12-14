using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApp
{
    interface IMedia
    {
        bool withdraw(double money);
        void deposit(double money);
    }
}

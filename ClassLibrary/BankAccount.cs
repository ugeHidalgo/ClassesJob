using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class BankAccount
    {
        decimal _amount;

        decimal Amount { get { return _amount; } set { _amount = value; } }

        public delegate void CheckAmountEventHandler(object sender, EventArgs e);

        public event CheckAmountEventHandler CheckAmount;

        public BankAccount()
        {
            _amount = 0;
        }

        public void Add(decimal cant)
        {
            _amount += cant;
        }


        public void Substract(decimal cant)
        {
            _amount -= cant;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class BankAccount
    {
        decimal _amount;
        decimal _amountMinAllowed = 10;

        public decimal Amount
        {
            get { return _amount; }
            set
            {
                if (value != _amount)
                {
                    _amount = value;
                    //Total amount changed
                    AmountChanged(_amount, null);
                    if (_amount<_amountMinAllowed)                    
                        //Total amount bellow minimum allowed
                        AmountCritical(_amount, null);                    
                    else
                        //Total amount over minimum allowed
                        AmountNormal(_amount, null);                    
                }
            }
        }

        public event EventHandler AmountBellowCero;
        public event EventHandler AmountChanged;
        public event EventHandler AmountCritical;
        public event EventHandler AmountNormal;

        public int Add(decimal cant)
        {
            Amount += cant;
            return 0;
        }


        public int Substract(decimal cant)
        {

            if (Amount - cant < 0)
                AmountBellowCero(Amount, null);
            else
                Amount -= cant;
            return 0;
        }
    }
}

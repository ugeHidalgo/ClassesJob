using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;


namespace WorkWithClasses
{
    public partial class Form2 : Form
    {
        //Instantiate aBankAccout object
        BankAccount aBankAccount = new BankAccount();


        public Form2()
        {
            InitializeComponent();

            //Iniciatlizes Amount value
            aBankAccount.Amount = 0;
            
            //Add EventHandlers indicating which method captures and process event.
            aBankAccount.AmountBellowCero += new EventHandler(Process_AmountBellowCero);
            aBankAccount.AmountChanged += new EventHandler(Process_AmountChanged);
            aBankAccount.AmountCritical += new EventHandler(Process_AmountCritical);
            aBankAccount.AmountNormal += new EventHandler(Process_AmountNormal);
        }

        //Method that captures EvenHandler AmountBellowCero
        public void Process_AmountBellowCero(object sender, EventArgs e)
        {
            string auxAmount = Convert.ToString(sender);
            MessageBox.Show("Overdraft account occurred. Operation DENIED. Total amount: "+auxAmount);
        }

        //Method that captures EvenHandler AmountChanged
        public void Process_AmountChanged(object sender, EventArgs e)
        {
            LaAmount.Text = Convert.ToString(sender);
        }

        //Method that captures EvenHandler AmountCritical
        public void Process_AmountCritical(object sender, EventArgs e)
        {
            LaAmount.ForeColor = Color.Red;
            string auxAmount = Convert.ToString(sender);
            MessageBox.Show("Account amount CRITICAL. Total amount: " + auxAmount);
        }

        //Method that captures EvenHandler AmountNormal
        public void Process_AmountNormal(object sender, EventArgs e)
        {
            LaAmount.ForeColor = Color.Black;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            decimal amountQty;
            try
            {
                amountQty = Convert.ToDecimal(txbxQty.Text);
            }
            catch
            {
                amountQty = 0;
            }

            if (rbtnAdd.Checked)
                aBankAccount.Add(amountQty);
            else
                aBankAccount.Substract(amountQty);
        }


    }
}

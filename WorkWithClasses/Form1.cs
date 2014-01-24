using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Delegate
        public delegate void Del(string name);

        //Method for delegate Del
        public void method1(string name)
        {
            label1.Text = name;
        }

        public void method2(string name)
        {
            label2.Text = name;
        }

        public void MethodWithCallback(string name, Del callBack)
        {
            string cadena = "Metodo con callback (" + name + ")";
            callBack(cadena);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instantiate the delegate
            Del anInstanceofDel = null;
            if (radioButton1.Checked)
                anInstanceofDel = method1;
            else
                anInstanceofDel = method2;

            //Call the delegate
            anInstanceofDel("Hola");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Instantiate the delegate
            Del anInstanceofDel = null;
            if (radioButton1.Checked)
                anInstanceofDel = method1;
            else
                anInstanceofDel = method2;

            //Call the delegate
            MethodWithCallback("Hola", anInstanceofDel );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Del d1 = method1;
            d1 += method2;
            d1("Dos a la vez");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            int val;
            string output = "Number is even";

            //Convert from text to number
            flag = int.TryParse(txtNumber.Text, out val);
            if (flag == false)
            {
                MessageBox.Show("Not a number. Re-enter.");
                txtNumber.Clear();
                txtNumber.Focus();
                return;
            }
            // see if odd or even
            if (val % 2 == 1)
            {
                output = "Number is odd";
            }// Show resultlblOtput.Text = output;
        }

           }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bills
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBoxID.Text);
            string billname = txtBoxName.Text;
            double amount = double.Parse(txtBoxAmount.Text);
            billenum billtype = (billenum)cbBoxType.SelectedItem;

            Bill bill = new Bill(id, billname, amount, billtype);
            bill.displaybilldetails();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbBoxType.Items.Add(billenum.GROCERIES);
            cbBoxType.Items.Add(billenum.UTILITIES);
            cbBoxType.Items.Add(billenum.INSURANCE);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bills
{
    internal class Bill: billabstract,billinterface
    {
        private int id;
        private string billname;
        private double amount;
        private billenum type;
        public Bill() { }
        public Bill(int id, string billname, double amount, billenum type)
        {
            this.id = id;
            this.billname = billname;   
            this.amount = amount;
            this.type = type;
        }
        public int getId() { return id; }
        public string getBillname() {  return billname; }
        public double getAmount() { return amount; }
        public billenum getType() { return type; }
        public override double billcompute()
        {
            double interestAmount = amount * INTEREST;
            double total;
            return total = interestAmount + amount;
        }
        public void displaybilldetails()
        {
            MessageBox.Show("BILL ID: " + getId() +
                            "\nBILL NAME: " + getBillname() +
                            "\nBILL TYPE: " + getType() +
                            "\nBILL AMOUNT: Php" + getAmount().ToString("N2") +
                            "\nTOTAL AMOUNT: Php" + billcompute().ToString("N2"));
        }
    }

    
}

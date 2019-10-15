using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account account=new Account();

        public AccountOperationUi()
        {
            InitializeComponent();
        }



   

        private void WithdrawButton_Click(object sender, EventArgs e)
        {

        }

      

        private void CreateButton_Click_1(object sender, EventArgs e)
        {
            account.AccountNo = accountNoTextBox.Text;
            account.Name = customerNameTextBox.Text;

            accountNoTextBox.Clear();
            customerNameTextBox.Clear();
        }

        private void DipositButton_Click_1(object sender, EventArgs e)
        {
            account.Amount = Convert.ToDouble(amountTextBox.Text);
            account.Deposit(account);

        }

        private void WithdrawButton_Click_1(object sender, EventArgs e)
        {
            account.Amount = Convert.ToDouble(amountTextBox.Text);
            account.Withdraw(account);
        }

        private void ReportButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(account.Report());
        }
    }
}

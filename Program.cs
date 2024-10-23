using System;
using System.Windows.Forms;

namespace BANK_PROJECT
{
    public partial class MainForm : Form
    {
        private BANK account;

        public MainForm()
        {
            InitializeComponent(); //Initialize  component has a problem
            account = new BANK(); //Create bank account
        }

        private void btnDeposit_Click(object sender, EventArgs e) //Deposit button
        {
            if (decimal.TryParse(Amount.Text, out decimal depositAmount)) //Amount input
            {
                account.Deposit(depositAmount); //Deposit the amount
                MessageBox.Show($"Deposited: ${depositAmount:F2}"); //Confirmation
                UpdateTransactionList(); //Refresh list
            }
            else
            {
                MessageBox.Show("Invalid amount."); // Show error 
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e) // Withdraw button clicked
        {
            if (decimal.TryParse(Amount.Text, out decimal withdrawAmount)) // Validate input
            {
                try
                {
                    account.Withdraw(withdrawAmount); //Withdraw the amount
                    MessageBox.Show($"Withdrew: ${withdrawAmount:F2}"); //Show confirmation
                    UpdateTransactionList(); //Refresh transaction list
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message); //Show error 
                }
            }
            else
            {
                MessageBox.Show("Invalid amount."); //Show error for input
            }
        }

        private void btnShowTransactions_Click(object sender, EventArgs e) //Show transactions button clicked
        {
            UpdateTransactionList(); //Refresh list
        }

        private void UpdateTransactionList() //Update list
        {
            listBoxTransactions.Items.Clear(); //Clear existing items
            foreach (var transaction in account.GetTransactions()) //Loop through transactions
            {
                listBoxTransactions.Items.Add(transaction); //Add transaction to list
            }
        }
    }
}

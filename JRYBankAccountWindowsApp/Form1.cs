/* Jonah Young
 * Assignment 6: ATM Windows Form App
 * 12/6/2020
 * C# 1
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace JRYBankAccountWindowsApp
{
    public partial class Form1 : Form
    {

        BankAccount myAccount = new BankAccount(1362.59m, 000302019);

        public Form1()
        {
            InitializeComponent();
            
            AccountNumberTB.Text = "00"+myAccount.AccountNumber.ToString();
            AccountBalanceTB.Text = myAccount.GetAccountBalance().ToString("c");
            DepositBtn.Checked = true;
        }

        
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string transactionAmount = TransactionAmountTB.Text;
            bool isNumeric = decimal.TryParse(transactionAmount, out decimal amount);

            if (isNumeric)
            {
                if (DepositBtn.Checked)
                {
                    myAccount.Deposit(amount);

                    switch (myAccount.Deposit(amount).ToString())
                    {
                        case "Ok":
                            TransactionStatusTB.Text = "Transaction Successful!";
                            break;
                        case "DepositTooLarge":
                            TransactionStatusTB.Text = "The transaction amount is too large and cannot be submitted";
                            break;
                        default:
                            TransactionStatusTB.Text = "Oops! Something went wrong. Please try again.";
                            break;
                    }

                }
                else
                {
                    myAccount.Withdrawal(amount);

                    switch (myAccount.Withdrawal(amount).ToString())
                    {
                        case "Ok":
                            TransactionStatusTB.Text = "Transaction Successful!";
                            break;
                        case "InsufficientFunds":
                            TransactionStatusTB.Text = "Your account has insufficient funds for this transaction.";
                            break;
                        case "Overdrawn":
                            TransactionStatusTB.Text = "Your account is overdrawn. Please make a deposit.";
                            break;
                        default:
                            TransactionStatusTB.Text = "Oops! Something went wrong. Please try again.";
                            break;
                    }


                }
            }
            else
            {
                MessageBox.Show("Please enter a valid transaction amount", "Invalid User Input");
            }

            AccountBalanceTB.Text = myAccount.GetAccountBalance().ToString("c");
            
        }

        private void AccountHistoryBtn_Click(object sender, EventArgs e)
        {
            TransactionHistoryView.View = View.List;
            TransactionHistoryView.Clear();

            foreach (var balance in myAccount.AccountHistory)
            {
                ListViewItem newItem = new ListViewItem(balance.ToString("c"));
                TransactionHistoryView.Items.Add(newItem);
            }


        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetStatusBtn_Click(object sender, EventArgs e)
        {
            if (myAccount.GetAccountStatus().ToString() == "Ok") 
            {
                MessageBox.Show("Your account status is Ok", "Account Status");
            }
            else
            {
                MessageBox.Show("Your account is overdrawn. Please make a deposit", "Account Status");
            }
        }
    }
}

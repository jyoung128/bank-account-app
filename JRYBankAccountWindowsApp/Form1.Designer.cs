namespace JRYBankAccountWindowsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccountNumberTB = new System.Windows.Forms.TextBox();
            this.AccountNumberLbl = new System.Windows.Forms.Label();
            this.AccountBalanceTB = new System.Windows.Forms.TextBox();
            this.AccountBalanceLbl = new System.Windows.Forms.Label();
            this.DepositBtn = new System.Windows.Forms.RadioButton();
            this.WithdrawalBtn = new System.Windows.Forms.RadioButton();
            this.TransactionGB = new System.Windows.Forms.GroupBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.TransactionAmountLbl = new System.Windows.Forms.Label();
            this.TransactionAmountTB = new System.Windows.Forms.TextBox();
            this.TransactionStatusLbl = new System.Windows.Forms.Label();
            this.TransactionStatusTB = new System.Windows.Forms.TextBox();
            this.TransactionHistoryView = new System.Windows.Forms.ListView();
            this.AccountHistoryBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.GetStatusBtn = new System.Windows.Forms.Button();
            this.TransactionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountNumberTB
            // 
            this.AccountNumberTB.Location = new System.Drawing.Point(108, 67);
            this.AccountNumberTB.Name = "AccountNumberTB";
            this.AccountNumberTB.ReadOnly = true;
            this.AccountNumberTB.Size = new System.Drawing.Size(100, 20);
            this.AccountNumberTB.TabIndex = 0;
            // 
            // AccountNumberLbl
            // 
            this.AccountNumberLbl.AutoSize = true;
            this.AccountNumberLbl.Location = new System.Drawing.Point(12, 70);
            this.AccountNumberLbl.Name = "AccountNumberLbl";
            this.AccountNumberLbl.Size = new System.Drawing.Size(90, 13);
            this.AccountNumberLbl.TabIndex = 1;
            this.AccountNumberLbl.Text = "Account Number:";
            // 
            // AccountBalanceTB
            // 
            this.AccountBalanceTB.Location = new System.Drawing.Point(108, 113);
            this.AccountBalanceTB.Name = "AccountBalanceTB";
            this.AccountBalanceTB.ReadOnly = true;
            this.AccountBalanceTB.Size = new System.Drawing.Size(100, 20);
            this.AccountBalanceTB.TabIndex = 2;
            // 
            // AccountBalanceLbl
            // 
            this.AccountBalanceLbl.AutoSize = true;
            this.AccountBalanceLbl.Location = new System.Drawing.Point(12, 116);
            this.AccountBalanceLbl.Name = "AccountBalanceLbl";
            this.AccountBalanceLbl.Size = new System.Drawing.Size(92, 13);
            this.AccountBalanceLbl.TabIndex = 3;
            this.AccountBalanceLbl.Text = "Account Balance:";
            // 
            // DepositBtn
            // 
            this.DepositBtn.AutoSize = true;
            this.DepositBtn.Location = new System.Drawing.Point(6, 60);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(61, 17);
            this.DepositBtn.TabIndex = 4;
            this.DepositBtn.TabStop = true;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = true;
            // 
            // WithdrawalBtn
            // 
            this.WithdrawalBtn.AutoSize = true;
            this.WithdrawalBtn.Location = new System.Drawing.Point(6, 19);
            this.WithdrawalBtn.Name = "WithdrawalBtn";
            this.WithdrawalBtn.Size = new System.Drawing.Size(78, 17);
            this.WithdrawalBtn.TabIndex = 5;
            this.WithdrawalBtn.TabStop = true;
            this.WithdrawalBtn.Text = "Withdrawal";
            this.WithdrawalBtn.UseVisualStyleBackColor = true;
            // 
            // TransactionGB
            // 
            this.TransactionGB.Controls.Add(this.CloseBtn);
            this.TransactionGB.Controls.Add(this.SubmitBtn);
            this.TransactionGB.Controls.Add(this.TransactionAmountLbl);
            this.TransactionGB.Controls.Add(this.TransactionAmountTB);
            this.TransactionGB.Controls.Add(this.WithdrawalBtn);
            this.TransactionGB.Controls.Add(this.DepositBtn);
            this.TransactionGB.Location = new System.Drawing.Point(214, 145);
            this.TransactionGB.Name = "TransactionGB";
            this.TransactionGB.Size = new System.Drawing.Size(418, 183);
            this.TransactionGB.TabIndex = 7;
            this.TransactionGB.TabStop = false;
            this.TransactionGB.Text = "Transaction";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(6, 138);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(108, 23);
            this.SubmitBtn.TabIndex = 8;
            this.SubmitBtn.Text = "Submit Transaction";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // TransactionAmountLbl
            // 
            this.TransactionAmountLbl.AutoSize = true;
            this.TransactionAmountLbl.Location = new System.Drawing.Point(6, 93);
            this.TransactionAmountLbl.Name = "TransactionAmountLbl";
            this.TransactionAmountLbl.Size = new System.Drawing.Size(46, 13);
            this.TransactionAmountLbl.TabIndex = 7;
            this.TransactionAmountLbl.Text = "Amount:";
            // 
            // TransactionAmountTB
            // 
            this.TransactionAmountTB.Location = new System.Drawing.Point(58, 90);
            this.TransactionAmountTB.Name = "TransactionAmountTB";
            this.TransactionAmountTB.Size = new System.Drawing.Size(100, 20);
            this.TransactionAmountTB.TabIndex = 6;
            // 
            // TransactionStatusLbl
            // 
            this.TransactionStatusLbl.AutoSize = true;
            this.TransactionStatusLbl.Location = new System.Drawing.Point(217, 383);
            this.TransactionStatusLbl.Name = "TransactionStatusLbl";
            this.TransactionStatusLbl.Size = new System.Drawing.Size(99, 13);
            this.TransactionStatusLbl.TabIndex = 10;
            this.TransactionStatusLbl.Text = "Transaction Status:";
            // 
            // TransactionStatusTB
            // 
            this.TransactionStatusTB.Location = new System.Drawing.Point(322, 380);
            this.TransactionStatusTB.Name = "TransactionStatusTB";
            this.TransactionStatusTB.ReadOnly = true;
            this.TransactionStatusTB.Size = new System.Drawing.Size(313, 20);
            this.TransactionStatusTB.TabIndex = 9;
            // 
            // TransactionHistoryView
            // 
            this.TransactionHistoryView.HideSelection = false;
            this.TransactionHistoryView.Location = new System.Drawing.Point(15, 145);
            this.TransactionHistoryView.Name = "TransactionHistoryView";
            this.TransactionHistoryView.Size = new System.Drawing.Size(193, 264);
            this.TransactionHistoryView.TabIndex = 8;
            this.TransactionHistoryView.UseCompatibleStateImageBehavior = false;
            // 
            // AccountHistoryBtn
            // 
            this.AccountHistoryBtn.Location = new System.Drawing.Point(12, 415);
            this.AccountHistoryBtn.Name = "AccountHistoryBtn";
            this.AccountHistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.AccountHistoryBtn.TabIndex = 9;
            this.AccountHistoryBtn.Text = "Get History";
            this.AccountHistoryBtn.UseVisualStyleBackColor = true;
            this.AccountHistoryBtn.Click += new System.EventHandler(this.AccountHistoryBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(337, 138);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(231, 48);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(395, 35);
            this.TitleLbl.TabIndex = 11;
            this.TitleLbl.Text = "ATM Windows Form App";
            // 
            // GetStatusBtn
            // 
            this.GetStatusBtn.Location = new System.Drawing.Point(133, 415);
            this.GetStatusBtn.Name = "GetStatusBtn";
            this.GetStatusBtn.Size = new System.Drawing.Size(75, 23);
            this.GetStatusBtn.TabIndex = 12;
            this.GetStatusBtn.Text = "Get Status";
            this.GetStatusBtn.UseVisualStyleBackColor = true;
            this.GetStatusBtn.Click += new System.EventHandler(this.GetStatusBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetStatusBtn);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.TransactionStatusLbl);
            this.Controls.Add(this.TransactionStatusTB);
            this.Controls.Add(this.AccountHistoryBtn);
            this.Controls.Add(this.TransactionHistoryView);
            this.Controls.Add(this.TransactionGB);
            this.Controls.Add(this.AccountBalanceLbl);
            this.Controls.Add(this.AccountBalanceTB);
            this.Controls.Add(this.AccountNumberLbl);
            this.Controls.Add(this.AccountNumberTB);
            this.Name = "Form1";
            this.Text = "Windows ATM";
            this.TransactionGB.ResumeLayout(false);
            this.TransactionGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccountNumberTB;
        private System.Windows.Forms.Label AccountNumberLbl;
        private System.Windows.Forms.TextBox AccountBalanceTB;
        private System.Windows.Forms.Label AccountBalanceLbl;
        private System.Windows.Forms.RadioButton DepositBtn;
        private System.Windows.Forms.RadioButton WithdrawalBtn;
        private System.Windows.Forms.GroupBox TransactionGB;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label TransactionAmountLbl;
        private System.Windows.Forms.TextBox TransactionAmountTB;
        private System.Windows.Forms.Label TransactionStatusLbl;
        private System.Windows.Forms.TextBox TransactionStatusTB;
        private System.Windows.Forms.ListView TransactionHistoryView;
        private System.Windows.Forms.Button AccountHistoryBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button GetStatusBtn;
    }
}


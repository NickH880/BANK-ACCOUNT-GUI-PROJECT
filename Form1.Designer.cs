namespace BANK_ACCOUNT_GUI_PROJECT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Amount = new TextBox();
            Deposit = new Button();
            Withdraw = new Button();
            ListBoxTransaction = new ListBox();
            SuspendLayout();
            // 
            // Amount
            // 
            Amount.Location = new Point(350, 220);
            Amount.Name = "Amount";
            Amount.Size = new Size(94, 27);
            Amount.TabIndex = 0;
            Amount.Text = "Amount";
            Amount.TextChanged += textBox1_TextChanged;
            // 
            // Deposit
            // 
            Deposit.AccessibleName = "Button Deposit";
            Deposit.Location = new Point(350, 149);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(94, 29);
            Deposit.TabIndex = 1;
            Deposit.Text = "Deposit";
            Deposit.UseVisualStyleBackColor = true;
            // 
            // Withdraw
            // 
            Withdraw.AccessibleName = "Withdraw Button";
            Withdraw.Location = new Point(350, 77);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(94, 29);
            Withdraw.TabIndex = 2;
            Withdraw.Text = "Withdraw";
            Withdraw.UseVisualStyleBackColor = true;
            Withdraw.Click += button2_Click;
            // 
            // ListBoxTransaction
            // 
            ListBoxTransaction.AccessibleName = "Transaction List";
            ListBoxTransaction.FormattingEnabled = true;
            ListBoxTransaction.Location = new Point(23, 36);
            ListBoxTransaction.Name = "ListBoxTransaction";
            ListBoxTransaction.Size = new Size(191, 324);
            ListBoxTransaction.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListBoxTransaction);
            Controls.Add(Withdraw);
            Controls.Add(Deposit);
            Controls.Add(Amount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Amount;
        private Button Deposit;
        private Button Withdraw;
        private ListBox ListBoxTransaction;
    }
}

namespace BankApp
{
    partial class DepositsForm
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
            dtpOpenDate = new TabControl();
            tpAccounts = new TabPage();
            tpTransactions = new TabPage();
            tpInterest = new TabPage();
            cmbDepositor = new ComboBox();
            label1 = new Label();
            cmbAccountType = new ComboBox();
            numInitialAmount = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            btnOpenAccount = new Button();
            dgvAccounts = new DataGridView();
            cmbSelectAccount = new ComboBox();
            rbDeposit = new RadioButton();
            rbWithdraw = new RadioButton();
            numAmount = new NumericUpDown();
            btnPerformOp = new Button();
            dgvTransactions = new DataGridView();
            cmbInterestAccount = new ComboBox();
            btnCalculateInterest = new Button();
            btnPrintContract = new Button();
            txtInterestResult = new TextBox();
            s = new SaveFileDialog();
            dtpOpenDate.SuspendLayout();
            tpAccounts.SuspendLayout();
            tpTransactions.SuspendLayout();
            tpInterest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numInitialAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // dtpOpenDate
            // 
            dtpOpenDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpOpenDate.Controls.Add(tpAccounts);
            dtpOpenDate.Controls.Add(tpTransactions);
            dtpOpenDate.Controls.Add(tpInterest);
            dtpOpenDate.Location = new Point(0, 1);
            dtpOpenDate.Name = "dtpOpenDate";
            dtpOpenDate.SelectedIndex = 0;
            dtpOpenDate.Size = new Size(780, 512);
            dtpOpenDate.TabIndex = 0;
            // 
            // tpAccounts
            // 
            tpAccounts.Controls.Add(dgvAccounts);
            tpAccounts.Controls.Add(btnOpenAccount);
            tpAccounts.Controls.Add(dateTimePicker1);
            tpAccounts.Controls.Add(numInitialAmount);
            tpAccounts.Controls.Add(cmbAccountType);
            tpAccounts.Controls.Add(label1);
            tpAccounts.Controls.Add(cmbDepositor);
            tpAccounts.Location = new Point(4, 24);
            tpAccounts.Name = "tpAccounts";
            tpAccounts.Padding = new Padding(3);
            tpAccounts.Size = new Size(772, 484);
            tpAccounts.TabIndex = 0;
            tpAccounts.Text = "Счета вкладчиков";
            tpAccounts.UseVisualStyleBackColor = true;
            // 
            // tpTransactions
            // 
            tpTransactions.Controls.Add(dgvTransactions);
            tpTransactions.Controls.Add(btnPerformOp);
            tpTransactions.Controls.Add(numAmount);
            tpTransactions.Controls.Add(rbWithdraw);
            tpTransactions.Controls.Add(rbDeposit);
            tpTransactions.Controls.Add(cmbSelectAccount);
            tpTransactions.Location = new Point(4, 24);
            tpTransactions.Name = "tpTransactions";
            tpTransactions.Padding = new Padding(3);
            tpTransactions.Size = new Size(772, 484);
            tpTransactions.TabIndex = 1;
            tpTransactions.Text = "Поступления и снятия";
            tpTransactions.UseVisualStyleBackColor = true;
            // 
            // tpInterest
            // 
            tpInterest.Controls.Add(txtInterestResult);
            tpInterest.Controls.Add(btnPrintContract);
            tpInterest.Controls.Add(btnCalculateInterest);
            tpInterest.Controls.Add(cmbInterestAccount);
            tpInterest.Location = new Point(4, 24);
            tpInterest.Name = "tpInterest";
            tpInterest.Size = new Size(772, 484);
            tpInterest.TabIndex = 2;
            tpInterest.Text = "Начисление процентов";
            tpInterest.UseVisualStyleBackColor = true;
            tpInterest.Click += tpInterest_Click;
            // 
            // cmbDepositor
            // 
            cmbDepositor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepositor.FormattingEnabled = true;
            cmbDepositor.Location = new Point(0, 0);
            cmbDepositor.Name = "cmbDepositor";
            cmbDepositor.Size = new Size(121, 23);
            cmbDepositor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Вкладчик:";
            // 
            // cmbAccountType
            // 
            cmbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccountType.FormattingEnabled = true;
            cmbAccountType.Items.AddRange(new object[] { "Стандартный", "Срочный", "С капитализацией" });
            cmbAccountType.Location = new Point(0, 44);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new Size(121, 23);
            cmbAccountType.TabIndex = 2;
            // 
            // numInitialAmount
            // 
            numInitialAmount.DecimalPlaces = 2;
            numInitialAmount.Location = new Point(1, 73);
            numInitialAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numInitialAmount.Name = "numInitialAmount";
            numInitialAmount.Size = new Size(120, 23);
            numInitialAmount.TabIndex = 3;
            numInitialAmount.ThousandsSeparator = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(0, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // btnOpenAccount
            // 
            btnOpenAccount.Location = new Point(3, 131);
            btnOpenAccount.Name = "btnOpenAccount";
            btnOpenAccount.Size = new Size(120, 30);
            btnOpenAccount.TabIndex = 5;
            btnOpenAccount.Text = "Открыть вклад";
            btnOpenAccount.UseVisualStyleBackColor = true;
            // 
            // dgvAccounts
            // 
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(3, 167);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.Size = new Size(765, 314);
            dgvAccounts.TabIndex = 6;
            // 
            // cmbSelectAccount
            // 
            cmbSelectAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSelectAccount.FormattingEnabled = true;
            cmbSelectAccount.Location = new Point(8, 9);
            cmbSelectAccount.Name = "cmbSelectAccount";
            cmbSelectAccount.Size = new Size(121, 23);
            cmbSelectAccount.TabIndex = 0;
            // 
            // rbDeposit
            // 
            rbDeposit.AutoSize = true;
            rbDeposit.Checked = true;
            rbDeposit.Location = new Point(8, 38);
            rbDeposit.Name = "rbDeposit";
            rbDeposit.Size = new Size(98, 19);
            rbDeposit.TabIndex = 1;
            rbDeposit.TabStop = true;
            rbDeposit.Text = "Поступление";
            rbDeposit.UseVisualStyleBackColor = true;
            // 
            // rbWithdraw
            // 
            rbWithdraw.AutoSize = true;
            rbWithdraw.Location = new Point(8, 75);
            rbWithdraw.Name = "rbWithdraw";
            rbWithdraw.Size = new Size(64, 19);
            rbWithdraw.TabIndex = 2;
            rbWithdraw.TabStop = true;
            rbWithdraw.Text = "Снятие";
            rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // numAmount
            // 
            numAmount.DecimalPlaces = 2;
            numAmount.Location = new Point(6, 119);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(120, 23);
            numAmount.TabIndex = 3;
            // 
            // btnPerformOp
            // 
            btnPerformOp.Location = new Point(3, 148);
            btnPerformOp.Name = "btnPerformOp";
            btnPerformOp.Size = new Size(90, 23);
            btnPerformOp.TabIndex = 4;
            btnPerformOp.Text = "Выполнить";
            btnPerformOp.UseVisualStyleBackColor = true;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(8, 177);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.Size = new Size(240, 150);
            dgvTransactions.TabIndex = 5;
            // 
            // cmbInterestAccount
            // 
            cmbInterestAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInterestAccount.FormattingEnabled = true;
            cmbInterestAccount.Location = new Point(8, 9);
            cmbInterestAccount.Name = "cmbInterestAccount";
            cmbInterestAccount.Size = new Size(121, 23);
            cmbInterestAccount.TabIndex = 0;
            // 
            // btnCalculateInterest
            // 
            btnCalculateInterest.Location = new Point(8, 50);
            btnCalculateInterest.Name = "btnCalculateInterest";
            btnCalculateInterest.Size = new Size(185, 23);
            btnCalculateInterest.TabIndex = 1;
            btnCalculateInterest.Text = "Начислить проценты";
            btnCalculateInterest.UseVisualStyleBackColor = true;
            // 
            // btnPrintContract
            // 
            btnPrintContract.Location = new Point(8, 98);
            btnPrintContract.Name = "btnPrintContract";
            btnPrintContract.Size = new Size(118, 23);
            btnPrintContract.TabIndex = 2;
            btnPrintContract.Text = "Печать договора";
            btnPrintContract.UseVisualStyleBackColor = true;
            // 
            // txtInterestResult
            // 
            txtInterestResult.Location = new Point(0, 144);
            txtInterestResult.Multiline = true;
            txtInterestResult.Name = "txtInterestResult";
            txtInterestResult.ReadOnly = true;
            txtInterestResult.ScrollBars = ScrollBars.Vertical;
            txtInterestResult.Size = new Size(100, 23);
            txtInterestResult.TabIndex = 3;
            // 
            // DepositsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(dtpOpenDate);
            Name = "DepositsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepositsForm";
            dtpOpenDate.ResumeLayout(false);
            tpAccounts.ResumeLayout(false);
            tpAccounts.PerformLayout();
            tpTransactions.ResumeLayout(false);
            tpTransactions.PerformLayout();
            tpInterest.ResumeLayout(false);
            tpInterest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numInitialAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl dtpOpenDate;
        private TabPage tpAccounts;
        private TabPage tpTransactions;
        private TabPage tpInterest;
        private ComboBox cmbAccountType;
        private Label label1;
        private ComboBox cmbDepositor;
        private NumericUpDown numInitialAmount;
        private DateTimePicker dateTimePicker1;
        private Button btnOpenAccount;
        private DataGridView dgvAccounts;
        private RadioButton rbDeposit;
        private ComboBox cmbSelectAccount;
        private DataGridView dgvTransactions;
        private Button btnPerformOp;
        private NumericUpDown numAmount;
        private RadioButton rbWithdraw;
        private ComboBox cmbInterestAccount;
        private TextBox txtInterestResult;
        private Button btnPrintContract;
        private Button btnCalculateInterest;
        private SaveFileDialog s;
    }
}
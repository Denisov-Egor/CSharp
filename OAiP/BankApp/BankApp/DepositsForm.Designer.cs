namespace BankApp
{
    partial class DepositsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAccounts = new System.Windows.Forms.TabPage();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.dtpOpenDate = new System.Windows.Forms.DateTimePicker();
            this.numInitialAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepositor = new System.Windows.Forms.ComboBox();
            this.tpTransactions = new System.Windows.Forms.TabPage();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnPerformOp = new System.Windows.Forms.Button();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.cmbSelectAccount = new System.Windows.Forms.ComboBox();
            this.tpInterest = new System.Windows.Forms.TabPage();
            this.txtInterestResult = new System.Windows.Forms.TextBox();
            this.btnPrintContract = new System.Windows.Forms.Button();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.cmbInterestAccount = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialAmount)).BeginInit();
            this.tpTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.tpInterest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpAccounts);
            this.tabControl1.Controls.Add(this.tpTransactions);
            this.tabControl1.Controls.Add(this.tpInterest);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAccounts
            // 
            this.tpAccounts.Controls.Add(this.dgvAccounts);
            this.tpAccounts.Controls.Add(this.btnOpenAccount);
            this.tpAccounts.Controls.Add(this.dtpOpenDate);
            this.tpAccounts.Controls.Add(this.numInitialAmount);
            this.tpAccounts.Controls.Add(this.cmbAccountType);
            this.tpAccounts.Controls.Add(this.label1);
            this.tpAccounts.Controls.Add(this.cmbDepositor);
            this.tpAccounts.Location = new System.Drawing.Point(4, 24);
            this.tpAccounts.Name = "tpAccounts";
            this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccounts.Size = new System.Drawing.Size(772, 484);
            this.tpAccounts.TabIndex = 0;
            this.tpAccounts.Text = "Счета вкладчиков";
            this.tpAccounts.UseVisualStyleBackColor = true;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(3, 167);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.Size = new System.Drawing.Size(765, 314);
            this.dgvAccounts.TabIndex = 6;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(3, 131);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(120, 30);
            this.btnOpenAccount.TabIndex = 5;
            this.btnOpenAccount.Text = "Открыть вклад";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            // 
            // dtpOpenDate
            // 
            this.dtpOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpenDate.Location = new System.Drawing.Point(0, 102);
            this.dtpOpenDate.Name = "dtpOpenDate";
            this.dtpOpenDate.Size = new System.Drawing.Size(200, 23);
            this.dtpOpenDate.TabIndex = 4;
            // 
            // numInitialAmount
            // 
            this.numInitialAmount.DecimalPlaces = 2;
            this.numInitialAmount.Location = new System.Drawing.Point(1, 73);
            this.numInitialAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numInitialAmount.Name = "numInitialAmount";
            this.numInitialAmount.Size = new System.Drawing.Size(120, 23);
            this.numInitialAmount.TabIndex = 3;
            this.numInitialAmount.ThousandsSeparator = true;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Стандартный",
            "Срочный",
            "С капитализацией"});
            this.cmbAccountType.Location = new System.Drawing.Point(0, 44);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(121, 23);
            this.cmbAccountType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вкладчик:";
            // 
            // cmbDepositor
            // 
            this.cmbDepositor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepositor.FormattingEnabled = true;
            this.cmbDepositor.Location = new System.Drawing.Point(0, 0);
            this.cmbDepositor.Name = "cmbDepositor";
            this.cmbDepositor.Size = new System.Drawing.Size(121, 23);
            this.cmbDepositor.TabIndex = 0;
            // 
            // tpTransactions
            // 
            this.tpTransactions.Controls.Add(this.dgvTransactions);
            this.tpTransactions.Controls.Add(this.btnPerformOp);
            this.tpTransactions.Controls.Add(this.numAmount);
            this.tpTransactions.Controls.Add(this.rbWithdraw);
            this.tpTransactions.Controls.Add(this.rbDeposit);
            this.tpTransactions.Controls.Add(this.cmbSelectAccount);
            this.tpTransactions.Location = new System.Drawing.Point(4, 24);
            this.tpTransactions.Name = "tpTransactions";
            this.tpTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransactions.Size = new System.Drawing.Size(772, 484);
            this.tpTransactions.TabIndex = 1;
            this.tpTransactions.Text = "Поступления и снятия";
            this.tpTransactions.UseVisualStyleBackColor = true;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(8, 177);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.Size = new System.Drawing.Size(240, 150);
            this.dgvTransactions.TabIndex = 5;
            // 
            // btnPerformOp
            // 
            this.btnPerformOp.Location = new System.Drawing.Point(3, 148);
            this.btnPerformOp.Name = "btnPerformOp";
            this.btnPerformOp.Size = new System.Drawing.Size(90, 23);
            this.btnPerformOp.TabIndex = 4;
            this.btnPerformOp.Text = "Выполнить";
            this.btnPerformOp.UseVisualStyleBackColor = true;
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(6, 119);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(120, 23);
            this.numAmount.TabIndex = 3;
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Location = new System.Drawing.Point(8, 75);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(64, 19);
            this.rbWithdraw.TabIndex = 2;
            this.rbWithdraw.TabStop = true;
            this.rbWithdraw.Text = "Снятие";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Checked = true;
            this.rbDeposit.Location = new System.Drawing.Point(8, 38);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(98, 19);
            this.rbDeposit.TabIndex = 1;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Поступление";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // cmbSelectAccount
            // 
            this.cmbSelectAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectAccount.FormattingEnabled = true;
            this.cmbSelectAccount.Location = new System.Drawing.Point(8, 9);
            this.cmbSelectAccount.Name = "cmbSelectAccount";
            this.cmbSelectAccount.Size = new System.Drawing.Size(121, 23);
            this.cmbSelectAccount.TabIndex = 0;
            // 
            // tpInterest
            // 
            this.tpInterest.Controls.Add(this.txtInterestResult);
            this.tpInterest.Controls.Add(this.btnPrintContract);
            this.tpInterest.Controls.Add(this.btnCalculateInterest);
            this.tpInterest.Controls.Add(this.cmbInterestAccount);
            this.tpInterest.Location = new System.Drawing.Point(4, 24);
            this.tpInterest.Name = "tpInterest";
            this.tpInterest.Size = new System.Drawing.Size(772, 484);
            this.tpInterest.TabIndex = 2;
            this.tpInterest.Text = "Начисление процентов";
            this.tpInterest.UseVisualStyleBackColor = true;
            // 
            // txtInterestResult
            // 
            this.txtInterestResult.Location = new System.Drawing.Point(0, 144);
            this.txtInterestResult.Multiline = true;
            this.txtInterestResult.Name = "txtInterestResult";
            this.txtInterestResult.ReadOnly = true;
            this.txtInterestResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInterestResult.Size = new System.Drawing.Size(350, 150);
            this.txtInterestResult.TabIndex = 3;
            // 
            // btnPrintContract
            // 
            this.btnPrintContract.Location = new System.Drawing.Point(8, 98);
            this.btnPrintContract.Name = "btnPrintContract";
            this.btnPrintContract.Size = new System.Drawing.Size(118, 23);
            this.btnPrintContract.TabIndex = 2;
            this.btnPrintContract.Text = "Печать договора";
            this.btnPrintContract.UseVisualStyleBackColor = true;
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.Location = new System.Drawing.Point(8, 50);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(185, 23);
            this.btnCalculateInterest.TabIndex = 1;
            this.btnCalculateInterest.Text = "Начислить проценты";
            this.btnCalculateInterest.UseVisualStyleBackColor = true;
            // 
            // cmbInterestAccount
            // 
            this.cmbInterestAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterestAccount.FormattingEnabled = true;
            this.cmbInterestAccount.Location = new System.Drawing.Point(8, 9);
            this.cmbInterestAccount.Name = "cmbInterestAccount";
            this.cmbInterestAccount.Size = new System.Drawing.Size(121, 23);
            this.cmbInterestAccount.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // DepositsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "DepositsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление вкладами";
            this.tabControl1.ResumeLayout(false);
            this.tpAccounts.ResumeLayout(false);
            this.tpAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialAmount)).EndInit();
            this.tpTransactions.ResumeLayout(false);
            this.tpTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.tpInterest.ResumeLayout(false);
            this.tpInterest.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAccounts;
        private System.Windows.Forms.TabPage tpTransactions;
        private System.Windows.Forms.TabPage tpInterest;
        private System.Windows.Forms.ComboBox cmbDepositor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.NumericUpDown numInitialAmount;
        private System.Windows.Forms.DateTimePicker dtpOpenDate;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.ComboBox cmbSelectAccount;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button btnPerformOp;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.ComboBox cmbInterestAccount;
        private System.Windows.Forms.Button btnCalculateInterest;
        private System.Windows.Forms.Button btnPrintContract;
        private System.Windows.Forms.TextBox txtInterestResult;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
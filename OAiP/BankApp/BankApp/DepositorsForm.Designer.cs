namespace BankApp
{
    partial class DepositorsForm
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
            dgvDepositors = new DataGridView();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnAdd = new Button();
            txtFullName = new TextBox();
            txtPassport = new TextBox();
            txtPhone = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDepositors).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDepositors
            // 
            dgvDepositors.AllowUserToAddRows = false;
            dgvDepositors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepositors.Location = new Point(12, 12);
            dgvDepositors.Name = "dgvDepositors";
            dgvDepositors.ReadOnly = true;
            dgvDepositors.Size = new Size(240, 150);
            dgvDepositors.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(txtPassport);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(Label3);
            groupBox1.Controls.Add(Label2);
            groupBox1.Controls.Add(Label1);
            groupBox1.Location = new Point(12, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные вкладчика";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(385, 69);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(304, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(71, 19);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 5;
            // 
            // txtPassport
            // 
            txtPassport.Location = new Point(71, 48);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(100, 23);
            txtPassport.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(71, 77);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 3;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(6, 82);
            Label3.Name = "Label3";
            Label3.Size = new Size(59, 15);
            Label3.TabIndex = 2;
            Label3.Text = "Телефон:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(6, 46);
            Label2.Name = "Label2";
            Label2.Size = new Size(57, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Паспорт:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(6, 19);
            Label1.Name = "Label1";
            Label1.Size = new Size(37, 15);
            Label1.TabIndex = 0;
            Label1.Text = "ФИО:";
            // 
            // DepositorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 411);
            Controls.Add(groupBox1);
            Controls.Add(dgvDepositors);
            Name = "DepositorsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepositorsForm";
            //Load += Вкладчики_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepositors).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDepositors;
        private GroupBox groupBox1;
        private TextBox txtPhone;
        private Label Label3;
        private Label Label2;
        private Label Label1;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtFullName;
        private TextBox txtPassport;
    }
}
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
            txtPhone = new TextBox();
            label3 = new Label();
            txtPassport = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepositors).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDepositors
            // 
            dgvDepositors.AllowUserToAddRows = false;
            dgvDepositors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepositors.Location = new Point(12, 148);
            dgvDepositors.Name = "dgvDepositors";
            dgvDepositors.ReadOnly = true;
            dgvDepositors.Size = new Size(240, 150);
            dgvDepositors.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassport);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(373, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 151);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные вкладчика";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(67, 78);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 78);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Телефон";
            // 
            // txtPassport
            // 
            txtPassport.Location = new Point(67, 49);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(100, 23);
            txtPassport.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 49);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Паспорт";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(67, 20);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 20);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 106);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(92, 107);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // DepositorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 411);
            Controls.Add(groupBox1);
            Controls.Add(dgvDepositors);
            Name = "DepositorsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вкладчики";
            Load += DepositorsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepositors).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDepositors;
        private GroupBox groupBox1;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtPassport;
        private Label label2;
        private TextBox txtFullName;
        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
    }
}
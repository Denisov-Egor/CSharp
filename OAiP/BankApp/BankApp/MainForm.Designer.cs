namespace BankApp
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            вкладчикиToolStripMenuItem = new ToolStripMenuItem();
            управлениеВкладчикамиToolStripMenuItem = new ToolStripMenuItem();
            вкладыToolStripMenuItem = new ToolStripMenuItem();
            управлениеВкладамиToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem1 = new ToolStripMenuItem();
            btnDepositors = new Button();
            btnDeposits = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { вкладчикиToolStripMenuItem, вкладыToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // вкладчикиToolStripMenuItem
            // 
            вкладчикиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { управлениеВкладчикамиToolStripMenuItem });
            вкладчикиToolStripMenuItem.Name = "вкладчикиToolStripMenuItem";
            вкладчикиToolStripMenuItem.Size = new Size(78, 20);
            вкладчикиToolStripMenuItem.Text = "Вкладчики";
            вкладчикиToolStripMenuItem.Click += вкладчикиToolStripMenuItem_Click;
            // 
            // управлениеВкладчикамиToolStripMenuItem
            // 
            управлениеВкладчикамиToolStripMenuItem.Name = "управлениеВкладчикамиToolStripMenuItem";
            управлениеВкладчикамиToolStripMenuItem.Size = new Size(216, 22);
            управлениеВкладчикамиToolStripMenuItem.Text = "Управление вкладчиками";
            управлениеВкладчикамиToolStripMenuItem.Click += управлениеВкладчикамиToolStripMenuItem_Click;
            // 
            // вкладыToolStripMenuItem
            // 
            вкладыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { управлениеВкладамиToolStripMenuItem });
            вкладыToolStripMenuItem.Name = "вкладыToolStripMenuItem";
            вкладыToolStripMenuItem.Size = new Size(60, 20);
            вкладыToolStripMenuItem.Text = "Вклады";
            // 
            // управлениеВкладамиToolStripMenuItem
            // 
            управлениеВкладамиToolStripMenuItem.Name = "управлениеВкладамиToolStripMenuItem";
            управлениеВкладамиToolStripMenuItem.Size = new Size(196, 22);
            управлениеВкладамиToolStripMenuItem.Text = "Управление вкладами";
            управлениеВкладамиToolStripMenuItem.Click += управлениеВкладамиToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem1 });
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(56, 20);
            выходToolStripMenuItem.Text = "Выход ";
            // 
            // выходToolStripMenuItem1
            // 
            выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            выходToolStripMenuItem1.Size = new Size(180, 22);
            выходToolStripMenuItem1.Text = "Выход ";
            выходToolStripMenuItem1.Click += выходToolStripMenuItem1_Click;
            // 
            // btnDepositors
            // 
            btnDepositors.Location = new Point(150, 100);
            btnDepositors.Name = "btnDepositors";
            btnDepositors.Size = new Size(180, 50);
            btnDepositors.TabIndex = 1;
            btnDepositors.Text = "Вкладчики";
            btnDepositors.UseVisualStyleBackColor = true;
            btnDepositors.Click += btnDepositors_Click;
            // 
            // btnDeposits
            // 
            btnDeposits.Location = new Point(150, 180);
            btnDeposits.Name = "btnDeposits";
            btnDeposits.Size = new Size(180, 50);
            btnDeposits.TabIndex = 2;
            btnDeposits.Text = "Вклады и операции";
            btnDeposits.UseVisualStyleBackColor = true;
            btnDeposits.Click += btnDeposits_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(btnDeposits);
            Controls.Add(btnDepositors);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Банк – Учёт вкладов";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem вкладчикиToolStripMenuItem;
        private ToolStripMenuItem управлениеВкладчикамиToolStripMenuItem;
        private ToolStripMenuItem вкладыToolStripMenuItem;
        private ToolStripMenuItem управлениеВкладамиToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem1;
        private Button btnDepositors;
        private Button btnDeposits;
    }
}

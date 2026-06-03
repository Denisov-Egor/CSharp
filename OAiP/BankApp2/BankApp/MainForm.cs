namespace BankApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void вкладчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void управлениеВкладчикамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositorsForm depositorsForm = new DepositorsForm();
            depositorsForm.ShowDialog();
        }

        private void управлениеВкладамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositsForm depositsForm = new DepositsForm();
            depositsForm.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDepositors_Click(object sender, EventArgs e)
        {
            DepositorsForm depositorsForm = new DepositorsForm();
            depositorsForm.ShowDialog();
        }

        private void btnDeposits_Click(object sender, EventArgs e)
        {
            DepositsForm depositsForm = new DepositsForm();
            depositsForm.ShowDialog();
        }
    }
}

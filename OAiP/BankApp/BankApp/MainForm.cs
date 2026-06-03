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

        private void btnDepositors_Click(object sender, EventArgs e)
        {
            DepositorsForm form = new DepositorsForm();
            form.ShowDialog();
        }

        private void btnDeposits_Click(object sender, EventArgs e)
        {
            DepositsForm form = new DepositsForm();
            form.ShowDialog();
        }

        private void управлениеВкладчикамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDepositors_Click(sender, e);
        }

        private void управлениеВкладамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeposits_Click(sender, e);
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

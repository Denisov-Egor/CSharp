using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{
    public partial class DepositorsForm : Form
    {
        private List<Depositor> depositors => DataStore.Depositors;

        public DepositorsForm()
        {
            InitializeComponent();
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            dgvDepositors.DataSource = null;
            dgvDepositors.DataSource = depositors;
            // Настройка заголовков столбцов (по желанию)
            if (dgvDepositors.Columns.Count > 0)
            {
                dgvDepositors.Columns["FullName"].HeaderText = "ФИО";
                dgvDepositors.Columns["Passport"].HeaderText = "Паспорт";
                dgvDepositors.Columns["Phone"].HeaderText = "Телефон";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введите ФИО!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            depositors.Add(new Depositor
            {
                FullName = txtFullName.Text.Trim(),
                Passport = txtPassport.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            });
            LoadDataToGrid();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDepositors.CurrentRow != null)
            {
                Depositor selected = dgvDepositors.CurrentRow.DataBoundItem as Depositor;
                if (selected != null)
                {
                    depositors.Remove(selected);
                    LoadDataToGrid();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления!");
            }
        }

        private void ClearInputs()
        {
            txtFullName.Text = "";
            txtPassport.Text = "";
            txtPhone.Text = "";
        }
    }

    // Класс модели вкладчика (можно вынести в отдельный файл)
    public class Depositor
    {
        public string FullName { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
    }
}

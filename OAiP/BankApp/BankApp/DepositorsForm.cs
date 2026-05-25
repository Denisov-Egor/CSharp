using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static BankApp.DepositorsForm;

namespace BankApp
{
    public partial class DepositorsForm : Form
    {
        // Объявляем список вкладчиков (поле класса)
        private List<Depositor> depositors = new List<Depositor>();

        public DepositorsForm()
        {
            InitializeComponent();
            LoadDataToGrid();
        }

        private void DepositorsForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataToGrid()
        {
            dgvDepositors.DataSource = null;
            dgvDepositors.DataSource = depositors;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text)) return;
            depositors.Add(new Depositor
            {
                FullName = txtFullName.Text,
                Passport = txtPassport.Text,
                Phone = txtPhone.Text
            });
            LoadDataToGrid();
            ClearInputs();
        }

        // Если у вас есть кнопка удаления, добавьте этот обработчик
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
        }

        private void ClearInputs()
        {
            txtFullName.Text = txtPassport.Text = txtPhone.Text = "";
        }

        // Класс-модель
        public class Depositor
        {
            public string FullName { get; set; }
            public string Passport { get; set; }
            public string Phone { get; set; }
        }
    }
}
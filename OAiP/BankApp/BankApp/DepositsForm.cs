using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BankApp
{
    public partial class DepositsForm : Form
    {
        private List<Depositor> depositors => DataStore.Depositors;
        private List<BankAccount> accounts => DataStore.Accounts;
        private List<Transaction> transactions => DataStore.Transactions;

        public DepositsForm()
        {
            InitializeComponent();
            // Привязываем события (на случай, если дизайнер не привязал)
            btnOpenAccount.Click += btnOpenAccount_Click;
            btnPerformOp.Click += btnPerformOp_Click;
            btnCalculateInterest.Click += btnCalculateInterest_Click;
            btnPrintContract.Click += btnPrintContract_Click;

            RefreshDepositorCombo();
            RefreshAccountsCombo();
            RefreshAccountsGrid();
            // Подписка на изменение выбора счета для обновления транзакций
            cmbSelectAccount.SelectedIndexChanged += (s, e) => RefreshTransactionsGrid();
        }

        private void RefreshDepositorCombo()
        {
            cmbDepositor.DataSource = null;
            cmbDepositor.DataSource = depositors;
            cmbDepositor.DisplayMember = "FullName";
        }

        private void RefreshAccountsCombo()
        {
            cmbSelectAccount.DataSource = null;
            cmbSelectAccount.DataSource = accounts;
            cmbSelectAccount.DisplayMember = "DisplayName";

            cmbInterestAccount.DataSource = null;
            cmbInterestAccount.DataSource = accounts;
            cmbInterestAccount.DisplayMember = "DisplayName";
        }

        private void RefreshAccountsGrid()
        {
            var displayList = accounts.Select(a => new
            {
                a.Id,
                Вкладчик = GetDepositorName(a.DepositorId),
                Тип = a.AccountType,
                Сумма = a.Balance,
                ДатаОткрытия = a.OpenDate.ToShortDateString(),
                Ставка = a.InterestRate.ToString("P")
            }).ToList();
            dgvAccounts.DataSource = displayList;
        }

        private string GetDepositorName(int depositorId)
        {
            if (depositorId >= 0 && depositorId < depositors.Count)
                return depositors[depositorId].FullName;
            return "Неизвестно";
        }

        private void RefreshTransactionsGrid()
        {
            if (cmbSelectAccount.SelectedItem is BankAccount acc)
            {
                var txns = transactions.Where(t => t.AccountId == acc.Id)
                    .Select(t => new { t.Date, t.Type, Сумма = t.Amount }).ToList();
                dgvTransactions.DataSource = txns;
            }
            else
                dgvTransactions.DataSource = null;
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            if (cmbDepositor.SelectedItem == null)
            {
                MessageBox.Show("Выберите вкладчика!", "Ошибка");
                return;
            }
            var depositor = (Depositor)cmbDepositor.SelectedItem;
            int depositorIndex = depositors.IndexOf(depositor);
            decimal initial = numInitialAmount.Value;
            if (initial <= 0)
            {
                MessageBox.Show("Сумма должна быть больше 0", "Ошибка");
                return;
            }
            decimal rate = 0.03m; // 3% по умолчанию
            if (cmbAccountType.Text == "Срочный") rate = 0.05m;
            else if (cmbAccountType.Text == "С капитализацией") rate = 0.06m;

            BankAccount newAccount = new BankAccount
            {
                Id = accounts.Count > 0 ? accounts.Max(a => a.Id) + 1 : 1,
                DepositorId = depositorIndex,
                AccountType = cmbAccountType.Text,
                Balance = initial,
                OpenDate = dtpOpenDate.Value,
                InterestRate = rate
            };
            accounts.Add(newAccount);
            RefreshAccountsCombo();
            RefreshAccountsGrid();
            MessageBox.Show("Вклад открыт успешно!", "Успех");
        }

        private void btnPerformOp_Click(object sender, EventArgs e)
        {
            if (cmbSelectAccount.SelectedItem == null)
            {
                MessageBox.Show("Выберите счёт", "Ошибка");
                return;
            }
            BankAccount acc = (BankAccount)cmbSelectAccount.SelectedItem;
            decimal amount = numAmount.Value;
            if (amount <= 0)
            {
                MessageBox.Show("Сумма должна быть положительной", "Ошибка");
                return;
            }
            string type = "";
            if (rbDeposit.Checked)
            {
                acc.Balance += amount;
                type = "Пополнение";
            }
            else if (rbWithdraw.Checked)
            {
                if (acc.Balance >= amount)
                {
                    acc.Balance -= amount;
                    type = "Снятие";
                }
                else
                {
                    MessageBox.Show("Недостаточно средств!", "Ошибка");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Выберите тип операции", "Ошибка");
                return;
            }

            transactions.Add(new Transaction
            {
                Id = transactions.Count > 0 ? transactions.Max(t => t.Id) + 1 : 1,
                AccountId = acc.Id,
                Amount = amount,
                Type = type,
                Date = DateTime.Now
            });
            RefreshAccountsGrid();
            RefreshTransactionsGrid();
            RefreshAccountsCombo(); // обновить списки счетов
            MessageBox.Show("Операция выполнена", "Успех");
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            if (cmbInterestAccount.SelectedItem == null)
            {
                MessageBox.Show("Выберите счёт", "Ошибка");
                return;
            }
            BankAccount acc = (BankAccount)cmbInterestAccount.SelectedItem;
            decimal monthlyInterest = acc.Balance * (acc.InterestRate / 12);
            txtInterestResult.Text = $"Счёт: {acc.DisplayName}\n" +
                                      $"Баланс: {acc.Balance:F2} руб.\n" +
                                      $"Годовая ставка: {acc.InterestRate:P}\n" +
                                      $"Проценты за месяц: {monthlyInterest:F2} руб.\n" +
                                      $"Новый баланс (с капитализацией): {acc.Balance + monthlyInterest:F2} руб.";
        }

        private void btnPrintContract_Click(object sender, EventArgs e)
        {
            if (cmbInterestAccount.SelectedItem == null)
            {
                MessageBox.Show("Выберите счёт для печати договора", "Ошибка");
                return;
            }
            BankAccount acc = (BankAccount)cmbInterestAccount.SelectedItem;
            string depositorName = GetDepositorName(acc.DepositorId);
            string contract = $"ДОГОВОР НА ОТКРЫТИЕ ВКЛАДА №{acc.Id}\n" +
                              $"Вкладчик: {depositorName}\n" +
                              $"Тип вклада: {acc.AccountType}\n" +
                              $"Сумма вклада: {acc.Balance:F2} руб.\n" +
                              $"Дата открытия: {acc.OpenDate.ToShortDateString()}\n" +
                              $"Процентная ставка: {acc.InterestRate:P}\n" +
                              $"\nПодписи сторон:\nВкладчик: ___________\nБанк: _______________";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, contract);
                MessageBox.Show("Договор сохранён!", "Успех");
            }
        }
    }

    // Модели данных
    public class BankAccount
    {
        public int Id { get; set; }
        public int DepositorId { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public DateTime OpenDate { get; set; }
        public decimal InterestRate { get; set; }
        public string DisplayName => $"№{Id} - {AccountType} - {Balance:F2} руб.";
    }

    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
    }
}
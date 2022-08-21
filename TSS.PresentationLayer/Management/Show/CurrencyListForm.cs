using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSS.UserInterface.Management.Show
{
    public partial class CurrencyListForm : Form
    {
        public CurrencyListForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Entities.Concretes.Currency newCurrency = new Entities.Concretes.Currency() {
                Name = txtName.Text,
                Symbol = txtSymbol.Text,
                GetLink = txtLink.Text
            };
            Program.currencyManager.AddEntities(newCurrency);
            refreshData();
            clearText();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Program.currencyManager.DeleteEntities(Convert.ToInt32(txtID.Text));
            refreshData();
            clearText();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Entities.Concretes.Currency currency = new Entities.Concretes.Currency()
            {
                Name = txtName.Text,
                Symbol = txtSymbol.Text,
                GetLink = txtLink.Text
            };
            Program.currencyManager.UpdateEntities(Convert.ToInt32(txtID.Text), currency);
            refreshData();
            clearText();
        }

        private void clearText()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtSymbol.Text = "";
            txtLink.Text = "";
        }

        private void refreshData() {
            dgvCurrency.DataSource = Program.currencyManager.getAllEntities();
            clearText();

        }

        private void ProductPriceListForm_Load(object sender, EventArgs e)
        {
            dgvCurrency.DefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            refreshData();
            clearText();

        }

        private void dgvCurrency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCurrency.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCurrency.CurrentRow.Cells[1].Value.ToString();
            txtSymbol.Text = dgvCurrency.CurrentRow.Cells[2].Value.ToString();
            txtLink.Text = dgvCurrency.CurrentRow.Cells[3].Value.ToString();

        }
    }
}

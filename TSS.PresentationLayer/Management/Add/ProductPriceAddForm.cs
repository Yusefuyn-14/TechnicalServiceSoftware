using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSS.UserInterface.Management.Add
{
    public partial class ProductPriceAddForm : Form
    {
        public ProductPriceAddForm()
        {
            InitializeComponent();
        }
        int tax = 0;

        private void refreshData() {
            foreach (var item in Program.productManager.NotSaleProduct())
            {
                dgvProduct.Rows.Add(new string[] {
                    item.ID.ToString(),
                    item.Name,
                    item.Brand,
                    item.Model,
                    Program.productCategoryManager.GetEntitieByFiltered(c => c.ID == Convert.ToInt32(item.CategoryID)).Name
                });
            }
            comboBox1.DataSource = new TSS.Tools.ListToDataTableConverter().ToDataTable(Program.currencyManager.getAllEntities());
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }
        private void ProductPriceAddForm_Load(object sender, EventArgs e)
        {
            dgvProduct.DefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            refreshData();
        }


        private void vergiKarHesapla(int sFiyat, int aFiyat)
        {
            lblVergi.Text = (sFiyat / 100 * tax).ToString();
            lblKar.Text = (sFiyat - aFiyat - tax).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Entities.Concretes.Products_Price productPrice = new Entities.Concretes.Products_Price()
            {
                PurchasePrice = Convert.ToInt32(numPurchase.Value),
                SalePrice = Convert.ToInt32(numSale.Value),
                ProductID = new Entities.Concretes.Products() { ID = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value.ToString()) },
                CurrencyID = new Entities.Concretes.Currency() { ID = Convert.ToInt32(comboBox1.SelectedValue) }
            };
            Program.productPriceManager.AddEntities(productPrice);
            refreshData();
        }

        private void numPurchase_ValueChanged(object sender, EventArgs e)
        {
            vergiKarHesapla(Convert.ToInt32(numSale.Value), Convert.ToInt32(numPurchase.Value));

        }

        private void numSale_ValueChanged(object sender, EventArgs e)
        {
            vergiKarHesapla(Convert.ToInt32(numSale.Value), Convert.ToInt32(numPurchase.Value));

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();

        }

        private void btnCurrencyUnitAdd_Click(object sender, EventArgs e)
        {
            Management.Show.CurrencyListForm currencyListForm = new Management.Show.CurrencyListForm();
            currencyListForm.ShowDialog();
            refreshData();
        }
    }
}

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
    public partial class ProductPriceListForm : Form
    {
        int tax = 0;
        public ProductPriceListForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshData()
        {
            dgvProductPrice.Rows.Clear();
            foreach (var item in Program.productPriceManager.getAllEntities())
            {
                int categoryID = Program.productManager.GetEntitieByFiltered(t => t.ID == item.ProductID.ID).CategoryID.ID;
                int categoryTax = Program.productCategoryManager.GetEntitieByFiltered(x => x.ID == categoryID).Tax;
                dgvProductPrice.Rows.Add(new string[] {
                    item.ID.ToString(),
                    Program.productManager.GetEntitieByFiltered(t => t.ID == item.ProductID.ID).Name,
                    Program.currencyManager.GetEntitieByFiltered(t => t.ID == item.CurrencyID.ID).Name,
                    item.SalePrice.ToString(),
                    item.PurchasePrice.ToString(),
                    (item.SalePrice / 100 * categoryTax).ToString(),
                    (item.SalePrice - ((item.SalePrice / 100 * categoryTax) + item.PurchasePrice)).ToString()
                });
            }

        }

        private void ProductPriceListForm_Load(object sender, EventArgs e)
        {
            dgvProductPrice.DefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            refreshData();
        }

        private void btnAddProductPrice_Click(object sender, EventArgs e)
        {
            Management.Add.ProductPriceAddForm productPriceAddForm = new Add.ProductPriceAddForm();
            if (productPriceAddForm.ShowDialog() == DialogResult.OK)
                refreshData();
        }

        private void dgvProductPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int category = Program.productManager.getEntitie(dgvProductPrice.CurrentRow.Cells[1].Value.ToString()).Category;
            //tax = Program.productCategoryManager.getEntitie(category).Tax;
            //numSale.Value = Convert.ToDecimal(dgvProductPrice.CurrentRow.Cells[3].Value);
            //numPurchase.Value = Convert.ToDecimal(dgvProductPrice.CurrentRow.Cells[4].Value);
            //label8.Text = dgvProductPrice.CurrentRow.Cells[0].Value.ToString();
            //vergiKarHesapla(Convert.ToInt32(numSale.Value), Convert.ToInt32(numPurchase.Value));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Program.productPriceManager.DeleteEntities(Convert.ToInt32(dgvProductPrice.CurrentRow.Cells[0].Value.ToString()));
            refreshData();
        }
    }
}

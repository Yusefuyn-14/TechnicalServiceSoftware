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
    public partial class TroublePriceAdd : Form
    {

        int TroubleID = 0;

        public TroublePriceAdd(int troubleID)
        {
            InitializeComponent();
            TroubleID = troubleID;
        }

        public void refreshData()
        {
            dgvTroubleProduct.DataSource = Program.troublePriceManager.JoinTroubleProductTable(TroubleID);

            dgvProductPrice.Rows.Clear();
            foreach (var item in Program.productPriceManager.getAllEntities())
            {
                int productID = item.ID;
                int salePrice = item.SalePrice;
                Entities.Concretes.Products product = Program.productManager.GetEntitieByFiltered(t => t.ID == item.ProductID.ID);

                dgvProductPrice.Rows.Add(new string[] { productID.ToString(), product.Name, salePrice.ToString() });
            }
        }

        private void TroublePriceAdd_Load(object sender, EventArgs e)
        {
            refreshData();
            dgvProductPrice.DefaultCellStyle.ForeColor = Color.White;
            dgvTroubleProduct.DefaultCellStyle.ForeColor = Color.White;
            dgvProductPrice.DefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            dgvTroubleProduct.DefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvTroubleProduct.Rows.Count > 0)
                Program.troublePriceManager.DeleteEntities(Convert.ToInt32(dgvTroubleProduct.CurrentRow.Cells[0].Value.ToString()));
            refreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entities.Concretes.Troubles_Price troublePrice = new Entities.Concretes.Troubles_Price();
            troublePrice.TroubleID = new Entities.Concretes.Troubles() { ID = TroubleID };
            int test = Convert.ToInt32(dgvProductPrice.CurrentRow.Cells[0].Value);
            troublePrice.Product_PriceID = Program.productPriceManager.GetEntitieByFiltered( x => x.ID == test );
            //troublePrice.Product = Program.productPriceManager.getEntitie(Convert.ToInt32(dgvProductPrice.Rows[dgvProductPrice.SelectedCells[0].RowIndex].Cells["id"].Value));
            troublePrice.Date = DateTime.Now;
            Program.troublePriceManager.AddEntities(troublePrice);
            refreshData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

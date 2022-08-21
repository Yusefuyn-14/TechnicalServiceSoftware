using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSS.Tools;

namespace TSS.UserInterface.Management.Show
{
    public partial class TroubleListForm : Form
    {
        public TroubleListForm()
        {
            InitializeComponent();
            dgvColumnAdd();
        }

        int TotalItem = 0, selectedItem = 0;
        private void ListTroubles()
        {
            listToDgv(Program.troubleManager.getAllEntities());
        }

        private void ListStatusOkTrouble()
        {
            listToDgv(Program.troubleManager.GetAllEntitiesByFiltered(t => t.Status >= 3));
        }

        private void ListStatusNotOkTrouble()
        {
            listToDgv(Program.troubleManager.GetAllEntitiesByFiltered(t => t.Status <= 2));
        }

        private void dgvColumnAdd()
        {
            dgvTrouble.Columns.Clear();
            dgvTrouble.Columns.Add("ID", "ID");
            dgvTrouble.Columns.Add("Description", "Açıklama");
            dgvTrouble.Columns.Add("Customer", "Müşteri");
            dgvTrouble.Columns.Add("Interested", "İlgili Personel");
            //dgvTrouble.Columns.Add("Hardware", "İlgili Cihaz");
            dgvTrouble.Columns.Add("Title", "Başlık");
            dgvTrouble.Columns.Add("Date", "Oluşturulma Tarihi");
            dgvTrouble.Columns.Add("Status", "Statü");

            dgvTrouble.Columns[0].Visible = false;
            dgvTrouble.Columns[4].Visible = false;
            //dgvTheme();
        }

        private void listToDgv(List<TSS.Entities.Concretes.Troubles> troubleList)
        {
            dgvTrouble.Rows.Clear();
            foreach (var item in troubleList)
            {
                dgvTrouble.Rows.Add(new string[] {
                    item.ID.ToString(),
                    item.Title,
                    item.Customer.Name + " " + item.Customer.LastName,
                    item.Interested.FirstName + " " + item.Interested.LastName,
                    //item.DevicesID.Name,
                    item.Description,
                    item.Date.ToString(),
                    Program.troubleStatusManager.GetEntitieByFiltered(t => t.ID == item.Status).StatusComment
                });
            }
            TotalItem = dgvTrouble.Rows.Count;
            lblSelectedItem.Text = string.Format("Total obje sayısı {0} seçilen obje {1}", TotalItem, selectedItem);
        }



        private void TroubleForm_Load(object sender, EventArgs e)
        {
            dgvTrouble.DefaultCellStyle.ForeColor = Color.White;
            dgvTrouble.DefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            ListTroubles();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text))
                listToDgv(Program.troubleManager.GetAllEntitiesByFiltered(t => t.Title.ToLower().Contains(txtSearch.Text.ToLower())));
            else
                ListTroubles();
        }

        private void btnAddTrouble_Click(object sender, EventArgs e)
        {
            Add.TroubleAddForm troubleForm = new Add.TroubleAddForm();
            if (troubleForm.ShowDialog() == DialogResult.OK)
            {
                ListTroubles();
            }
        }

        private void btnDeleteTrouble_Click(object sender, EventArgs e)
        {
            Program.troubleManager.DeleteEntities(selectedItem);
            ListTroubles();
        }

        private void btnUpdateTrouble_Click(object sender, EventArgs e)
        {
            if (lblSelectedItem.Text == "secilenid")
            {
                Dialog.MessageDialog dialog = new Dialog.MessageDialog("Arıza seçilmemiş.", "Hata", Dialog.MessageDialog.TypeEnum.Hata);
                dialog.ShowDialog();
                return;
            }
            Management.Add.TroubleAddForm productAddForm = new Add.TroubleAddForm(selectedItem.ToString());
            if (productAddForm.ShowDialog() == DialogResult.OK)
                ListTroubles();
        }

        private void dgvTrouble_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedItem = Convert.ToInt32(dgvTrouble.CurrentRow.Cells[0].Value.ToString());
            lblSelectedItem.Text = string.Format("Total obje sayısı {0} seçilen obje {1}",TotalItem,selectedItem);
        }

        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            if (lblSelectedItem.Text == "secilenid")
            {
                new Dialog.MessageDialog("Herhangi bir arıza seçilmemiş.", "Hata").ShowDialog();
                return;
            }
            if (new Add.TroubleStatusChangeForm(Convert.ToInt32(selectedItem)).ShowDialog() == DialogResult.OK)
                ListTroubles();
        }

        private void btnViewTrouble_Click(object sender, EventArgs e)
        {
            if (lblSelectedItem.Text == "secilenid")
            {
                new Dialog.MessageDialog("Herhangi bir arıza seçilmemiş.", "Hata").ShowDialog();
                return;
            }
            Theme.FormReDesign(new TroubleViewForm(selectedItem)).ShowDialog();
        }

        private void btnTroublePrice_Click(object sender, EventArgs e)
        {
            Add.TroublePriceAdd troublePriceAdd = new Add.TroublePriceAdd(Convert.ToInt32(dgvTrouble.CurrentRow.Cells[0].Value.ToString()));
            troublePriceAdd.ShowDialog();
        }

        private void btnTroubles_Click(object sender, EventArgs e)
        {
            ListTroubles();
        }

        private void btnFinishedTrouble_Click(object sender, EventArgs e)
        {
            ListStatusOkTrouble();
        }

        private void btnNotFinishedTrouble_Click(object sender, EventArgs e)
        {
            ListStatusNotOkTrouble();
        }

        private void dgvTheme()
        {
            dgvTrouble.BorderStyle = BorderStyle.None;
            dgvTrouble.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 56, 56);
            dgvTrouble.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTrouble.DefaultCellStyle.SelectionBackColor = Color.Maroon;
            dgvTrouble.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvTrouble.BackgroundColor = Color.FromArgb(28, 28, 28);

            dgvTrouble.EnableHeadersVisualStyles = false;
            dgvTrouble.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTrouble.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvTrouble.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}

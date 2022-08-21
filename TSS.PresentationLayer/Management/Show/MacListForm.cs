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
    public partial class MacListForm : Form
    {
        public MacListForm()
        {
            InitializeComponent();
        }

        private void refreshData()
        {
            dgvMacList.DataSource = Program.macListManager.getAllEntities();
            //comboBox1.DataSource = Program.hardwareManager.getAllEntities().Find(x => x.Unit.ID == 4 || x.Unit.ID == 5 || x.Unit.ID == 11);
            comboBox1.DisplayMember = "Producer" + " " + "Name" + " " + "Model";
            comboBox1.ValueMember = "ID";
        }

        private void MacListForm_Load(object sender, EventArgs e)
        {
            dgvMacList.DefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            refreshData();

        }

        private void dgvMacList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvMacList.CurrentRow.Cells[0].Value.ToString();
            txtMac.Text = dgvMacList.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Entities.Concretes.Mac_Address newMac = new Entities.Concretes.Mac_Address() { HardwaresID = Program.hardwareManager.GetEntitieByFiltered(t => t.ID == Convert.ToInt32(comboBox1.SelectedValue)), Mac = txtMac.Text };
            Program.macListManager.AddEntities(newMac);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Program.macListManager.DeleteEntities(Convert.ToInt32(txtID.Text));
        }
    }
}

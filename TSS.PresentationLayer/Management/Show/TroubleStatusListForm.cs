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
    public partial class TroubleStatusListForm : Form
    {
        public TroubleStatusListForm()
        {
            InitializeComponent();
        }

        private void refreshData()
        {
            dgvTroubleStatus.DataSource = Program.troubleStatusManager.getAllEntities();
        }

        private void TroubleStatusListForm_Load(object sender, EventArgs e)
        {
            dgvTroubleStatus.DefaultCellStyle.ForeColor = Color.White;
            dgvTroubleStatus.DefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            refreshData();
        }

        private void dgvTroubleStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dgvTroubleStatus.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dgvTroubleStatus.CurrentRow.Cells[1].Value.ToString();
            if (dgvTroubleStatus.CurrentRow.Cells[2].Value.ToString() == "1") radioButton1.Checked = true;
            else radioButton2.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int status = 1;
            if (!radioButton1.Checked)
                status = 0;
            Program.troubleStatusManager.AddEntities(new Entities.Concretes.Troubles_Status() { Statu = status, StatusComment = textBox1.Text });
            textBox1.Text = "";
            refreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Program.troubleStatusManager.DeleteEntities(Convert.ToInt32(label1.Text));
            refreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int status = 1;
            if (!radioButton1.Checked)
                status = 0;
            Program.troubleStatusManager.UpdateEntities(Convert.ToInt32(label1.Text), new Entities.Concretes.Troubles_Status() { Statu = status, StatusComment = textBox1.Text });
            refreshData();
        }
    }
}

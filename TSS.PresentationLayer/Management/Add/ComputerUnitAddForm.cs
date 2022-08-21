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
    public partial class ComputerUnitAddForm : Form
    {
        public ComputerUnitAddForm()
        {
            InitializeComponent();
        }

        private void refreshData() {
            dgvComputerUnit.Rows.Clear();
            foreach (var item in Program.computerUnitManager.getAllEntities())
                dgvComputerUnit.Rows.Add(new string[] { item.ID.ToString(),item.Name,item.Abbreviation });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entities.Concretes.Computer_Unit unit = new Entities.Concretes.Computer_Unit() { Name = txtName.Text, Abbreviation = txtAbbreviation.Text };
            Program.computerUnitManager.AddEntities(unit);
            refreshData();
        }

        private void btnUnitUpdate_Click(object sender, EventArgs e)
        {
            Entities.Concretes.Computer_Unit unit = new Entities.Concretes.Computer_Unit() { Name = txtName.Text, Abbreviation = txtAbbreviation.Text };
            Program.computerUnitManager.UpdateEntities(Convert.ToInt32(label1.Text),unit);
            refreshData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Program.computerUnitManager.DeleteEntities(Convert.ToInt32(dgvComputerUnit.CurrentRow.Cells[0].Value.ToString()));
            refreshData();

        }

        private void dgvComputerUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dgvComputerUnit.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvComputerUnit.CurrentRow.Cells[1].Value.ToString();
            txtAbbreviation.Text = dgvComputerUnit.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComputerUnitAddForm_Load(object sender, EventArgs e)
        {
            dgvComputerUnit.DefaultCellStyle.BackColor = Color.FromArgb(28,28,28);
            refreshData();

        }
    }
}

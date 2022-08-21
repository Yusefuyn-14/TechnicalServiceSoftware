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
    public partial class DevicesListForm : Form
    {
        int TotalObj = 0, selectedObj = 0;
        public DevicesListForm()
        {
            InitializeComponent();
        }

        public void dataRefresh()
        {
            List<TSS.Entities.Concretes.Devices> devicesList = Program.deviceManager.getAllEntities(); 
            dgvDevices.DataSource = devicesList;
            TotalObj = devicesList.Count();
        }

        private void DevicesListForm_Load(object sender, EventArgs e)
        {
            dataRefresh();
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            Program.deviceManager.AddEntities(new Entities.Concretes.Devices() { Name = textBox1.Text,Model=textBox2.Text,Producer = textBox3.Text });
            dataRefresh();

        }

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
            Program.deviceManager.DeleteEntities(Convert.ToInt32(dgvDevices.CurrentRow.Cells[0].Value.ToString()));
            dataRefresh();
        }

        private void btnViewDevice_Click(object sender, EventArgs e)
        {
            TSS.Tools.Theme.FormReDesign(new DeviceForm(Convert.ToInt32(dgvDevices.CurrentRow.Cells[0].Value.ToString()))).ShowDialog();
        }

        private void dgvDevices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedObj = Convert.ToInt32(dgvDevices.CurrentRow.Cells[0].Value.ToString());
        }
    }
}

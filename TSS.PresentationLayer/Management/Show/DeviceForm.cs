using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSS.UserInterface.Management.Show
{
    public partial class DeviceForm : Form
    {
        TSS.Entities.Concretes.Devices devices = null;

        public DeviceForm(int devicesID)
        {
            InitializeComponent();
            devices = Program.deviceManager.GetEntitieByFiltered(x => x.ID == devicesID);
        }

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            txtHardwareName.Text = devices.Name;
            txtHardwareCompany.Text = devices.Producer;
            txtHardwareModel.Text = devices.Model;
            txtUnit.Text = "Bilgisayar";
            dataGridView1.DataSource = Program.devicesHardwareManager.GetAllEntitiesByFiltered(x => x.DevID == devices.ID);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[9].Visible = false;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

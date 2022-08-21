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
    public partial class HardwareTypeListForm : Form
    {
        public HardwareTypeListForm()
        {
            InitializeComponent();
        }
        private void refreshData() {
            listBox1.DataSource = Program.hardwareTypeManager.getAllEntities();
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";
        }

        private void HardwareTypeListForm_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entities.Concretes.Hardwares_Type hardwareType = new Entities.Concretes.Hardwares_Type() { HardwaresTypeName = textBox1.Text };
            Program.hardwareTypeManager.AddEntities(hardwareType);
            textBox1.Text = "";
            refreshData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.hardwareTypeManager.DeleteEntities(Convert.ToInt32(listBox1.SelectedValue.ToString()));
            refreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class ComponentAddForm : Form
    {
        public ComponentAddForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Program.componentManager.AddEntities(new Entities.Concretes.Components() { 
                CompTypeID = Convert.ToInt32(comboBox1.SelectedValue),
                CompName=txtName.Text,
                CompDesc=txtDescription.Text
            });
        }

        private void ComponentAddForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Program.componentTypeManager.getAllEntities();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";
        }
    }
}

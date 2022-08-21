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
namespace TSS.UserInterface.Management
{
    public partial class ApplicationSettings : Form
    {
        public ApplicationSettings()
        {
            InitializeComponent();
        }

        private void showForm(Form frm) {
            Theme.FormReDesign(frm);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showForm(new Management.Show.ProductCategoryListForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showForm(new Management.Show.TroubleStatusListForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showForm(new Management.Show.MacListForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showForm(new Management.Show.CurrencyListForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showForm(new Add.ComputerUnitAddForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showForm(new Management.Show.HardwareTypeListForm());
        }
    }
}

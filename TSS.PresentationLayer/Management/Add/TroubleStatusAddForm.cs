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
    public partial class TroubleStatusAddForm : Form
    {
        public TroubleStatusAddForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Entities.Concretes.Troubles_Status troubleStatus = new Entities.Concretes.Troubles_Status() { StatusComment = textBox1.Text, Statu = radioButton1.Checked == true ? 1 : 0 };
            Program.troubleStatusManager.AddEntities(troubleStatus);
        }
    }
}

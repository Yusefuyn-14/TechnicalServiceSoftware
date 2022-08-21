using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSS.UserInterface.Management.UserControls
{
    public partial class HardwareDriveObj : UserControl
    {
        string _Description="", _Data = "";
        public HardwareDriveObj(string Description,string Data)
        {
            InitializeComponent();
            _Description = Description;
            _Data = Data;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label2.Text);
        }

        private void HardwareDriveObj_Load(object sender, EventArgs e)
        {
            label1.Text = _Description;
            label2.Text = _Data;
        }
    }
}

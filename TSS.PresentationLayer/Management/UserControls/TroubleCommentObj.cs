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
    public partial class TroubleCommentObj : UserControl
    {
        int CommenterID; DateTime Date; string Comment;
        public TroubleCommentObj(int _CommenterID, DateTime _Date, string _Comment)
        {
            InitializeComponent();
            CommenterID = _CommenterID;
            Date = _Date;
            Comment = _Comment;
        }

        private void TroubleCommentObj_Load(object sender, EventArgs e)
        {
            var commenterEmployee = Program.employeeManager.GetEntitieByFiltered(t => t.ID == CommenterID);
            if (commenterEmployee != null)
                lblUser.Text += " " + commenterEmployee.FirstName + " " + commenterEmployee.LastName;
            else
                lblUser.Text += " Silinmiş Hesap";
            lblDate.Text += " " + Date.ToString();
            richTextBox1.LoadFile("DataBase\\TroubleComment\\" + Comment, RichTextBoxStreamType.RichText);
        }
    }
}

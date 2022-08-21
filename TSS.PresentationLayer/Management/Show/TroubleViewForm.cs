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
    public partial class TroubleViewForm : Form
    {
        TSS.Entities.Concretes.Troubles trouble = null;
        List<Entities.Concretes.Troubles_Comment> troubleComment = null;
        public TroubleViewForm(int troubleID)
        {
            InitializeComponent();
            trouble = Program.troubleManager.GetEntitieByFiltered(t => t.ID == troubleID);
            troubleComment = Program.troubleCommentManager.GetAllEntitiesByFiltered(t => t.TroubleID.ID == trouble.ID);
            trouble.Customer = Program.customerManager.GetEntitieByFiltered(t => t.ID == trouble.Customer.ID);
            trouble.Interested = Program.employeeManager.GetEntitieByFiltered(t => t.ID == trouble.Interested.ID);
        }

        private void TroubleViewForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = trouble.Title;
            txtCustomer.Text = trouble.Customer.Name + " " + trouble.Customer.LastName;
            txtEmployee.Text = trouble.Interested.FirstName + " " + trouble.Interested.LastName;
            txtDate.Text = trouble.Date.ToString();
            rtfTrouble.LoadFile("DataBase\\Trouble\\" + trouble.Description, RichTextBoxStreamType.RichText);
            int say = 0;
            foreach (var item in troubleComment)
            {
                UserControls.TroubleCommentObj troubleCommentObject = new UserControls.TroubleCommentObj(item.CommenterID.ID, item.Date, item.Comment);
                troubleCommentObject.Location = new Point(6, 255 * say);
                say++;
                troubleCommentObject.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                pnlTroubleStatus.Controls.Add(troubleCommentObject);
                troubleCommentObject.Show();
            }
            DataGridView dgvTroublePrice = new DataGridView();
            dgvTroublePrice.DataSource = Program.troublePriceManager.JoinTroubleProductTable(trouble.ID);
            dgvTroublePrice.Size = new Size(759, 300);
            dgvTroublePrice.Location = new Point(6,say * 255);
            dgvTroublePrice.AllowUserToAddRows = false;
            pnlTroubleStatus.Controls.Add(dgvTroublePrice);
           
            int total = 0;
            for (int i = 0; i < dgvTroublePrice.Rows.Count; i++)
            {
                total += Convert.ToInt32(dgvTroublePrice.Rows[i].Cells[2].Value.ToString());
            }
            lblTotalPrice.Text += " " +  total.ToString() + " ₺ ";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

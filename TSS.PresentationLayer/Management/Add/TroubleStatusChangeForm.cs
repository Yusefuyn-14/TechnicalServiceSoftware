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
    public partial class TroubleStatusChangeForm : Form
    {
        Entities.Concretes.Troubles trouble = new Entities.Concretes.Troubles();
        public TroubleStatusChangeForm(int troubleID)
        {
            InitializeComponent();
            trouble = Program.troubleManager.GetEntitieByFiltered(t => t.ID == troubleID);
        }

        private void refreshStatus()
        {
            comboStatus.Items.Clear();
            comboStatus.DataSource = Program.troubleStatusManager.getAllEntities();
            comboStatus.DisplayMember = "StatusComment";
            comboStatus.ValueMember = "ID";
        }

        private void TroubleStatusChangeForm_Load(object sender, EventArgs e)
        {
            refreshStatus();

            txtTitle.Text = trouble.Title;
            txtCustomer.Text = trouble.Customer.Name + " " + trouble.Customer.LastName;
            txtEmployee.Text = trouble.Interested.FirstName + " " + trouble.Interested.LastName;
            rtfTrouble.LoadFile("DataBase\\Trouble\\" + trouble.Description, RichTextBoxStreamType.RichText);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string commentHash = Program.hasher.Hashed(rtfComment.Text);
            Program.troubleCommentManager.AddEntities(new Entities.Concretes.Troubles_Comment() { 
                Date = DateTime.Now,
                CommenterID = new Entities.Concretes.Employees() { ID = Program.EmployeeID },
                TroubleID = new Entities.Concretes.Troubles() { ID = trouble.ID },
                Comment = commentHash });
            Program.troubleManager.UpdateEntities(trouble.ID, new Entities.Concretes.Troubles()
            {
                Interested = trouble.Interested,
                Customer = trouble.Customer,
                Date = trouble.Date,
                Description = trouble.Description,
                Title = trouble.Title,
                Status = Convert.ToInt32(comboStatus.SelectedValue)
            });
            rtfComment.SaveFile("DataBase\\TroubleComment\\" + commentHash, RichTextBoxStreamType.RichText);
        }

        private void btnPictureSelected_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Picture File (*.png)|*.png|Picture File (*.jpg)|*.jpg|Picture File (*.jpeg)|*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Clipboard.SetImage(new Bitmap(openFileDialog.FileName));
                rtfComment.Paste();
            }
        }

        private void btnFontSelected_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                rtfComment.Font = fontDialog.Font;
        }
    }
}

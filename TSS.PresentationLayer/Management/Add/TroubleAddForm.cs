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
    public partial class TroubleAddForm : Form
    {
        string id = null;
        public TroubleAddForm(string _id = null)
        {
            InitializeComponent();
            id = _id;
        }

        private void btnFontSelected_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fontDialog.Font;
        }

        private void btnPictureSelected_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Picture File (*.png)|*.png|Picture File (*.jpg)|*.jpg|Picture File (*.jpeg)|*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Clipboard.SetImage(new Bitmap(openFileDialog.FileName));
                richTextBox1.Paste();
            }
        }

        private void comboDataRefresh()
        {
            List<BasicCustomer> customersList = new List<BasicCustomer>();
            foreach (var item in Program.customerManager.getAllEntities())
            {
                BasicCustomer customer = new BasicCustomer() { ID = item.ID, Name = item.Name + " " + item.LastName };
                customersList.Add(customer);
            }
            comboBox1.Items.Clear();
            comboBox1.DataSource = customersList;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";
        }

        private void TroubleAddForm_Load(object sender, EventArgs e)
        {
            comboDataRefresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(Application.StartupPath + "\\DataBase\\Trouble\\" + Program.hasher.Hashed(richTextBox1.Text), RichTextBoxStreamType.RichText);
            Entities.Concretes.Troubles trouble = new Entities.Concretes.Troubles()
            {
                Customer = Program.customerManager.GetEntitieByFiltered(t => t.ID == Convert.ToInt32(comboBox1.SelectedValue.ToString())),
                Description = Program.hasher.Hashed(richTextBox1.Text),
                Interested = Program.employeeManager.GetEntitieByFiltered(t => t.ID == Program.EmployeeID),
                Title = textBox1.Text,
                Date = DateTime.Now,
                Status = 0
            };
            Program.troubleManager.AddEntities(trouble);
        }
    }

    class BasicCustomer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

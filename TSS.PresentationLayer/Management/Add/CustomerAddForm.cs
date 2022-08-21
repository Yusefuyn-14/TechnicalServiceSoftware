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
    public partial class CustomerAddForm : Form
    {
        

        public CustomerAddForm(string id = "")
        {
            InitializeComponent();
            txtID.Text = id;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" || txtMail.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "")
            {
                Dialog.MessageDialog messageBox = new Dialog.MessageDialog("Herhangi bir veri boş olamaz.", "Hata ;(", Dialog.MessageDialog.TypeEnum.Hata, this.Width);
                messageBox.ShowDialog();
                return;
            }
            if (txtID.Text == "")
            {
                Entities.Concretes.Customers customer = new Entities.Concretes.Customers() { Name = txtName.Text, LastName = txtLastName.Text, Address = txtAddress.Text, Mail = txtMail.Text, PhoneNumber = txtPhoneNumber.Text };
                Program.customerManager.AddEntities(customer);
            }
            else
            {
                Entities.Concretes.Customers customer = new Entities.Concretes.Customers() { Name = txtName.Text, LastName = txtLastName.Text, Address = txtAddress.Text, Mail = txtMail.Text, PhoneNumber = txtPhoneNumber.Text };
                Program.customerManager.UpdateEntities(Convert.ToInt32(txtID.Text), customer);
            }

            this.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtID.Text != "secilenid")
            {
                label6.Text = "Müşteri Güncelle";
                Entities.Concretes.Customers customer = Program.customerManager.GetEntitieByFiltered(c => c.ID == Convert.ToInt32(txtID.Text));
                txtName.Text = customer.Name;
                txtLastName.Text = customer.LastName;
                txtAddress.Text = customer.Address;
                txtMail.Text = customer.Mail;
                txtPhoneNumber.Text = customer.PhoneNumber;
            }

        }
    }
}

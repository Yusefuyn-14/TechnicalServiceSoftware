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
    public partial class EmployeeAddForm : Form
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
        }
        public EmployeeAddForm(string data)
        {
            InitializeComponent();
            txtID.Text = data;
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
                Entities.Concretes.Employees employee = new Entities.Concretes.Employees()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    HomeNumber = txtHomeNumber.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Mail = txtMail.Text,
                    BirthOfDate = dtDate.Text,
                    BirthOfPlace = txtPlace.Text
                };
                Program.employeeManager.AddEntities(employee);
            }
            else
            {
                Entities.Concretes.Employees employee = new Entities.Concretes.Employees()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    HomeNumber = txtHomeNumber.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Mail = txtMail.Text,
                    BirthOfDate = dtDate.Text,
                    BirthOfPlace = txtPlace.Text
                };
                Program.employeeManager.UpdateEntities(Convert.ToInt32(txtID.Text), employee);
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtID.Text != "secilenid")
            {
                label6.Text = "Çalışan Güncelle";
                Entities.Concretes.Employees employee = Program.employeeManager.GetEntitieByFiltered(c => c.ID == Convert.ToInt32(txtID.Text));
                txtName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtAddress.Text = employee.Address;
                dtDate.Value = DateTime.Parse(employee.BirthOfDate);
                txtPlace.Text = employee.BirthOfPlace;
                txtPhoneNumber.Text = employee.PhoneNumber;
                txtHomeNumber.Text = employee.HomeNumber;
                txtMail.Text = employee.Mail;
            }
        }
    }
}

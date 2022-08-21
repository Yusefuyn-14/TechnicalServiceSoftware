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
    public partial class ProductAddForm : Form
    {
        int id = -1;

        public ProductAddForm(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            this.Close();



            if (txtName.Text == "" || txtBrand.Text == "" || txtModel.Text == "" || comboCategory.SelectedIndex == -1)
            {
                Dialog.MessageDialog messageBox = new Dialog.MessageDialog("İsim,Model,Marka,Kategori verilerinden bir veya birden fazlası boş olamaz.", "Hata ;(", Dialog.MessageDialog.TypeEnum.Hata, this.Width);
                messageBox.ShowDialog();
                return;
            }

            int idd = -1;
            if (comboCategory.Text == "Ürün")
                idd = Convert.ToInt32(comboHardwareType.SelectedValue);
            Entities.Concretes.Products product = new Entities.Concretes.Products()
            {
                Name = txtName.Text,
                Brand = txtBrand.Text,
                CategoryID = new Entities.Concretes.Products_Category() { ID = Convert.ToInt32(comboCategory.SelectedValue) },
                Model = txtModel.Text,
                HardwareTypeID = new Entities.Concretes.Hardwares_Type() { ID = idd }
            };
            if (id == -1)
                Program.productManager.AddEntities(product);
            else
                Program.productManager.UpdateEntities(id, product);
            this.Close();
        }

        List<Entities.Concretes.Products_Category> categoryList = new List<Entities.Concretes.Products_Category>();
        Entities.Concretes.Products_Category selectedCategory = new Entities.Concretes.Products_Category();

        private void listCategory()
        {
            comboCategory.Items.Clear();
            foreach (Entities.Concretes.Products_Category item in Program.productCategoryManager.getAllEntities())
                categoryList.Add(item);

            comboHardwareType.DataSource = new TSS.Tools.ListToDataTableConverter().ToDataTable(Program.hardwareTypeManager.getAllEntities());
            comboHardwareType.ValueMember = "ID";
            comboHardwareType.DisplayMember = "Name";

            comboCategory.DataSource = new TSS.Tools.ListToDataTableConverter().ToDataTable(Program.productCategoryManager.getAllEntities());
            comboCategory.ValueMember = "ID";
            comboCategory.DisplayMember = "Name";
        }



        private void Product_Load(object sender, EventArgs e)
        {
            listCategory();

            if (id != -1)
            {
                label6.Text = "Ürün Güncelle";
                Entities.Concretes.Products product = Program.productManager.GetEntitieByFiltered(p => p.ID == id);
                txtID.Text = product.ID.ToString();
                txtName.Text = product.Name;
                txtBrand.Text = product.Brand;
                txtModel.Text = product.Model;
                comboCategory.SelectedIndex = product.CategoryID.ID;
                if (product.HardwareTypeID.ID != -1)
                    comboHardwareType.SelectedValue = product.HardwareTypeID;
                else
                    comboHardwareType.SelectedIndex = 0;
            }

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = categoryList[comboCategory.SelectedIndex];
            if (comboCategory.SelectedIndex != 0)
                comboHardwareType.Enabled = false;
            else
                comboHardwareType.Enabled = true;
        }
    }
}

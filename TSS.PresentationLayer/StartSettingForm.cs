using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSS.UserInterface
{
    public partial class StartSettingForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public StartSettingForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("Images\\Settings.gif");
            comboDatabaseType.Items.Add("SQLite");
            comboLogType.Items.Add("File");
            comboHashType.Items.Add("MD5");
            comboHashType.Items.Add("SHA1");
            txtHost.Text = Properties.Settings.Default.Host.ToString();
            txtDataBase.Text = Properties.Settings.Default.DataBase.ToString();
            string dbType = Properties.Settings.Default.dbType.ToString();
            string hashType = Properties.Settings.Default.hashType.ToString();
            string logType = Properties.Settings.Default.logType.ToString();

            if (dbType == "SQLite")
                comboDatabaseType.SelectedIndex = 0;

            if (logType == "File")
                comboLogType.SelectedIndex = 0;

            if (hashType == "MD5")
                comboHashType.SelectedIndex = 0;
            else if (hashType == "SHA1")
                comboHashType.SelectedIndex = 1;


            comboDatabaseType.SelectedIndex = 0;
            comboLogType.SelectedIndex = 0;
            comboHashType.SelectedIndex = 0;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Host = txtHost.Text;
            Properties.Settings.Default.DataBase = txtDataBase.Text;
            Properties.Settings.Default.dbType = comboDatabaseType.Text;
            Properties.Settings.Default.logType = comboLogType.Text;
            Properties.Settings.Default.hashType = comboHashType.Text;
            Properties.Settings.Default.Save();
            Dialog.MessageDialog mDialog = new Dialog.MessageDialog("Ayarlar Kaydedildi...", "*_* Tamam",Dialog.MessageDialog.TypeEnum.Bilgi);
            mDialog.ShowDialog();
            this.Close();
        }
    }
}

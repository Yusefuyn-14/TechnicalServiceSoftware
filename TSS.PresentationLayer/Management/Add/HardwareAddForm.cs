using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSS.Entities.Concretes;

namespace TSS.UserInterface.Management.Add
{
    public partial class HardwareAddForm : Form
    {
        public HardwareAddForm()
        {
            InitializeComponent();

            dgvHardwareDriverID.Columns.Add("C1","Numara");
            dgvHardwareDriverID.Columns.Add("C2", "Donanım Sürücü ID");
            dgvHardwareDriverID.Columns.Add("C3", "Donanım Sürücü Açıklama");

            dgvSize.Columns.Add("C1", "Numara");
            dgvSize.Columns.Add("C2", "Boyut");
            dgvSize.Columns.Add("C3", "BoyutTipi");
            dgvSize.Columns.Add("C4", "Açıklama");
        }

        List<Hardwares_Size> HardwareSizeList = new List<Hardwares_Size>();
        List<Hardwares_Drive> HardwareDriveList = new List<Hardwares_Drive>();

        public HardwareAddForm(int HardwareID) {
            InitializeComponent();

            label6.Text = "Donanım Düzenle";

            HardwareSizeList.AddRange(Program.hardwareSizeManager.GetAllEntitiesByFiltered(hs => hs.ID == HardwareID));
            dgvSize.DataSource = Program.hardwareSizeManager.GetAllEntitiesByFiltered(hs => hs.ID == HardwareID);

            HardwareDriveList.AddRange(Program.hardwareDriveManager.GetAllEntitiesByFiltered(hs => hs.ID == HardwareID));
            dgvHardwareDriverID.DataSource = Program.hardwareDriveManager.GetAllEntitiesByFiltered(hs => hs.ID == HardwareID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DataRefresh()
        {
            cbHardwareType.DataSource = Program.hardwareTypeManager.getAllEntities();
            cbHardwareType.ValueMember = "ID";
            cbHardwareType.DisplayMember = "Name";

            cbSizeType.DataSource = Program.computerUnitManager.getAllEntities();
            cbSizeType.ValueMember = "ID";
            cbSizeType.DisplayMember = "Name";
        }

        private void HardwareAddForm_Load(object sender, EventArgs e)
        {
            DataRefresh();
            dgvTheme();
        }

        private void dgvTheme()
        {
            dgvSize.BorderStyle = BorderStyle.None;
            dgvSize.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 56, 56);
            dgvSize.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSize.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 134, 138);
            dgvSize.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSize.BackgroundColor = Color.FromArgb(28, 28, 28);

            dgvSize.EnableHeadersVisualStyles = false;
            dgvSize.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSize.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvSize.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvHardwareDriverID.BorderStyle = BorderStyle.None;
            dgvHardwareDriverID.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 56, 56);
            dgvHardwareDriverID.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHardwareDriverID.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 134, 138);
            dgvHardwareDriverID.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvHardwareDriverID.BackgroundColor = Color.FromArgb(28, 28, 28);

            dgvHardwareDriverID.EnableHeadersVisualStyles = false;
            dgvHardwareDriverID.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHardwareDriverID.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvHardwareDriverID.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Program.hardwareManager.AddEntities(new Hardwares() { Model = txtHardwareModel.Text, Name = txtHardwareName.Text, Producer = txtHardwareProducer.Text, HTID = Convert.ToInt32(cbHardwareType.SelectedValue) });
            Hardwares hardware = Program.hardwareManager.GetLastAddedHardware();
            if (dgvHardwareDriverID.Rows.Count > 0)
                foreach (DataGridViewRow item in dgvHardwareDriverID.Rows)
                    Program.hardwareDriveManager.AddEntities(new Hardwares_Drive() { Hardware = hardware, Description = item.Cells[2].Value.ToString(), Drive = item.Cells[1].Value.ToString() });
            if (dgvSize.Rows.Count > 0)
                foreach (DataGridViewRow item in dgvSize.Rows)
                    Program.hardwareSizeManager.AddEntities(new Hardwares_Size() { HardwaresID = hardware,Size =Convert.ToInt32(item.Cells[1].Value.ToString()),ComputerUnitID = Program.computerUnitManager.GetEntitieByFiltered(t => t.ID == Convert.ToInt32(item.Cells[2].Value.ToString())),Description = item.Cells[3].Value.ToString() });
        }

        private void btnAddHardwareDrive_Click(object sender, EventArgs e)
        {
            dgvHardwareDriverID.Rows.Add(new string[] { (dgvHardwareDriverID.Rows.Count + 1).ToString(), txtHardwareDriveID.Text, txtHardwareDriveDescription.Text });
        }

        private void btnAddHardwareSize_Click(object sender, EventArgs e)
        {
            dgvSize.Rows.Add(new string[] { (dgvSize.Rows.Count + 1).ToString(), numericSize.Value.ToString(), cbSizeType.SelectedValue.ToString(), txtSizeDescription.Text });
        }

        private void btnDeleteSelectedSize_Click(object sender, EventArgs e)
        {
            if (dgvSize.SelectedRows.Count != 0)
                dgvSize.Rows.RemoveAt(dgvSize.CurrentCell.RowIndex);
        }

        private void btnRemoveSelectedHardwareID_Click(object sender, EventArgs e)
        {
            if (dgvHardwareDriverID.SelectedRows.Count != 0)
                dgvHardwareDriverID.Rows.RemoveAt(dgvHardwareDriverID.CurrentCell.RowIndex);
        }


    }
}

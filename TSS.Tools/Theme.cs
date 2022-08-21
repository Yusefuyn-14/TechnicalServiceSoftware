using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSS.Tools
{
    public static class Theme
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

        //static public Color themeColor = Color.FromArgb(211, 211, 211);
        //static public Color backgroundColor = Color.FromArgb(51, 52, 53);

        static public Color themeColor = Color.FromArgb(51, 52, 53);
        static public Color backgroundColor = Color.FromArgb(211, 211, 211);

        static public void changeThemePanel(Panel pnl) {
            foreach (var pnlItem in pnl.Controls)
            {
                if (pnl.Name.IndexOf("_reverse") == -1)
                {
                    pnl.BackColor = backgroundColor;
                    pnl.ForeColor = themeColor;
                    if (pnlItem is Label)
                    {
                        Label lbl = (Label)pnlItem;
                        lbl.BackColor = backgroundColor;
                        lbl.ForeColor = themeColor;
                    }
                    else if (pnlItem is PictureBox)
                    {
                        PictureBox pb = (PictureBox)pnlItem;
                        pb.BackColor = themeColor;
                        pb.ForeColor = themeColor;
                    }
                    else if (pnlItem is Button)
                    {
                        Button btn = (Button)pnlItem;
                        btn.BackColor = backgroundColor;
                        btn.ForeColor = themeColor;
                    }
                    else if (pnlItem is NumericUpDown)
                    {
                        NumericUpDown nud = (NumericUpDown)pnlItem;
                        nud.BackColor = backgroundColor;
                        nud.ForeColor = themeColor;
                    }
                    else if (pnlItem is Panel)
                        changeThemePanel((Panel)pnlItem);
                }
                else if (pnl.Name.IndexOf("_reverse") != -1)
                {
                    if (pnlItem is Label)
                    {
                        Label lbl = (Label)pnlItem;
                        lbl.BackColor = themeColor;
                        lbl.ForeColor = backgroundColor;
                    }
                    else if (pnlItem is Button)
                    {
                        Button btn = (Button)pnlItem;
                        btn.BackColor = backgroundColor;
                        btn.ForeColor = themeColor;
                    }
                    else if (pnlItem is PictureBox)
                    {
                        PictureBox pb = (PictureBox)pnlItem;
                        pb.BackColor = themeColor;
                        pb.ForeColor = themeColor;
                    }
                    else if (pnlItem is Button)
                    {
                        Button btn = (Button)pnlItem;
                        btn.BackColor = backgroundColor;
                        btn.ForeColor = themeColor;
                    }
                    else if (pnlItem is Panel)
                        changeThemePanel((Panel)pnlItem);
                    pnl.BackColor = themeColor;
                    pnl.ForeColor = Color.White;
                }
            }
        }
        static public Form FormReDesign(Form form)
        {
            ChangeTheme(form);
            ChangeRegion(form);
            return form;
        }
        static public void ChangeTheme(Form form) {
            form.BackColor = backgroundColor;
            form.ForeColor = themeColor;
            foreach (var item in form.Controls)
            {
                if (item is Panel)
                    changeThemePanel((Panel)item);
                else if (item is DataGridView)
                {
                    dataGridViewChangeColor((DataGridView)item);
                }
                else if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.BackColor = themeColor;
                    btn.ForeColor = backgroundColor;
                    btn.FlatStyle = FlatStyle.Flat;
                }
                else if (item is Label)
                {
                    Label btn = (Label)item;
                    btn.BackColor = backgroundColor;
                    btn.ForeColor = themeColor;
                }
                else if (item is TextBox)
                {
                    TextBox btn = (TextBox)item;
                    btn.BackColor = themeColor;
                    btn.ForeColor = Color.White;
                }
                else if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    cb.BackColor = backgroundColor;
                    cb.ForeColor = themeColor;
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)item;
                    nud.BackColor = backgroundColor;
                    nud.ForeColor = themeColor;
                }
                else if (item is PictureBox)
                {
                    PictureBox pb = (PictureBox)item;
                    pb.BackColor = themeColor;
                    pb.ForeColor = themeColor;
                }
            }
        }
        public static void dataGridViewChangeColor(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 56, 56);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = themeColor;
            dgv.DefaultCellStyle.SelectionForeColor = backgroundColor;
            dgv.BackgroundColor = backgroundColor;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public static void ChangeRegion(Form form) {
           form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 20, 20));
        }

    }
}

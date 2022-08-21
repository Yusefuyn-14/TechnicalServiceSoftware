using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSS.UserInterface.Dialog
{
    public partial class MessageDialog : Form
    {
        public enum TypeEnum
        {
            Uyarı,
            Hata,
            Bilgi,
            Soru
        }

        string _Message = "", _Hood = "";
        private void MessageDialog_Load(object sender, EventArgs e)
        {
            label2.Text = _Message;
            label1.Text = _Hood;
        }

        public MessageDialog(string Message, string Hood, TypeEnum Type, int Width = 800)
        {
            InitializeComponent();
            _Message = Message;
            _Hood = Hood;
            switch (Type)
            {
                case TypeEnum.Uyarı:
                    pictureBox1.Image = new Bitmap(Application.StartupPath + @"\Images\Warning.gif");
                    break;
                case TypeEnum.Hata:
                    pictureBox1.Image = new Bitmap(Application.StartupPath + @"\Images\Error.gif");
                    break;
                case TypeEnum.Bilgi:
                    pictureBox1.Image = new Bitmap(Application.StartupPath + @"\Images\Info.gif");
                    break;
                case TypeEnum.Soru:
                    pictureBox1.Image = new Bitmap(Application.StartupPath + @"\Images\Question.gif");
                    break;
                default:
                    break;
            }

            Size = new Size(Width, this.Size.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public MessageDialog(string Message, string Hood, int Width = 800)
        {
            InitializeComponent();
            _Message = Message;
            _Hood = Hood;
            Size = new Size(Width, this.Size.Height);
        }
    }
}

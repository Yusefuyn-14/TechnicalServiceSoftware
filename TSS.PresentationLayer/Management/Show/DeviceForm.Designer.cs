
namespace TSS.UserInterface.Management.Show
{
    partial class DeviceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceForm));
            this.pnlControl_reverse = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlComponent = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlHardwareSize = new System.Windows.Forms.Panel();
            this.pnlHardwareDrivers = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUnit = new System.Windows.Forms.Label();
            this.txtHardwareModel = new System.Windows.Forms.Label();
            this.txtHardwareCompany = new System.Windows.Forms.Label();
            this.txtHardwareName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlControl_reverse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlComponent.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl_reverse
            // 
            this.pnlControl_reverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.pnlControl_reverse.Controls.Add(this.btnClose);
            this.pnlControl_reverse.Controls.Add(this.label4);
            this.pnlControl_reverse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl_reverse.Location = new System.Drawing.Point(0, 0);
            this.pnlControl_reverse.Name = "pnlControl_reverse";
            this.pnlControl_reverse.Size = new System.Drawing.Size(800, 50);
            this.pnlControl_reverse.TabIndex = 27;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(755, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 26;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(800, 50);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cihaz Görüntüle";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlComponent
            // 
            this.pnlComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.pnlComponent.Controls.Add(this.dataGridView1);
            this.pnlComponent.Controls.Add(this.panel15);
            this.pnlComponent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComponent.Location = new System.Drawing.Point(0, 162);
            this.pnlComponent.Name = "pnlComponent";
            this.pnlComponent.Size = new System.Drawing.Size(800, 196);
            this.pnlComponent.TabIndex = 38;
            // 
            // panel15
            // 
            this.panel15.AutoSize = true;
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.panel15.Controls.Add(this.label12);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(223, 196);
            this.panel15.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 23);
            this.label12.TabIndex = 31;
            this.label12.Text = "Kullanılan Donanımlar :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlHardwareSize
            // 
            this.pnlHardwareSize.AutoSize = true;
            this.pnlHardwareSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.pnlHardwareSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHardwareSize.Location = new System.Drawing.Point(0, 162);
            this.pnlHardwareSize.Name = "pnlHardwareSize";
            this.pnlHardwareSize.Size = new System.Drawing.Size(800, 0);
            this.pnlHardwareSize.TabIndex = 37;
            // 
            // pnlHardwareDrivers
            // 
            this.pnlHardwareDrivers.AutoSize = true;
            this.pnlHardwareDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.pnlHardwareDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHardwareDrivers.Location = new System.Drawing.Point(0, 162);
            this.pnlHardwareDrivers.Name = "pnlHardwareDrivers";
            this.pnlHardwareDrivers.Size = new System.Drawing.Size(800, 0);
            this.pnlHardwareDrivers.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.txtUnit);
            this.panel3.Controls.Add(this.txtHardwareModel);
            this.panel3.Controls.Add(this.txtHardwareCompany);
            this.panel3.Controls.Add(this.txtHardwareName);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 112);
            this.panel3.TabIndex = 35;
            // 
            // txtUnit
            // 
            this.txtUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUnit.ForeColor = System.Drawing.Color.White;
            this.txtUnit.Location = new System.Drawing.Point(223, 84);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(577, 28);
            this.txtUnit.TabIndex = 32;
            this.txtUnit.Text = "Donanımın Markası";
            this.txtUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHardwareModel
            // 
            this.txtHardwareModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHardwareModel.ForeColor = System.Drawing.Color.White;
            this.txtHardwareModel.Location = new System.Drawing.Point(223, 56);
            this.txtHardwareModel.Name = "txtHardwareModel";
            this.txtHardwareModel.Size = new System.Drawing.Size(577, 28);
            this.txtHardwareModel.TabIndex = 31;
            this.txtHardwareModel.Text = "Donanımın Markası";
            this.txtHardwareModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHardwareCompany
            // 
            this.txtHardwareCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHardwareCompany.ForeColor = System.Drawing.Color.White;
            this.txtHardwareCompany.Location = new System.Drawing.Point(223, 28);
            this.txtHardwareCompany.Name = "txtHardwareCompany";
            this.txtHardwareCompany.Size = new System.Drawing.Size(577, 28);
            this.txtHardwareCompany.TabIndex = 30;
            this.txtHardwareCompany.Text = "Donanımın Markası";
            this.txtHardwareCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHardwareName
            // 
            this.txtHardwareName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHardwareName.ForeColor = System.Drawing.Color.White;
            this.txtHardwareName.Location = new System.Drawing.Point(223, 0);
            this.txtHardwareName.Name = "txtHardwareName";
            this.txtHardwareName.Size = new System.Drawing.Size(577, 28);
            this.txtHardwareName.TabIndex = 29;
            this.txtHardwareName.Text = "Donanımın Tam Adı";
            this.txtHardwareName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 112);
            this.panel2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Donanımın Türü :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cihazın Modeli :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cihazın Üretici Firması :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cihazın Adı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(226, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 191);
            this.dataGridView1.TabIndex = 29;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlComponent);
            this.Controls.Add(this.pnlHardwareSize);
            this.Controls.Add(this.pnlHardwareDrivers);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlControl_reverse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceForm";
            this.Load += new System.EventHandler(this.DeviceForm_Load);
            this.pnlControl_reverse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlComponent.ResumeLayout(false);
            this.pnlComponent.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl_reverse;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlComponent;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlHardwareSize;
        private System.Windows.Forms.Panel pnlHardwareDrivers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtUnit;
        private System.Windows.Forms.Label txtHardwareModel;
        private System.Windows.Forms.Label txtHardwareCompany;
        private System.Windows.Forms.Label txtHardwareName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
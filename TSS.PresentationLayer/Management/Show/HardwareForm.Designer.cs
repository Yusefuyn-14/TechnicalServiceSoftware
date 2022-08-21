namespace TSS.UserInterface.Management.Show
{
    partial class HardwareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardwareForm));
            this.pnlControl_reverse = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUnit = new System.Windows.Forms.Label();
            this.txtHardwareModel = new System.Windows.Forms.Label();
            this.txtHardwareCompany = new System.Windows.Forms.Label();
            this.txtHardwareName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHardwareDrivers = new System.Windows.Forms.Panel();
            this.pnlHardwareSize = new System.Windows.Forms.Panel();
            this.pnlComponent = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnComponentAdd = new System.Windows.Forms.Button();
            this.pnlControl_reverse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.pnlControl_reverse.TabIndex = 26;
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
            this.label4.Text = "Donanım Görüntüleme";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donanımın Modeli :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Donanımın Üretici Firması :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Donanımın Tam Adı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUnit);
            this.panel3.Controls.Add(this.txtHardwareModel);
            this.panel3.Controls.Add(this.txtHardwareCompany);
            this.panel3.Controls.Add(this.txtHardwareName);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 112);
            this.panel3.TabIndex = 28;
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
            this.label3.Location = new System.Drawing.Point(0, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Donanımın Türü :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlHardwareDrivers
            // 
            this.pnlHardwareDrivers.AutoSize = true;
            this.pnlHardwareDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHardwareDrivers.Location = new System.Drawing.Point(0, 162);
            this.pnlHardwareDrivers.Name = "pnlHardwareDrivers";
            this.pnlHardwareDrivers.Size = new System.Drawing.Size(800, 0);
            this.pnlHardwareDrivers.TabIndex = 29;
            // 
            // pnlHardwareSize
            // 
            this.pnlHardwareSize.AutoSize = true;
            this.pnlHardwareSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHardwareSize.Location = new System.Drawing.Point(0, 162);
            this.pnlHardwareSize.Name = "pnlHardwareSize";
            this.pnlHardwareSize.Size = new System.Drawing.Size(800, 0);
            this.pnlHardwareSize.TabIndex = 30;
            // 
            // pnlComponent
            // 
            this.pnlComponent.AutoSize = true;
            this.pnlComponent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComponent.Location = new System.Drawing.Point(0, 162);
            this.pnlComponent.Name = "pnlComponent";
            this.pnlComponent.Size = new System.Drawing.Size(800, 0);
            this.pnlComponent.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnComponentAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 568);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 32);
            this.panel4.TabIndex = 37;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(342, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exploit Ekle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(228, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Dataset Ekle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(114, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Çözüm Ekle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnComponentAdd
            // 
            this.btnComponentAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnComponentAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComponentAdd.Location = new System.Drawing.Point(0, 0);
            this.btnComponentAdd.Name = "btnComponentAdd";
            this.btnComponentAdd.Size = new System.Drawing.Size(114, 32);
            this.btnComponentAdd.TabIndex = 0;
            this.btnComponentAdd.Text = "Komponent Ekle";
            this.btnComponentAdd.UseVisualStyleBackColor = true;
            this.btnComponentAdd.Click += new System.EventHandler(this.btnComponentAdd_Click);
            // 
            // HardwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlComponent);
            this.Controls.Add(this.pnlHardwareSize);
            this.Controls.Add(this.pnlHardwareDrivers);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlControl_reverse);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HardwareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardwareForm";
            this.Load += new System.EventHandler(this.HardwareForm_Load);
            this.Click += new System.EventHandler(this.HardwareForm_Click);
            this.pnlControl_reverse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl_reverse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHardwareDrivers;
        private System.Windows.Forms.Panel pnlHardwareSize;
        private System.Windows.Forms.Panel pnlComponent;
        private System.Windows.Forms.Label txtHardwareName;
        private System.Windows.Forms.Label txtUnit;
        private System.Windows.Forms.Label txtHardwareModel;
        private System.Windows.Forms.Label txtHardwareCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnComponentAdd;
    }
}
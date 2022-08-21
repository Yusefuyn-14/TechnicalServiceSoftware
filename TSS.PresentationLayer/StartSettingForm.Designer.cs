namespace TSS.UserInterface
{
    partial class StartSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartSettingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.comboDatabaseType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboLogType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboHashType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1_reverse = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1_reverse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veritabanı Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(209, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Veritabanı Tipi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHost
            // 
            this.txtHost.BackColor = System.Drawing.Color.Maroon;
            this.txtHost.ForeColor = System.Drawing.Color.White;
            this.txtHost.Location = new System.Drawing.Point(352, 170);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(237, 20);
            this.txtHost.TabIndex = 4;
            this.txtHost.Text = "localhost";
            // 
            // txtDataBase
            // 
            this.txtDataBase.BackColor = System.Drawing.Color.Maroon;
            this.txtDataBase.ForeColor = System.Drawing.Color.White;
            this.txtDataBase.Location = new System.Drawing.Point(353, 196);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(237, 20);
            this.txtDataBase.TabIndex = 5;
            this.txtDataBase.Text = "TechnicalService";
            // 
            // comboDatabaseType
            // 
            this.comboDatabaseType.BackColor = System.Drawing.Color.Maroon;
            this.comboDatabaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDatabaseType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDatabaseType.ForeColor = System.Drawing.Color.White;
            this.comboDatabaseType.FormattingEnabled = true;
            this.comboDatabaseType.Location = new System.Drawing.Point(352, 143);
            this.comboDatabaseType.Name = "comboDatabaseType";
            this.comboDatabaseType.Size = new System.Drawing.Size(237, 21);
            this.comboDatabaseType.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(352, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(237, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboLogType
            // 
            this.comboLogType.BackColor = System.Drawing.Color.Maroon;
            this.comboLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLogType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLogType.ForeColor = System.Drawing.Color.White;
            this.comboLogType.FormattingEnabled = true;
            this.comboLogType.Location = new System.Drawing.Point(352, 222);
            this.comboLogType.Name = "comboLogType";
            this.comboLogType.Size = new System.Drawing.Size(237, 21);
            this.comboLogType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(209, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Log Tipi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboHashType
            // 
            this.comboHashType.BackColor = System.Drawing.Color.Maroon;
            this.comboHashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHashType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboHashType.ForeColor = System.Drawing.Color.White;
            this.comboHashType.FormattingEnabled = true;
            this.comboHashType.Location = new System.Drawing.Point(352, 249);
            this.comboHashType.Name = "comboHashType";
            this.comboHashType.Size = new System.Drawing.Size(237, 21);
            this.comboHashType.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(209, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hash Tipi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1_reverse
            // 
            this.panel1_reverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.panel1_reverse.Controls.Add(this.btnClose);
            this.panel1_reverse.Controls.Add(this.label6);
            this.panel1_reverse.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_reverse.Location = new System.Drawing.Point(0, 0);
            this.panel1_reverse.Name = "panel1_reverse";
            this.panel1_reverse.Size = new System.Drawing.Size(800, 50);
            this.panel1_reverse.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(754, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(800, 50);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ayarları Yap";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(360, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // StartSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1_reverse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboHashType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboLogType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboDatabaseType);
            this.Controls.Add(this.txtDataBase);
            this.Controls.Add(this.txtHost);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartSettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panel1_reverse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.ComboBox comboDatabaseType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboLogType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboHashType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1_reverse;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
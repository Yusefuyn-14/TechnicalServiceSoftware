namespace TSS.UserInterface.Management.Add
{
    partial class HardwareAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardwareAddForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHardwareType = new System.Windows.Forms.ComboBox();
            this.txtHardwareModel = new System.Windows.Forms.TextBox();
            this.txtHardwareProducer = new System.Windows.Forms.TextBox();
            this.txtHardwareName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericSize = new System.Windows.Forms.NumericUpDown();
            this.cbSizeType = new System.Windows.Forms.ComboBox();
            this.txtSizeDescription = new System.Windows.Forms.TextBox();
            this.btnAddHardwareSize = new System.Windows.Forms.Button();
            this.btnDeleteSelectedSize = new System.Windows.Forms.Button();
            this.dgvSize = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlControl_reverse = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtHardwareDriveDescription = new System.Windows.Forms.TextBox();
            this.btnRemoveSelectedHardwareID = new System.Windows.Forms.Button();
            this.btnAddHardwareDrive = new System.Windows.Forms.Button();
            this.dgvHardwareDriverID = new System.Windows.Forms.DataGridView();
            this.txtHardwareDriveID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).BeginInit();
            this.pnlControl_reverse.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardwareDriverID)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbHardwareType);
            this.panel1.Controls.Add(this.txtHardwareModel);
            this.panel1.Controls.Add(this.txtHardwareProducer);
            this.panel1.Controls.Add(this.txtHardwareName);
            this.panel1.Location = new System.Drawing.Point(177, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 108);
            this.panel1.TabIndex = 1;
            // 
            // cbHardwareType
            // 
            this.cbHardwareType.BackColor = System.Drawing.Color.Maroon;
            this.cbHardwareType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHardwareType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.cbHardwareType.FormattingEnabled = true;
            this.cbHardwareType.Location = new System.Drawing.Point(12, 78);
            this.cbHardwareType.Name = "cbHardwareType";
            this.cbHardwareType.Size = new System.Drawing.Size(599, 21);
            this.cbHardwareType.TabIndex = 3;
            // 
            // txtHardwareModel
            // 
            this.txtHardwareModel.BackColor = System.Drawing.Color.Maroon;
            this.txtHardwareModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHardwareModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.txtHardwareModel.Location = new System.Drawing.Point(12, 56);
            this.txtHardwareModel.Name = "txtHardwareModel";
            this.txtHardwareModel.Size = new System.Drawing.Size(599, 20);
            this.txtHardwareModel.TabIndex = 2;
            // 
            // txtHardwareProducer
            // 
            this.txtHardwareProducer.BackColor = System.Drawing.Color.Maroon;
            this.txtHardwareProducer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHardwareProducer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.txtHardwareProducer.Location = new System.Drawing.Point(12, 33);
            this.txtHardwareProducer.Name = "txtHardwareProducer";
            this.txtHardwareProducer.Size = new System.Drawing.Size(599, 20);
            this.txtHardwareProducer.TabIndex = 1;
            // 
            // txtHardwareName
            // 
            this.txtHardwareName.BackColor = System.Drawing.Color.Maroon;
            this.txtHardwareName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHardwareName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.txtHardwareName.Location = new System.Drawing.Point(12, 9);
            this.txtHardwareName.Name = "txtHardwareName";
            this.txtHardwareName.Size = new System.Drawing.Size(599, 20);
            this.txtHardwareName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericSize);
            this.panel2.Controls.Add(this.cbSizeType);
            this.panel2.Controls.Add(this.txtSizeDescription);
            this.panel2.Controls.Add(this.btnAddHardwareSize);
            this.panel2.Controls.Add(this.btnDeleteSelectedSize);
            this.panel2.Controls.Add(this.dgvSize);
            this.panel2.Location = new System.Drawing.Point(177, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 235);
            this.panel2.TabIndex = 2;
            // 
            // numericSize
            // 
            this.numericSize.BackColor = System.Drawing.Color.Maroon;
            this.numericSize.ForeColor = System.Drawing.Color.White;
            this.numericSize.Location = new System.Drawing.Point(11, 6);
            this.numericSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericSize.Name = "numericSize";
            this.numericSize.Size = new System.Drawing.Size(138, 20);
            this.numericSize.TabIndex = 7;
            // 
            // cbSizeType
            // 
            this.cbSizeType.BackColor = System.Drawing.Color.Maroon;
            this.cbSizeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSizeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.cbSizeType.FormattingEnabled = true;
            this.cbSizeType.Location = new System.Drawing.Point(11, 28);
            this.cbSizeType.Name = "cbSizeType";
            this.cbSizeType.Size = new System.Drawing.Size(599, 21);
            this.cbSizeType.TabIndex = 6;
            // 
            // txtSizeDescription
            // 
            this.txtSizeDescription.BackColor = System.Drawing.Color.Maroon;
            this.txtSizeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSizeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.txtSizeDescription.Location = new System.Drawing.Point(11, 52);
            this.txtSizeDescription.Name = "txtSizeDescription";
            this.txtSizeDescription.Size = new System.Drawing.Size(599, 20);
            this.txtSizeDescription.TabIndex = 5;
            // 
            // btnAddHardwareSize
            // 
            this.btnAddHardwareSize.BackColor = System.Drawing.Color.Maroon;
            this.btnAddHardwareSize.FlatAppearance.BorderSize = 0;
            this.btnAddHardwareSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHardwareSize.ForeColor = System.Drawing.Color.White;
            this.btnAddHardwareSize.Location = new System.Drawing.Point(12, 74);
            this.btnAddHardwareSize.Name = "btnAddHardwareSize";
            this.btnAddHardwareSize.Size = new System.Drawing.Size(518, 23);
            this.btnAddHardwareSize.TabIndex = 2;
            this.btnAddHardwareSize.Text = "Ekle";
            this.btnAddHardwareSize.UseVisualStyleBackColor = false;
            this.btnAddHardwareSize.Click += new System.EventHandler(this.btnAddHardwareSize_Click);
            // 
            // btnDeleteSelectedSize
            // 
            this.btnDeleteSelectedSize.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteSelectedSize.FlatAppearance.BorderSize = 0;
            this.btnDeleteSelectedSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedSize.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSelectedSize.Location = new System.Drawing.Point(536, 74);
            this.btnDeleteSelectedSize.Name = "btnDeleteSelectedSize";
            this.btnDeleteSelectedSize.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSelectedSize.TabIndex = 1;
            this.btnDeleteSelectedSize.Text = "Sil";
            this.btnDeleteSelectedSize.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedSize.Click += new System.EventHandler(this.btnDeleteSelectedSize_Click);
            // 
            // dgvSize
            // 
            this.dgvSize.AllowUserToAddRows = false;
            this.dgvSize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSize.Location = new System.Drawing.Point(11, 99);
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSize.Size = new System.Drawing.Size(600, 132);
            this.dgvSize.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(189, 548);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(599, 46);
            this.btnOk.TabIndex = 29;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlControl_reverse
            // 
            this.pnlControl_reverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlControl_reverse.Controls.Add(this.label6);
            this.pnlControl_reverse.Controls.Add(this.button1);
            this.pnlControl_reverse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl_reverse.Location = new System.Drawing.Point(174, 0);
            this.pnlControl_reverse.Name = "pnlControl_reverse";
            this.pnlControl_reverse.Size = new System.Drawing.Size(626, 43);
            this.pnlControl_reverse.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(626, 43);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yeni Donanım Ekle";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(270, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 46);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 43);
            this.panel4.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(44, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(174, 600);
            this.panel5.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(34, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "Driver ID Description :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Hardware Driver ID :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "Açıklama :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Boyut Birimi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Boyut :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tür :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 46);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Donanım Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Firma :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Model :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtHardwareDriveDescription);
            this.panel6.Controls.Add(this.btnRemoveSelectedHardwareID);
            this.panel6.Controls.Add(this.btnAddHardwareDrive);
            this.panel6.Controls.Add(this.dgvHardwareDriverID);
            this.panel6.Controls.Add(this.txtHardwareDriveID);
            this.panel6.Location = new System.Drawing.Point(177, 394);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(621, 149);
            this.panel6.TabIndex = 32;
            // 
            // txtHardwareDriveDescription
            // 
            this.txtHardwareDriveDescription.BackColor = System.Drawing.Color.Maroon;
            this.txtHardwareDriveDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHardwareDriveDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.txtHardwareDriveDescription.Location = new System.Drawing.Point(11, 25);
            this.txtHardwareDriveDescription.Name = "txtHardwareDriveDescription";
            this.txtHardwareDriveDescription.Size = new System.Drawing.Size(599, 20);
            this.txtHardwareDriveDescription.TabIndex = 10;
            // 
            // btnRemoveSelectedHardwareID
            // 
            this.btnRemoveSelectedHardwareID.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveSelectedHardwareID.FlatAppearance.BorderSize = 0;
            this.btnRemoveSelectedHardwareID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedHardwareID.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelectedHardwareID.Location = new System.Drawing.Point(535, 48);
            this.btnRemoveSelectedHardwareID.Name = "btnRemoveSelectedHardwareID";
            this.btnRemoveSelectedHardwareID.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSelectedHardwareID.TabIndex = 9;
            this.btnRemoveSelectedHardwareID.Text = "Sil";
            this.btnRemoveSelectedHardwareID.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedHardwareID.Click += new System.EventHandler(this.btnRemoveSelectedHardwareID_Click);
            // 
            // btnAddHardwareDrive
            // 
            this.btnAddHardwareDrive.BackColor = System.Drawing.Color.Maroon;
            this.btnAddHardwareDrive.FlatAppearance.BorderSize = 0;
            this.btnAddHardwareDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHardwareDrive.ForeColor = System.Drawing.Color.White;
            this.btnAddHardwareDrive.Location = new System.Drawing.Point(10, 48);
            this.btnAddHardwareDrive.Name = "btnAddHardwareDrive";
            this.btnAddHardwareDrive.Size = new System.Drawing.Size(520, 23);
            this.btnAddHardwareDrive.TabIndex = 8;
            this.btnAddHardwareDrive.Text = "Ekle";
            this.btnAddHardwareDrive.UseVisualStyleBackColor = false;
            this.btnAddHardwareDrive.Click += new System.EventHandler(this.btnAddHardwareDrive_Click);
            // 
            // dgvHardwareDriverID
            // 
            this.dgvHardwareDriverID.AllowUserToAddRows = false;
            this.dgvHardwareDriverID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHardwareDriverID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHardwareDriverID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHardwareDriverID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHardwareDriverID.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHardwareDriverID.Location = new System.Drawing.Point(10, 77);
            this.dgvHardwareDriverID.Name = "dgvHardwareDriverID";
            this.dgvHardwareDriverID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHardwareDriverID.Size = new System.Drawing.Size(600, 69);
            this.dgvHardwareDriverID.TabIndex = 7;
            // 
            // txtHardwareDriveID
            // 
            this.txtHardwareDriveID.BackColor = System.Drawing.Color.Maroon;
            this.txtHardwareDriveID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHardwareDriveID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.txtHardwareDriveID.Location = new System.Drawing.Point(11, 3);
            this.txtHardwareDriveID.Name = "txtHardwareDriveID";
            this.txtHardwareDriveID.Size = new System.Drawing.Size(599, 20);
            this.txtHardwareDriveID.TabIndex = 6;
            // 
            // HardwareAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnlControl_reverse);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HardwareAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hardwareAddForm";
            this.Load += new System.EventHandler(this.HardwareAddForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).EndInit();
            this.pnlControl_reverse.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardwareDriverID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlControl_reverse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHardwareName;
        private System.Windows.Forms.ComboBox cbHardwareType;
        private System.Windows.Forms.TextBox txtHardwareModel;
        private System.Windows.Forms.TextBox txtHardwareProducer;
        private System.Windows.Forms.Button btnAddHardwareSize;
        private System.Windows.Forms.Button btnDeleteSelectedSize;
        private System.Windows.Forms.DataGridView dgvSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericSize;
        private System.Windows.Forms.ComboBox cbSizeType;
        private System.Windows.Forms.TextBox txtSizeDescription;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemoveSelectedHardwareID;
        private System.Windows.Forms.Button btnAddHardwareDrive;
        private System.Windows.Forms.DataGridView dgvHardwareDriverID;
        private System.Windows.Forms.TextBox txtHardwareDriveID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHardwareDriveDescription;
    }
}
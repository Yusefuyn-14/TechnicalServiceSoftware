namespace TSS.UserInterface.Management.Add
{
    partial class ComputerUnitAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerUnitAddForm));
            this.pnlControl_reverse = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvComputerUnit = new System.Windows.Forms.DataGridView();
            this.ComputerUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAbbreviation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnitAdd = new System.Windows.Forms.Button();
            this.btnUnitUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlControl_reverse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputerUnit)).BeginInit();
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
            this.label4.Text = "Bilgisayar Birim Ekle";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvComputerUnit
            // 
            this.dgvComputerUnit.AllowUserToAddRows = false;
            this.dgvComputerUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.dgvComputerUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputerUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComputerUnitID,
            this.ComputerUnitName,
            this.Abbreviation});
            this.dgvComputerUnit.Location = new System.Drawing.Point(12, 56);
            this.dgvComputerUnit.Name = "dgvComputerUnit";
            this.dgvComputerUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComputerUnit.Size = new System.Drawing.Size(778, 202);
            this.dgvComputerUnit.TabIndex = 28;
            this.dgvComputerUnit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComputerUnit_CellClick);
            // 
            // ComputerUnitID
            // 
            this.ComputerUnitID.HeaderText = "ID";
            this.ComputerUnitID.Name = "ComputerUnitID";
            this.ComputerUnitID.Visible = false;
            // 
            // ComputerUnitName
            // 
            this.ComputerUnitName.HeaderText = "Name";
            this.ComputerUnitName.Name = "ComputerUnitName";
            // 
            // Abbreviation
            // 
            this.Abbreviation.HeaderText = "Kısaltma";
            this.Abbreviation.Name = "Abbreviation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Birim Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Maroon;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(115, 263);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 31;
            // 
            // txtAbbreviation
            // 
            this.txtAbbreviation.BackColor = System.Drawing.Color.Maroon;
            this.txtAbbreviation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAbbreviation.ForeColor = System.Drawing.Color.White;
            this.txtAbbreviation.Location = new System.Drawing.Point(115, 284);
            this.txtAbbreviation.Name = "txtAbbreviation";
            this.txtAbbreviation.Size = new System.Drawing.Size(184, 20);
            this.txtAbbreviation.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Birim Kısaltması :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnUnitAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitAdd.Location = new System.Drawing.Point(305, 263);
            this.btnUnitAdd.Name = "btnUnitAdd";
            this.btnUnitAdd.Size = new System.Drawing.Size(123, 23);
            this.btnUnitAdd.TabIndex = 34;
            this.btnUnitAdd.Text = "Ekle";
            this.btnUnitAdd.UseVisualStyleBackColor = false;
            this.btnUnitAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUnitUpdate
            // 
            this.btnUnitUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUnitUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitUpdate.Location = new System.Drawing.Point(305, 287);
            this.btnUnitUpdate.Name = "btnUnitUpdate";
            this.btnUnitUpdate.Size = new System.Drawing.Size(123, 23);
            this.btnUnitUpdate.TabIndex = 35;
            this.btnUnitUpdate.Text = "Güncelle";
            this.btnUnitUpdate.UseVisualStyleBackColor = false;
            this.btnUnitUpdate.Click += new System.EventHandler(this.btnUnitUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(305, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ComputerUnitAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUnitUpdate);
            this.Controls.Add(this.btnUnitAdd);
            this.Controls.Add(this.txtAbbreviation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvComputerUnit);
            this.Controls.Add(this.pnlControl_reverse);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComputerUnitAddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComputerUnitAddForm";
            this.Load += new System.EventHandler(this.ComputerUnitAddForm_Load);
            this.pnlControl_reverse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputerUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl_reverse;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvComputerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abbreviation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAbbreviation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnitAdd;
        private System.Windows.Forms.Button btnUnitUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
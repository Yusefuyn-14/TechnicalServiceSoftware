namespace TSS.UserInterface.Management.Show
{
    partial class HardwareListForm
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
            this.dgvHardwares = new System.Windows.Forms.DataGridView();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.btnAddHardware = new System.Windows.Forms.Button();
            this.btnUpdateHardware = new System.Windows.Forms.Button();
            this.btnDeleteHardware = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnViewHardware = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardwares)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHardwares
            // 
            this.dgvHardwares.AllowUserToAddRows = false;
            this.dgvHardwares.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHardwares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHardwares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.dgvHardwares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHardwares.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHardwares.GridColor = System.Drawing.Color.White;
            this.dgvHardwares.Location = new System.Drawing.Point(12, 32);
            this.dgvHardwares.Name = "dgvHardwares";
            this.dgvHardwares.ReadOnly = true;
            this.dgvHardwares.RowHeadersVisible = false;
            this.dgvHardwares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHardwares.Size = new System.Drawing.Size(556, 429);
            this.dgvHardwares.TabIndex = 18;
            this.dgvHardwares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHardwares_CellClick);
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelectedItem.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(550, 20);
            this.lblSelectedItem.TabIndex = 17;
            this.lblSelectedItem.Text = "secilenid";
            this.lblSelectedItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddHardware
            // 
            this.btnAddHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHardware.BackColor = System.Drawing.Color.Maroon;
            this.btnAddHardware.FlatAppearance.BorderSize = 0;
            this.btnAddHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHardware.ForeColor = System.Drawing.Color.White;
            this.btnAddHardware.Location = new System.Drawing.Point(442, 485);
            this.btnAddHardware.Name = "btnAddHardware";
            this.btnAddHardware.Size = new System.Drawing.Size(126, 23);
            this.btnAddHardware.TabIndex = 16;
            this.btnAddHardware.Text = "Ekle";
            this.btnAddHardware.UseVisualStyleBackColor = false;
            this.btnAddHardware.Click += new System.EventHandler(this.btnAddHardware_Click);
            // 
            // btnUpdateHardware
            // 
            this.btnUpdateHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateHardware.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdateHardware.FlatAppearance.BorderSize = 0;
            this.btnUpdateHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateHardware.ForeColor = System.Drawing.Color.White;
            this.btnUpdateHardware.Location = new System.Drawing.Point(139, 485);
            this.btnUpdateHardware.Name = "btnUpdateHardware";
            this.btnUpdateHardware.Size = new System.Drawing.Size(126, 23);
            this.btnUpdateHardware.TabIndex = 15;
            this.btnUpdateHardware.Text = "Değiştir";
            this.btnUpdateHardware.UseVisualStyleBackColor = false;
            this.btnUpdateHardware.Visible = false;
            // 
            // btnDeleteHardware
            // 
            this.btnDeleteHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteHardware.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteHardware.FlatAppearance.BorderSize = 0;
            this.btnDeleteHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHardware.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHardware.Location = new System.Drawing.Point(315, 485);
            this.btnDeleteHardware.Name = "btnDeleteHardware";
            this.btnDeleteHardware.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteHardware.TabIndex = 14;
            this.btnDeleteHardware.Text = "Sil";
            this.btnDeleteHardware.UseVisualStyleBackColor = false;
            this.btnDeleteHardware.Click += new System.EventHandler(this.btnDeleteHardware_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Maroon;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(556, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // btnViewHardware
            // 
            this.btnViewHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewHardware.BackColor = System.Drawing.Color.Maroon;
            this.btnViewHardware.FlatAppearance.BorderSize = 0;
            this.btnViewHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHardware.ForeColor = System.Drawing.Color.White;
            this.btnViewHardware.Location = new System.Drawing.Point(12, 485);
            this.btnViewHardware.Name = "btnViewHardware";
            this.btnViewHardware.Size = new System.Drawing.Size(126, 23);
            this.btnViewHardware.TabIndex = 19;
            this.btnViewHardware.Text = "Görüntüle";
            this.btnViewHardware.UseVisualStyleBackColor = false;
            this.btnViewHardware.Click += new System.EventHandler(this.btnViewHardware_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lblSelectedItem);
            this.panel1.Location = new System.Drawing.Point(12, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 20);
            this.panel1.TabIndex = 20;
            // 
            // HardwareListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(580, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewHardware);
            this.Controls.Add(this.dgvHardwares);
            this.Controls.Add(this.btnAddHardware);
            this.Controls.Add(this.btnUpdateHardware);
            this.Controls.Add(this.btnDeleteHardware);
            this.Controls.Add(this.txtSearch);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HardwareListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardwareListForm";
            this.Load += new System.EventHandler(this.HardwareListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardwares)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHardwares;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Button btnAddHardware;
        private System.Windows.Forms.Button btnUpdateHardware;
        private System.Windows.Forms.Button btnDeleteHardware;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnViewHardware;
        private System.Windows.Forms.Panel panel1;
    }
}
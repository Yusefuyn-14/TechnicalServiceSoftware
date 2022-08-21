namespace TSS.UserInterface.Management.Show
{
    partial class TroubleListForm
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
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.btnAddTrouble = new System.Windows.Forms.Button();
            this.btnUpdateTrouble = new System.Windows.Forms.Button();
            this.btnDeleteTrouble = new System.Windows.Forms.Button();
            this.btnTroublePrice = new System.Windows.Forms.Button();
            this.btnAddStatus = new System.Windows.Forms.Button();
            this.btnViewTrouble = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTrouble = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTroubles = new System.Windows.Forms.Button();
            this.btnFinishedTrouble = new System.Windows.Forms.Button();
            this.btnNotFinishedTrouble = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrouble)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.BackColor = System.Drawing.Color.Maroon;
            this.lblSelectedItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedItem.ForeColor = System.Drawing.Color.White;
            this.lblSelectedItem.Location = new System.Drawing.Point(0, 0);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(556, 20);
            this.lblSelectedItem.TabIndex = 17;
            this.lblSelectedItem.Text = "secilenid";
            this.lblSelectedItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddTrouble
            // 
            this.btnAddTrouble.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTrouble.BackColor = System.Drawing.Color.Maroon;
            this.btnAddTrouble.FlatAppearance.BorderSize = 0;
            this.btnAddTrouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrouble.ForeColor = System.Drawing.Color.White;
            this.btnAddTrouble.Location = new System.Drawing.Point(442, 495);
            this.btnAddTrouble.Name = "btnAddTrouble";
            this.btnAddTrouble.Size = new System.Drawing.Size(126, 23);
            this.btnAddTrouble.TabIndex = 16;
            this.btnAddTrouble.Text = "Ekle";
            this.btnAddTrouble.UseVisualStyleBackColor = false;
            this.btnAddTrouble.Click += new System.EventHandler(this.btnAddTrouble_Click);
            // 
            // btnUpdateTrouble
            // 
            this.btnUpdateTrouble.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateTrouble.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdateTrouble.FlatAppearance.BorderSize = 0;
            this.btnUpdateTrouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTrouble.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTrouble.Location = new System.Drawing.Point(139, 495);
            this.btnUpdateTrouble.Name = "btnUpdateTrouble";
            this.btnUpdateTrouble.Size = new System.Drawing.Size(126, 23);
            this.btnUpdateTrouble.TabIndex = 15;
            this.btnUpdateTrouble.Text = "Değiştir";
            this.btnUpdateTrouble.UseVisualStyleBackColor = false;
            this.btnUpdateTrouble.Click += new System.EventHandler(this.btnUpdateTrouble_Click);
            // 
            // btnDeleteTrouble
            // 
            this.btnDeleteTrouble.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTrouble.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteTrouble.FlatAppearance.BorderSize = 0;
            this.btnDeleteTrouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTrouble.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTrouble.Location = new System.Drawing.Point(12, 495);
            this.btnDeleteTrouble.Name = "btnDeleteTrouble";
            this.btnDeleteTrouble.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteTrouble.TabIndex = 14;
            this.btnDeleteTrouble.Text = "Sil";
            this.btnDeleteTrouble.UseVisualStyleBackColor = false;
            this.btnDeleteTrouble.Click += new System.EventHandler(this.btnDeleteTrouble_Click);
            // 
            // btnTroublePrice
            // 
            this.btnTroublePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTroublePrice.BackColor = System.Drawing.Color.Maroon;
            this.btnTroublePrice.FlatAppearance.BorderSize = 0;
            this.btnTroublePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroublePrice.ForeColor = System.Drawing.Color.White;
            this.btnTroublePrice.Location = new System.Drawing.Point(139, 471);
            this.btnTroublePrice.Name = "btnTroublePrice";
            this.btnTroublePrice.Size = new System.Drawing.Size(126, 23);
            this.btnTroublePrice.TabIndex = 22;
            this.btnTroublePrice.Text = "Fiyat Güncelle";
            this.btnTroublePrice.UseVisualStyleBackColor = false;
            this.btnTroublePrice.Click += new System.EventHandler(this.btnTroublePrice_Click);
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStatus.BackColor = System.Drawing.Color.Maroon;
            this.btnAddStatus.FlatAppearance.BorderSize = 0;
            this.btnAddStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStatus.ForeColor = System.Drawing.Color.White;
            this.btnAddStatus.Location = new System.Drawing.Point(12, 471);
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.Size = new System.Drawing.Size(126, 23);
            this.btnAddStatus.TabIndex = 20;
            this.btnAddStatus.Text = "Durum Değiştir";
            this.btnAddStatus.UseVisualStyleBackColor = false;
            this.btnAddStatus.Click += new System.EventHandler(this.btnAddStatus_Click);
            // 
            // btnViewTrouble
            // 
            this.btnViewTrouble.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewTrouble.BackColor = System.Drawing.Color.Maroon;
            this.btnViewTrouble.FlatAppearance.BorderSize = 0;
            this.btnViewTrouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTrouble.ForeColor = System.Drawing.Color.White;
            this.btnViewTrouble.Location = new System.Drawing.Point(315, 495);
            this.btnViewTrouble.Name = "btnViewTrouble";
            this.btnViewTrouble.Size = new System.Drawing.Size(126, 23);
            this.btnViewTrouble.TabIndex = 19;
            this.btnViewTrouble.Text = "Görüntüle";
            this.btnViewTrouble.UseVisualStyleBackColor = false;
            this.btnViewTrouble.Click += new System.EventHandler(this.btnViewTrouble_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.lblSelectedItem);
            this.panel1.Location = new System.Drawing.Point(12, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 20);
            this.panel1.TabIndex = 23;
            // 
            // dgvTrouble
            // 
            this.dgvTrouble.AllowUserToAddRows = false;
            this.dgvTrouble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrouble.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrouble.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.dgvTrouble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrouble.GridColor = System.Drawing.Color.White;
            this.dgvTrouble.Location = new System.Drawing.Point(12, 55);
            this.dgvTrouble.Name = "dgvTrouble";
            this.dgvTrouble.ReadOnly = true;
            this.dgvTrouble.RowHeadersVisible = false;
            this.dgvTrouble.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrouble.Size = new System.Drawing.Size(556, 389);
            this.dgvTrouble.TabIndex = 25;
            this.dgvTrouble.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrouble_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Maroon;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(12, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(556, 20);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnTroubles
            // 
            this.btnTroubles.BackColor = System.Drawing.Color.Maroon;
            this.btnTroubles.FlatAppearance.BorderSize = 0;
            this.btnTroubles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroubles.Location = new System.Drawing.Point(12, 4);
            this.btnTroubles.Name = "btnTroubles";
            this.btnTroubles.Size = new System.Drawing.Size(75, 23);
            this.btnTroubles.TabIndex = 26;
            this.btnTroubles.Text = "Hepsi";
            this.btnTroubles.UseVisualStyleBackColor = false;
            this.btnTroubles.Click += new System.EventHandler(this.btnTroubles_Click);
            // 
            // btnFinishedTrouble
            // 
            this.btnFinishedTrouble.BackColor = System.Drawing.Color.Maroon;
            this.btnFinishedTrouble.FlatAppearance.BorderSize = 0;
            this.btnFinishedTrouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishedTrouble.Location = new System.Drawing.Point(88, 4);
            this.btnFinishedTrouble.Name = "btnFinishedTrouble";
            this.btnFinishedTrouble.Size = new System.Drawing.Size(99, 23);
            this.btnFinishedTrouble.TabIndex = 27;
            this.btnFinishedTrouble.Text = "Sonuçlananlar";
            this.btnFinishedTrouble.UseVisualStyleBackColor = false;
            this.btnFinishedTrouble.Click += new System.EventHandler(this.btnFinishedTrouble_Click);
            // 
            // btnNotFinishedTrouble
            // 
            this.btnNotFinishedTrouble.BackColor = System.Drawing.Color.Maroon;
            this.btnNotFinishedTrouble.FlatAppearance.BorderSize = 0;
            this.btnNotFinishedTrouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotFinishedTrouble.Location = new System.Drawing.Point(188, 4);
            this.btnNotFinishedTrouble.Name = "btnNotFinishedTrouble";
            this.btnNotFinishedTrouble.Size = new System.Drawing.Size(99, 23);
            this.btnNotFinishedTrouble.TabIndex = 28;
            this.btnNotFinishedTrouble.Text = "Bekleyenler";
            this.btnNotFinishedTrouble.UseVisualStyleBackColor = false;
            this.btnNotFinishedTrouble.Click += new System.EventHandler(this.btnNotFinishedTrouble_Click);
            // 
            // TroubleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(580, 520);
            this.Controls.Add(this.btnNotFinishedTrouble);
            this.Controls.Add(this.btnFinishedTrouble);
            this.Controls.Add(this.btnTroubles);
            this.Controls.Add(this.dgvTrouble);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTroublePrice);
            this.Controls.Add(this.btnUpdateTrouble);
            this.Controls.Add(this.btnAddStatus);
            this.Controls.Add(this.btnDeleteTrouble);
            this.Controls.Add(this.btnViewTrouble);
            this.Controls.Add(this.btnAddTrouble);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TroubleListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormTrouble";
            this.Load += new System.EventHandler(this.TroubleForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrouble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Button btnAddTrouble;
        private System.Windows.Forms.Button btnUpdateTrouble;
        private System.Windows.Forms.Button btnDeleteTrouble;
        private System.Windows.Forms.Button btnAddStatus;
        private System.Windows.Forms.Button btnViewTrouble;
        private System.Windows.Forms.Button btnTroublePrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTrouble;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTroubles;
        private System.Windows.Forms.Button btnFinishedTrouble;
        private System.Windows.Forms.Button btnNotFinishedTrouble;
    }
}
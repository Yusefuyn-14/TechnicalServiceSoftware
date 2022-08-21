namespace TSS.UserInterface.Management.Show
{
    partial class ProductPriceListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPriceListForm));
            this.pnlControl_reverse = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProductPrice = new System.Windows.Forms.DataGridView();
            this.ProductPriceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddProductPrice = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlControl_reverse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductPrice)).BeginInit();
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
            this.label4.Text = "Ürün Fiyat Listesi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvProductPrice
            // 
            this.dgvProductPrice.AllowUserToAddRows = false;
            this.dgvProductPrice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.dgvProductPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductPriceID,
            this.SaleProductName,
            this.CurrencyID,
            this.SalePrice,
            this.PurchasePrice,
            this.TPrice,
            this.Profit});
            this.dgvProductPrice.Location = new System.Drawing.Point(3, 56);
            this.dgvProductPrice.Name = "dgvProductPrice";
            this.dgvProductPrice.ReadOnly = true;
            this.dgvProductPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductPrice.Size = new System.Drawing.Size(795, 383);
            this.dgvProductPrice.TabIndex = 27;
            this.dgvProductPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductPrice_CellClick);
            // 
            // ProductPriceID
            // 
            this.ProductPriceID.HeaderText = "ID";
            this.ProductPriceID.Name = "ProductPriceID";
            this.ProductPriceID.ReadOnly = true;
            this.ProductPriceID.Visible = false;
            // 
            // SaleProductName
            // 
            this.SaleProductName.HeaderText = "İsim";
            this.SaleProductName.Name = "SaleProductName";
            this.SaleProductName.ReadOnly = true;
            // 
            // CurrencyID
            // 
            this.CurrencyID.HeaderText = "Birim";
            this.CurrencyID.Name = "CurrencyID";
            this.CurrencyID.ReadOnly = true;
            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "Satış Fiyatı";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "Alış Fiyatı";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // TPrice
            // 
            this.TPrice.HeaderText = "Vergi";
            this.TPrice.Name = "TPrice";
            this.TPrice.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Kâr";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // btnAddProductPrice
            // 
            this.btnAddProductPrice.BackColor = System.Drawing.Color.Maroon;
            this.btnAddProductPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductPrice.Location = new System.Drawing.Point(5, 445);
            this.btnAddProductPrice.Name = "btnAddProductPrice";
            this.btnAddProductPrice.Size = new System.Drawing.Size(374, 23);
            this.btnAddProductPrice.TabIndex = 28;
            this.btnAddProductPrice.Text = "Yeni Fiyat Ekle";
            this.btnAddProductPrice.UseVisualStyleBackColor = false;
            this.btnAddProductPrice.Click += new System.EventHandler(this.btnAddProductPrice_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(5, 493);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(374, 23);
            this.btnUpdate.TabIndex = 65;
            this.btnUpdate.Text = "Güncele";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(5, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(374, 23);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ProductPriceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddProductPrice);
            this.Controls.Add(this.dgvProductPrice);
            this.Controls.Add(this.pnlControl_reverse);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductPriceListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductPriceListForm";
            this.Load += new System.EventHandler(this.ProductPriceListForm_Load);
            this.pnlControl_reverse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl_reverse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridView dgvProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.Button btnAddProductPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

namespace TSS.UserInterface.Management.Show
{
    partial class ComponentListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvComponent = new System.Windows.Forms.DataGridView();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.btnUpdateComponent = new System.Windows.Forms.Button();
            this.btnDeleteComponent = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComponent
            // 
            this.dgvComponent.AllowUserToAddRows = false;
            this.dgvComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComponent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComponent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.dgvComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComponent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComponent.GridColor = System.Drawing.Color.White;
            this.dgvComponent.Location = new System.Drawing.Point(12, 32);
            this.dgvComponent.Name = "dgvComponent";
            this.dgvComponent.ReadOnly = true;
            this.dgvComponent.RowHeadersVisible = false;
            this.dgvComponent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComponent.Size = new System.Drawing.Size(556, 428);
            this.dgvComponent.TabIndex = 18;
            this.dgvComponent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComponent_CellClick);
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.BackColor = System.Drawing.Color.Maroon;
            this.lblSelectedItem.ForeColor = System.Drawing.Color.White;
            this.lblSelectedItem.Location = new System.Drawing.Point(12, 462);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(556, 20);
            this.lblSelectedItem.TabIndex = 17;
            this.lblSelectedItem.Text = "secilenid";
            this.lblSelectedItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddComponent.BackColor = System.Drawing.Color.Maroon;
            this.btnAddComponent.FlatAppearance.BorderSize = 0;
            this.btnAddComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComponent.ForeColor = System.Drawing.Color.White;
            this.btnAddComponent.Location = new System.Drawing.Point(442, 483);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(126, 23);
            this.btnAddComponent.TabIndex = 16;
            this.btnAddComponent.Text = "Ekle";
            this.btnAddComponent.UseVisualStyleBackColor = false;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // btnUpdateComponent
            // 
            this.btnUpdateComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateComponent.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdateComponent.FlatAppearance.BorderSize = 0;
            this.btnUpdateComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateComponent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateComponent.Location = new System.Drawing.Point(139, 483);
            this.btnUpdateComponent.Name = "btnUpdateComponent";
            this.btnUpdateComponent.Size = new System.Drawing.Size(126, 23);
            this.btnUpdateComponent.TabIndex = 15;
            this.btnUpdateComponent.Text = "Değiştir";
            this.btnUpdateComponent.UseVisualStyleBackColor = false;
            // 
            // btnDeleteComponent
            // 
            this.btnDeleteComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteComponent.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteComponent.FlatAppearance.BorderSize = 0;
            this.btnDeleteComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteComponent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteComponent.Location = new System.Drawing.Point(12, 483);
            this.btnDeleteComponent.Name = "btnDeleteComponent";
            this.btnDeleteComponent.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteComponent.TabIndex = 14;
            this.btnDeleteComponent.Text = "Sil";
            this.btnDeleteComponent.UseVisualStyleBackColor = false;
            this.btnDeleteComponent.Click += new System.EventHandler(this.btnDeleteComponent_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Maroon;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(12, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(556, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // ComponentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(580, 520);
            this.Controls.Add(this.dgvComponent);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.btnAddComponent);
            this.Controls.Add(this.btnUpdateComponent);
            this.Controls.Add(this.btnDeleteComponent);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentListForm";
            this.Text = "ComponentListForm";
            this.Load += new System.EventHandler(this.ComponentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComponent;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Button btnUpdateComponent;
        private System.Windows.Forms.Button btnDeleteComponent;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
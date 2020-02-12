namespace AuctionGame_Admin
{
    partial class ChildMainRoutines
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteRoutine = new System.Windows.Forms.Button();
            this.btnSearchRoutines = new System.Windows.Forms.Button();
            this.cboSearchRoutines = new System.Windows.Forms.ComboBox();
            this.txbSeacrhRoutines = new System.Windows.Forms.TextBox();
            this.dgvVirtualBidders = new System.Windows.Forms.DataGridView();
            this.clmIdFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVirtualBidders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVirtualBidders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteRoutine
            // 
            this.btnDeleteRoutine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRoutine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnDeleteRoutine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoutine.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoutine.Location = new System.Drawing.Point(621, 612);
            this.btnDeleteRoutine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteRoutine.Name = "btnDeleteRoutine";
            this.btnDeleteRoutine.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteRoutine.TabIndex = 29;
            this.btnDeleteRoutine.Text = "Eliminar";
            this.btnDeleteRoutine.UseVisualStyleBackColor = false;
            // 
            // btnSearchRoutines
            // 
            this.btnSearchRoutines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchRoutines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnSearchRoutines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoutines.ForeColor = System.Drawing.Color.White;
            this.btnSearchRoutines.Location = new System.Drawing.Point(538, 72);
            this.btnSearchRoutines.Name = "btnSearchRoutines";
            this.btnSearchRoutines.Size = new System.Drawing.Size(150, 30);
            this.btnSearchRoutines.TabIndex = 28;
            this.btnSearchRoutines.Text = "Buscar";
            this.btnSearchRoutines.UseVisualStyleBackColor = false;
            // 
            // cboSearchRoutines
            // 
            this.cboSearchRoutines.FormattingEnabled = true;
            this.cboSearchRoutines.Items.AddRange(new object[] {
            "Mostrar Todo",
            "Nombre",
            "Puntos",
            "Productos"});
            this.cboSearchRoutines.Location = new System.Drawing.Point(13, 74);
            this.cboSearchRoutines.Name = "cboSearchRoutines";
            this.cboSearchRoutines.Size = new System.Drawing.Size(169, 29);
            this.cboSearchRoutines.TabIndex = 27;
            // 
            // txbSeacrhRoutines
            // 
            this.txbSeacrhRoutines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSeacrhRoutines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSeacrhRoutines.ForeColor = System.Drawing.Color.Silver;
            this.txbSeacrhRoutines.Location = new System.Drawing.Point(188, 74);
            this.txbSeacrhRoutines.Name = "txbSeacrhRoutines";
            this.txbSeacrhRoutines.Size = new System.Drawing.Size(344, 29);
            this.txbSeacrhRoutines.TabIndex = 26;
            this.txbSeacrhRoutines.Tag = "Buscar,alfanumerico";
            this.txbSeacrhRoutines.Text = "Buscar";
            // 
            // dgvVirtualBidders
            // 
            this.dgvVirtualBidders.AllowUserToAddRows = false;
            this.dgvVirtualBidders.AllowUserToDeleteRows = false;
            this.dgvVirtualBidders.AllowUserToOrderColumns = true;
            this.dgvVirtualBidders.AllowUserToResizeRows = false;
            this.dgvVirtualBidders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVirtualBidders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVirtualBidders.BackgroundColor = System.Drawing.Color.White;
            this.dgvVirtualBidders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVirtualBidders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVirtualBidders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVirtualBidders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVirtualBidders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdFamily,
            this.clmNameFamily,
            this.clmDescription,
            this.clmFamilies,
            this.clmProducts,
            this.clmVirtualBidders});
            this.dgvVirtualBidders.EnableHeadersVisualStyles = false;
            this.dgvVirtualBidders.Location = new System.Drawing.Point(13, 116);
            this.dgvVirtualBidders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVirtualBidders.MultiSelect = false;
            this.dgvVirtualBidders.Name = "dgvVirtualBidders";
            this.dgvVirtualBidders.ReadOnly = true;
            this.dgvVirtualBidders.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVirtualBidders.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVirtualBidders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVirtualBidders.ShowCellToolTips = false;
            this.dgvVirtualBidders.Size = new System.Drawing.Size(758, 420);
            this.dgvVirtualBidders.TabIndex = 25;
            this.dgvVirtualBidders.Tag = "-1";
            // 
            // clmIdFamily
            // 
            this.clmIdFamily.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmIdFamily.HeaderText = "ID";
            this.clmIdFamily.Name = "clmIdFamily";
            this.clmIdFamily.ReadOnly = true;
            this.clmIdFamily.Visible = false;
            this.clmIdFamily.Width = 30;
            // 
            // clmNameFamily
            // 
            this.clmNameFamily.HeaderText = "Nombre";
            this.clmNameFamily.Name = "clmNameFamily";
            this.clmNameFamily.ReadOnly = true;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Descripción";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // clmFamilies
            // 
            this.clmFamilies.HeaderText = "Familias";
            this.clmFamilies.Name = "clmFamilies";
            this.clmFamilies.ReadOnly = true;
            // 
            // clmProducts
            // 
            this.clmProducts.HeaderText = "Productos";
            this.clmProducts.Name = "clmProducts";
            this.clmProducts.ReadOnly = true;
            // 
            // clmVirtualBidders
            // 
            this.clmVirtualBidders.HeaderText = "Jugadores Virtuales";
            this.clmVirtualBidders.Name = "clmVirtualBidders";
            this.clmVirtualBidders.ReadOnly = true;
            // 
            // ChildMainRoutines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnDeleteRoutine);
            this.Controls.Add(this.btnSearchRoutines);
            this.Controls.Add(this.cboSearchRoutines);
            this.Controls.Add(this.txbSeacrhRoutines);
            this.Controls.Add(this.dgvVirtualBidders);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildMainRoutines";
            this.Text = "ChildMainRoutines";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVirtualBidders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRoutine;
        private System.Windows.Forms.Button btnSearchRoutines;
        private System.Windows.Forms.ComboBox cboSearchRoutines;
        private System.Windows.Forms.TextBox txbSeacrhRoutines;
        private System.Windows.Forms.DataGridView dgvVirtualBidders;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilies;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVirtualBidders;
    }
}
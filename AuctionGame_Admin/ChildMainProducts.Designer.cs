namespace AuctionGame_Admin
{
    partial class ChildMainProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.clmIdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInitialPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPointsValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImageBase64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.txbSearchProducts = new System.Windows.Forms.TextBox();
            this.cboSearchProducts = new System.Windows.Forms.ComboBox();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdProduct,
            this.clmNameProduct,
            this.clmInitialPrice,
            this.clmPointsValue,
            this.clmImageBase64});
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(13, 111);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.ShowCellToolTips = false;
            this.dgvProducts.Size = new System.Drawing.Size(758, 420);
            this.dgvProducts.TabIndex = 3;
            this.dgvProducts.Tag = "-1";
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // clmIdProduct
            // 
            this.clmIdProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmIdProduct.HeaderText = "ID";
            this.clmIdProduct.Name = "clmIdProduct";
            this.clmIdProduct.ReadOnly = true;
            this.clmIdProduct.Width = 49;
            // 
            // clmNameProduct
            // 
            this.clmNameProduct.HeaderText = "Nombre";
            this.clmNameProduct.Name = "clmNameProduct";
            this.clmNameProduct.ReadOnly = true;
            // 
            // clmInitialPrice
            // 
            this.clmInitialPrice.HeaderText = "Precio Inicial";
            this.clmInitialPrice.Name = "clmInitialPrice";
            this.clmInitialPrice.ReadOnly = true;
            // 
            // clmPointsValue
            // 
            this.clmPointsValue.HeaderText = "Puntos";
            this.clmPointsValue.Name = "clmPointsValue";
            this.clmPointsValue.ReadOnly = true;
            // 
            // clmImageBase64
            // 
            this.clmImageBase64.HeaderText = "ruta de imagen";
            this.clmImageBase64.Name = "clmImageBase64";
            this.clmImageBase64.ReadOnly = true;
            this.clmImageBase64.Visible = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(621, 612);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteProduct.TabIndex = 13;
            this.btnDeleteProduct.Text = "Eliminar";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // txbSearchProducts
            // 
            this.txbSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchProducts.ForeColor = System.Drawing.Color.Silver;
            this.txbSearchProducts.Location = new System.Drawing.Point(188, 74);
            this.txbSearchProducts.Name = "txbSearchProducts";
            this.txbSearchProducts.Size = new System.Drawing.Size(344, 29);
            this.txbSearchProducts.TabIndex = 14;
            this.txbSearchProducts.Tag = "Buscar,alfanumerico";
            this.txbSearchProducts.Text = "Buscar";
            this.txbSearchProducts.Enter += new System.EventHandler(this.txbSearchProducts_Enter);
            this.txbSearchProducts.Leave += new System.EventHandler(this.txbSearchProducts_Leave);
            // 
            // cboSearchProducts
            // 
            this.cboSearchProducts.FormattingEnabled = true;
            this.cboSearchProducts.Items.AddRange(new object[] {
            "Mostrar Todo",
            "ID",
            "Nombre",
            "Precio Inicial",
            "Puntos"});
            this.cboSearchProducts.Location = new System.Drawing.Point(13, 74);
            this.cboSearchProducts.Name = "cboSearchProducts";
            this.cboSearchProducts.Size = new System.Drawing.Size(169, 29);
            this.cboSearchProducts.TabIndex = 15;
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnSearchProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProducts.ForeColor = System.Drawing.Color.White;
            this.btnSearchProducts.Location = new System.Drawing.Point(538, 72);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(150, 30);
            this.btnSearchProducts.TabIndex = 16;
            this.btnSearchProducts.Text = "Buscar";
            this.btnSearchProducts.UseVisualStyleBackColor = false;
            this.btnSearchProducts.Click += new System.EventHandler(this.btnSearchProducts_Click);
            // 
            // ChildMainProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnSearchProducts);
            this.Controls.Add(this.cboSearchProducts);
            this.Controls.Add(this.txbSearchProducts);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.dgvProducts);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildMainProducts";
            this.Text = "Child1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInitialPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPointsValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImageBase64;
        private System.Windows.Forms.TextBox txbSearchProducts;
        private System.Windows.Forms.ComboBox cboSearchProducts;
        private System.Windows.Forms.Button btnSearchProducts;
    }
}
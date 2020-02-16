namespace AuctionGame_Admin
{
    partial class FrmFamily
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbPointsValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAvailableProducts = new System.Windows.Forms.DataGridView();
            this.clmidAvailableProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailableProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegisteredProducts = new System.Windows.Forms.DataGridView();
            this.clmIdRegisteredColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRegisteredProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbNameFamily = new System.Windows.Forms.TextBox();
            this.pBoxDeleteProduct = new System.Windows.Forms.PictureBox();
            this.pBoxAddProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDeleteProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPointsValue
            // 
            this.txbPointsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPointsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPointsValue.ForeColor = System.Drawing.Color.Silver;
            this.txbPointsValue.Location = new System.Drawing.Point(102, 102);
            this.txbPointsValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPointsValue.Name = "txbPointsValue";
            this.txbPointsValue.Size = new System.Drawing.Size(297, 29);
            this.txbPointsValue.TabIndex = 3;
            this.txbPointsValue.Tag = "Puntos,numeroEntero";
            this.txbPointsValue.Text = "Puntos";
            this.txbPointsValue.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbPointsValue.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbPointsValue.Validated += new System.EventHandler(this.Txb_Validated);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(33, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Puntos:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // dgvAvailableProducts
            // 
            this.dgvAvailableProducts.AllowUserToAddRows = false;
            this.dgvAvailableProducts.AllowUserToDeleteRows = false;
            this.dgvAvailableProducts.AllowUserToOrderColumns = true;
            this.dgvAvailableProducts.AllowUserToResizeRows = false;
            this.dgvAvailableProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvailableProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailableProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailableProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvailableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmidAvailableProduct,
            this.clmAvailableProducts});
            this.dgvAvailableProducts.EnableHeadersVisualStyles = false;
            this.dgvAvailableProducts.Location = new System.Drawing.Point(13, 148);
            this.dgvAvailableProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAvailableProducts.Name = "dgvAvailableProducts";
            this.dgvAvailableProducts.ReadOnly = true;
            this.dgvAvailableProducts.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAvailableProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvailableProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableProducts.ShowCellToolTips = false;
            this.dgvAvailableProducts.Size = new System.Drawing.Size(197, 246);
            this.dgvAvailableProducts.TabIndex = 11;
            this.dgvAvailableProducts.Tag = "-1";
            this.dgvAvailableProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableProducts_CellDoubleClick);
            // 
            // clmidAvailableProduct
            // 
            this.clmidAvailableProduct.HeaderText = "ID";
            this.clmidAvailableProduct.Name = "clmidAvailableProduct";
            this.clmidAvailableProduct.ReadOnly = true;
            this.clmidAvailableProduct.Visible = false;
            // 
            // clmAvailableProducts
            // 
            this.clmAvailableProducts.HeaderText = "Productos Disponibles";
            this.clmAvailableProducts.Name = "clmAvailableProducts";
            this.clmAvailableProducts.ReadOnly = true;
            // 
            // dgvRegisteredProducts
            // 
            this.dgvRegisteredProducts.AllowUserToAddRows = false;
            this.dgvRegisteredProducts.AllowUserToDeleteRows = false;
            this.dgvRegisteredProducts.AllowUserToOrderColumns = true;
            this.dgvRegisteredProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvRegisteredProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegisteredProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegisteredProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegisteredProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegisteredProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegisteredProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegisteredProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegisteredProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisteredProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdRegisteredColumn,
            this.clmRegisteredProducts});
            this.dgvRegisteredProducts.EnableHeadersVisualStyles = false;
            this.dgvRegisteredProducts.Location = new System.Drawing.Point(274, 148);
            this.dgvRegisteredProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRegisteredProducts.Name = "dgvRegisteredProducts";
            this.dgvRegisteredProducts.ReadOnly = true;
            this.dgvRegisteredProducts.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRegisteredProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRegisteredProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisteredProducts.ShowCellToolTips = false;
            this.dgvRegisteredProducts.Size = new System.Drawing.Size(197, 246);
            this.dgvRegisteredProducts.TabIndex = 12;
            this.dgvRegisteredProducts.Tag = "-1";
            this.dgvRegisteredProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegisteredProducts_CellDoubleClick);
            // 
            // clmIdRegisteredColumn
            // 
            this.clmIdRegisteredColumn.HeaderText = "ID";
            this.clmIdRegisteredColumn.Name = "clmIdRegisteredColumn";
            this.clmIdRegisteredColumn.ReadOnly = true;
            this.clmIdRegisteredColumn.Visible = false;
            // 
            // clmRegisteredProducts
            // 
            this.clmRegisteredProducts.HeaderText = "Productos Agregados";
            this.clmRegisteredProducts.Name = "clmRegisteredProducts";
            this.clmRegisteredProducts.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(166, 409);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(322, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbNameFamily
            // 
            this.txbNameFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNameFamily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameFamily.ForeColor = System.Drawing.Color.Silver;
            this.txbNameFamily.Location = new System.Drawing.Point(102, 63);
            this.txbNameFamily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNameFamily.Name = "txbNameFamily";
            this.txbNameFamily.Size = new System.Drawing.Size(297, 29);
            this.txbNameFamily.TabIndex = 2;
            this.txbNameFamily.Tag = "Nombre,alfanumerico";
            this.txbNameFamily.Text = "Nombre";
            this.txbNameFamily.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbNameFamily.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbNameFamily.Validated += new System.EventHandler(this.Txb_Validated);
            // 
            // pBoxDeleteProduct
            // 
            this.pBoxDeleteProduct.Image = global::AuctionGame_Admin.Properties.Resources.leftArrow;
            this.pBoxDeleteProduct.Location = new System.Drawing.Point(217, 289);
            this.pBoxDeleteProduct.Name = "pBoxDeleteProduct";
            this.pBoxDeleteProduct.Size = new System.Drawing.Size(50, 50);
            this.pBoxDeleteProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDeleteProduct.TabIndex = 14;
            this.pBoxDeleteProduct.TabStop = false;
            this.pBoxDeleteProduct.Click += new System.EventHandler(this.pBoxDeleteProduct_Click);
            // 
            // pBoxAddProduct
            // 
            this.pBoxAddProduct.Image = global::AuctionGame_Admin.Properties.Resources.rightArrow;
            this.pBoxAddProduct.Location = new System.Drawing.Point(217, 228);
            this.pBoxAddProduct.Name = "pBoxAddProduct";
            this.pBoxAddProduct.Size = new System.Drawing.Size(50, 50);
            this.pBoxAddProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAddProduct.TabIndex = 13;
            this.pBoxAddProduct.TabStop = false;
            this.pBoxAddProduct.Click += new System.EventHandler(this.pBoxAddProduct_Click);
            // 
            // FrmFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(484, 456);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pBoxDeleteProduct);
            this.Controls.Add(this.pBoxAddProduct);
            this.Controls.Add(this.dgvRegisteredProducts);
            this.Controls.Add(this.dgvAvailableProducts);
            this.Controls.Add(this.txbPointsValue);
            this.Controls.Add(this.txbNameFamily);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 490);
            this.MinimumSize = new System.Drawing.Size(500, 490);
            this.Name = "FrmFamily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Familia";
            this.Load += new System.EventHandler(this.FormFamily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDeleteProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPointsValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAvailableProducts;
        private System.Windows.Forms.DataGridView dgvRegisteredProducts;
        private System.Windows.Forms.PictureBox pBoxAddProduct;
        private System.Windows.Forms.PictureBox pBoxDeleteProduct;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmidAvailableProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailableProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdRegisteredColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRegisteredProducts;
        private System.Windows.Forms.TextBox txbNameFamily;
    }
}
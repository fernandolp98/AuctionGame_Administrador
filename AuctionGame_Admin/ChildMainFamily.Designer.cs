namespace AuctionGame_Admin
{
    partial class ChildMainFamily
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFamilies = new System.Windows.Forms.DataGridView();
            this.clmIdFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchFamily = new System.Windows.Forms.Button();
            this.cboSearchFamily = new System.Windows.Forms.ComboBox();
            this.txbSearchFamily = new System.Windows.Forms.TextBox();
            this.btnDeleteFamily = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFamilies
            // 
            this.dgvFamilies.AllowUserToAddRows = false;
            this.dgvFamilies.AllowUserToDeleteRows = false;
            this.dgvFamilies.AllowUserToOrderColumns = true;
            this.dgvFamilies.AllowUserToResizeRows = false;
            this.dgvFamilies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFamilies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFamilies.BackgroundColor = System.Drawing.Color.White;
            this.dgvFamilies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFamilies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFamilies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdFamily,
            this.clmNameFamily,
            this.clmPoints,
            this.clmProducts});
            this.dgvFamilies.EnableHeadersVisualStyles = false;
            this.dgvFamilies.Location = new System.Drawing.Point(13, 116);
            this.dgvFamilies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFamilies.MultiSelect = false;
            this.dgvFamilies.Name = "dgvFamilies";
            this.dgvFamilies.ReadOnly = true;
            this.dgvFamilies.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFamilies.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFamilies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamilies.ShowCellToolTips = false;
            this.dgvFamilies.Size = new System.Drawing.Size(758, 420);
            this.dgvFamilies.TabIndex = 4;
            this.dgvFamilies.Tag = "-1";
            this.dgvFamilies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamilies_CellClick);
            this.dgvFamilies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamilies_CellDoubleClick);
            // 
            // clmIdFamily
            // 
            this.clmIdFamily.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmIdFamily.HeaderText = "ID";
            this.clmIdFamily.Name = "clmIdFamily";
            this.clmIdFamily.ReadOnly = true;
            this.clmIdFamily.Visible = false;
            // 
            // clmNameFamily
            // 
            this.clmNameFamily.HeaderText = "Nombre";
            this.clmNameFamily.Name = "clmNameFamily";
            this.clmNameFamily.ReadOnly = true;
            // 
            // clmPoints
            // 
            this.clmPoints.HeaderText = "Puntos";
            this.clmPoints.Name = "clmPoints";
            this.clmPoints.ReadOnly = true;
            // 
            // clmProducts
            // 
            this.clmProducts.HeaderText = "Productos";
            this.clmProducts.Name = "clmProducts";
            this.clmProducts.ReadOnly = true;
            // 
            // btnSearchFamily
            // 
            this.btnSearchFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnSearchFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFamily.ForeColor = System.Drawing.Color.White;
            this.btnSearchFamily.Location = new System.Drawing.Point(538, 72);
            this.btnSearchFamily.Name = "btnSearchFamily";
            this.btnSearchFamily.Size = new System.Drawing.Size(150, 30);
            this.btnSearchFamily.TabIndex = 19;
            this.btnSearchFamily.Text = "Buscar";
            this.btnSearchFamily.UseVisualStyleBackColor = false;
            this.btnSearchFamily.Click += new System.EventHandler(this.btnSearchFamily_Click);
            // 
            // cboSearchFamily
            // 
            this.cboSearchFamily.FormattingEnabled = true;
            this.cboSearchFamily.Items.AddRange(new object[] {
            "Mostrar Todo",
            "Nombre",
            "Puntos",
            "Productos"});
            this.cboSearchFamily.Location = new System.Drawing.Point(13, 74);
            this.cboSearchFamily.Name = "cboSearchFamily";
            this.cboSearchFamily.Size = new System.Drawing.Size(169, 29);
            this.cboSearchFamily.TabIndex = 18;
            // 
            // txbSearchFamily
            // 
            this.txbSearchFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchFamily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchFamily.ForeColor = System.Drawing.Color.Silver;
            this.txbSearchFamily.Location = new System.Drawing.Point(188, 74);
            this.txbSearchFamily.Name = "txbSearchFamily";
            this.txbSearchFamily.Size = new System.Drawing.Size(344, 29);
            this.txbSearchFamily.TabIndex = 17;
            this.txbSearchFamily.Tag = "Buscar,alfanumerico";
            this.txbSearchFamily.Text = "Buscar";
            this.txbSearchFamily.Enter += new System.EventHandler(this.txbSearchFamily_Enter);
            this.txbSearchFamily.Leave += new System.EventHandler(this.txbSearchFamily_Leave);
            // 
            // btnDeleteFamily
            // 
            this.btnDeleteFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnDeleteFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFamily.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFamily.Location = new System.Drawing.Point(621, 612);
            this.btnDeleteFamily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteFamily.Name = "btnDeleteFamily";
            this.btnDeleteFamily.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteFamily.TabIndex = 20;
            this.btnDeleteFamily.Text = "Eliminar";
            this.btnDeleteFamily.UseVisualStyleBackColor = false;
            this.btnDeleteFamily.Click += new System.EventHandler(this.btnDeleteFamily_Click);
            // 
            // ChildMainFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnDeleteFamily);
            this.Controls.Add(this.btnSearchFamily);
            this.Controls.Add(this.cboSearchFamily);
            this.Controls.Add(this.txbSearchFamily);
            this.Controls.Add(this.dgvFamilies);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildMainFamily";
            this.Text = "ChildMenuFamily";
            this.Load += new System.EventHandler(this.ChildMenuFamily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFamilies;
        private System.Windows.Forms.Button btnSearchFamily;
        private System.Windows.Forms.ComboBox cboSearchFamily;
        private System.Windows.Forms.TextBox txbSearchFamily;
        private System.Windows.Forms.Button btnDeleteFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducts;
    }
}
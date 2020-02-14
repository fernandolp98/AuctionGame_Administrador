namespace AuctionGame_Admin
{
    partial class ChildMainVirtualBidders
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
            this.dgvVirtualBidders = new System.Windows.Forms.DataGridView();
            this.txbSearchVirtualBidders = new System.Windows.Forms.TextBox();
            this.cboSearchVirtualBidders = new System.Windows.Forms.ComboBox();
            this.btnSearchVirtualBidders = new System.Windows.Forms.Button();
            this.btnDeleteVirtualBidder = new System.Windows.Forms.Button();
            this.clmIdFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdBidder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoleVirtualBidder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVirtualBidders)).BeginInit();
            this.SuspendLayout();
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
            this.clmIdBidder,
            this.clmNameFamily,
            this.clmDescription,
            this.clmRoleVirtualBidder,
            this.clmWallet});
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
            this.dgvVirtualBidders.TabIndex = 20;
            this.dgvVirtualBidders.Tag = "-1";
            this.dgvVirtualBidders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVirtualBidders_CellClick);
            this.dgvVirtualBidders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVirtualBidders_CellDoubleClick);
            // 
            // txbSearchVirtualBidders
            // 
            this.txbSearchVirtualBidders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchVirtualBidders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchVirtualBidders.ForeColor = System.Drawing.Color.Silver;
            this.txbSearchVirtualBidders.Location = new System.Drawing.Point(188, 74);
            this.txbSearchVirtualBidders.Name = "txbSearchVirtualBidders";
            this.txbSearchVirtualBidders.Size = new System.Drawing.Size(344, 29);
            this.txbSearchVirtualBidders.TabIndex = 21;
            this.txbSearchVirtualBidders.Tag = "Buscar,alfanumerico";
            this.txbSearchVirtualBidders.Text = "Buscar";
            // 
            // cboSearchVirtualBidders
            // 
            this.cboSearchVirtualBidders.FormattingEnabled = true;
            this.cboSearchVirtualBidders.Items.AddRange(new object[] {
            "Mostrar Todo",
            "Nombre",
            "Puntos",
            "Productos"});
            this.cboSearchVirtualBidders.Location = new System.Drawing.Point(13, 74);
            this.cboSearchVirtualBidders.Name = "cboSearchVirtualBidders";
            this.cboSearchVirtualBidders.Size = new System.Drawing.Size(169, 29);
            this.cboSearchVirtualBidders.TabIndex = 22;
            // 
            // btnSearchVirtualBidders
            // 
            this.btnSearchVirtualBidders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchVirtualBidders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnSearchVirtualBidders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchVirtualBidders.ForeColor = System.Drawing.Color.White;
            this.btnSearchVirtualBidders.Location = new System.Drawing.Point(538, 72);
            this.btnSearchVirtualBidders.Name = "btnSearchVirtualBidders";
            this.btnSearchVirtualBidders.Size = new System.Drawing.Size(150, 30);
            this.btnSearchVirtualBidders.TabIndex = 23;
            this.btnSearchVirtualBidders.Text = "Buscar";
            this.btnSearchVirtualBidders.UseVisualStyleBackColor = false;
            // 
            // btnDeleteVirtualBidder
            // 
            this.btnDeleteVirtualBidder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteVirtualBidder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnDeleteVirtualBidder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVirtualBidder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVirtualBidder.Location = new System.Drawing.Point(621, 612);
            this.btnDeleteVirtualBidder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteVirtualBidder.Name = "btnDeleteVirtualBidder";
            this.btnDeleteVirtualBidder.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteVirtualBidder.TabIndex = 24;
            this.btnDeleteVirtualBidder.Text = "Eliminar";
            this.btnDeleteVirtualBidder.UseVisualStyleBackColor = false;
            this.btnDeleteVirtualBidder.Click += new System.EventHandler(this.btnDeleteVirtualBidder_Click);
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
            // clmIdBidder
            // 
            this.clmIdBidder.HeaderText = "Nº de Apostador";
            this.clmIdBidder.Name = "clmIdBidder";
            this.clmIdBidder.ReadOnly = true;
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
            // clmRoleVirtualBidder
            // 
            this.clmRoleVirtualBidder.HeaderText = "Rol";
            this.clmRoleVirtualBidder.Name = "clmRoleVirtualBidder";
            this.clmRoleVirtualBidder.ReadOnly = true;
            // 
            // clmWallet
            // 
            this.clmWallet.HeaderText = "Billetera";
            this.clmWallet.Name = "clmWallet";
            this.clmWallet.ReadOnly = true;
            // 
            // ChildMainVirtualBidders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnDeleteVirtualBidder);
            this.Controls.Add(this.btnSearchVirtualBidders);
            this.Controls.Add(this.cboSearchVirtualBidders);
            this.Controls.Add(this.txbSearchVirtualBidders);
            this.Controls.Add(this.dgvVirtualBidders);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildMainVirtualBidders";
            this.Text = "ChildVirtualBidders";
            this.Load += new System.EventHandler(this.ChildMainVirtualPlayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVirtualBidders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVirtualBidders;
        private System.Windows.Forms.TextBox txbSearchVirtualBidders;
        private System.Windows.Forms.ComboBox cboSearchVirtualBidders;
        private System.Windows.Forms.Button btnSearchVirtualBidders;
        private System.Windows.Forms.Button btnDeleteVirtualBidder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdBidder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoleVirtualBidder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWallet;
    }
}
namespace AuctionGame_Aministrador
{
    partial class ChildMainRole
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchRoles = new System.Windows.Forms.Button();
            this.cboSearchRoles = new System.Windows.Forms.ComboBox();
            this.txbSearchRoles = new System.Windows.Forms.TextBox();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.clmIdRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescriptionRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimeToBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOffersFoRound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBidIncrease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRoles
            // 
            this.btnSearchRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnSearchRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoles.ForeColor = System.Drawing.Color.White;
            this.btnSearchRoles.Location = new System.Drawing.Point(538, 72);
            this.btnSearchRoles.Name = "btnSearchRoles";
            this.btnSearchRoles.Size = new System.Drawing.Size(150, 30);
            this.btnSearchRoles.TabIndex = 20;
            this.btnSearchRoles.Text = "Buscar";
            this.btnSearchRoles.UseVisualStyleBackColor = false;
            this.btnSearchRoles.Click += new System.EventHandler(this.btnSearchRoles_Click);
            // 
            // cboSearchRoles
            // 
            this.cboSearchRoles.FormattingEnabled = true;
            this.cboSearchRoles.Items.AddRange(new object[] {
            "Mostrar Todo",
            "Nombre",
            "Descripción",
            "Tiempo en Apostar",
            "Ofertas por Ronda",
            "Rondas",
            "Incremento por Puja"});
            this.cboSearchRoles.Location = new System.Drawing.Point(13, 74);
            this.cboSearchRoles.Name = "cboSearchRoles";
            this.cboSearchRoles.Size = new System.Drawing.Size(169, 29);
            this.cboSearchRoles.TabIndex = 19;
            // 
            // txbSearchRoles
            // 
            this.txbSearchRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchRoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchRoles.ForeColor = System.Drawing.Color.Silver;
            this.txbSearchRoles.Location = new System.Drawing.Point(188, 74);
            this.txbSearchRoles.Name = "txbSearchRoles";
            this.txbSearchRoles.Size = new System.Drawing.Size(344, 29);
            this.txbSearchRoles.TabIndex = 18;
            this.txbSearchRoles.Tag = "Buscar,alfanumerico";
            this.txbSearchRoles.Text = "Buscar";
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AllowUserToOrderColumns = true;
            this.dgvRoles.AllowUserToResizeRows = false;
            this.dgvRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoles.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdRole,
            this.clmNameRole,
            this.clmDescriptionRole,
            this.clmTimeToBid,
            this.clmOffersFoRound,
            this.clmRounds,
            this.clmBidIncrease});
            this.dgvRoles.EnableHeadersVisualStyles = false;
            this.dgvRoles.Location = new System.Drawing.Point(13, 111);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRoles.MultiSelect = false;
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowHeadersVisible = false;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRoles.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.ShowCellToolTips = false;
            this.dgvRoles.Size = new System.Drawing.Size(758, 420);
            this.dgvRoles.TabIndex = 17;
            this.dgvRoles.Tag = "-1";
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            this.dgvRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellDoubleClick);
            // 
            // clmIdRole
            // 
            this.clmIdRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmIdRole.HeaderText = "ID";
            this.clmIdRole.Name = "clmIdRole";
            this.clmIdRole.ReadOnly = true;
            this.clmIdRole.Visible = false;
            // 
            // clmNameRole
            // 
            this.clmNameRole.HeaderText = "Nombre";
            this.clmNameRole.Name = "clmNameRole";
            this.clmNameRole.ReadOnly = true;
            // 
            // clmDescriptionRole
            // 
            this.clmDescriptionRole.HeaderText = "Descripción";
            this.clmDescriptionRole.Name = "clmDescriptionRole";
            this.clmDescriptionRole.ReadOnly = true;
            // 
            // clmTimeToBid
            // 
            this.clmTimeToBid.HeaderText = "Tiempo en Apostar";
            this.clmTimeToBid.Name = "clmTimeToBid";
            this.clmTimeToBid.ReadOnly = true;
            this.clmTimeToBid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmOffersFoRound
            // 
            this.clmOffersFoRound.HeaderText = "Ofertas por Ronda";
            this.clmOffersFoRound.Name = "clmOffersFoRound";
            this.clmOffersFoRound.ReadOnly = true;
            this.clmOffersFoRound.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmRounds
            // 
            this.clmRounds.HeaderText = "Rondas";
            this.clmRounds.Name = "clmRounds";
            this.clmRounds.ReadOnly = true;
            this.clmRounds.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmBidIncrease
            // 
            this.clmBidIncrease.HeaderText = "Incremento por Puja";
            this.clmBidIncrease.Name = "clmBidIncrease";
            this.clmBidIncrease.ReadOnly = true;
            this.clmBidIncrease.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnDeleteRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRole.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.Location = new System.Drawing.Point(621, 612);
            this.btnDeleteRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteRole.TabIndex = 21;
            this.btnDeleteRole.Text = "Eliminar";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // ChildMenuRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.btnSearchRoles);
            this.Controls.Add(this.cboSearchRoles);
            this.Controls.Add(this.txbSearchRoles);
            this.Controls.Add(this.dgvRoles);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildMenuRole";
            this.Text = "ChildMenuRole";
            this.Load += new System.EventHandler(this.ChildMenuRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRoles;
        private System.Windows.Forms.ComboBox cboSearchRoles;
        private System.Windows.Forms.TextBox txbSearchRoles;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescriptionRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeToBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOffersFoRound;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBidIncrease;

    }
}
namespace AuctionGame_Admin
{
    partial class ChildMainVirtualPlayer
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
            this.dgvVirtualPlayers = new System.Windows.Forms.DataGridView();
            this.txbSearchVirtualPlayers = new System.Windows.Forms.TextBox();
            this.cboSearchVirtualPlayers = new System.Windows.Forms.ComboBox();
            this.btnSearchVirtualPlayers = new System.Windows.Forms.Button();
            this.btnDeletevirtualPlayer = new System.Windows.Forms.Button();
            this.clmIdFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRolevirtualPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVirtualPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVirtualPlayers
            // 
            this.dgvVirtualPlayers.AllowUserToAddRows = false;
            this.dgvVirtualPlayers.AllowUserToDeleteRows = false;
            this.dgvVirtualPlayers.AllowUserToOrderColumns = true;
            this.dgvVirtualPlayers.AllowUserToResizeRows = false;
            this.dgvVirtualPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVirtualPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVirtualPlayers.BackgroundColor = System.Drawing.Color.White;
            this.dgvVirtualPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVirtualPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVirtualPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVirtualPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVirtualPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdFamily,
            this.clmNameFamily,
            this.clmDescription,
            this.clmRolevirtualPlayer});
            this.dgvVirtualPlayers.EnableHeadersVisualStyles = false;
            this.dgvVirtualPlayers.Location = new System.Drawing.Point(13, 116);
            this.dgvVirtualPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVirtualPlayers.MultiSelect = false;
            this.dgvVirtualPlayers.Name = "dgvVirtualPlayers";
            this.dgvVirtualPlayers.ReadOnly = true;
            this.dgvVirtualPlayers.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVirtualPlayers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVirtualPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVirtualPlayers.ShowCellToolTips = false;
            this.dgvVirtualPlayers.Size = new System.Drawing.Size(758, 420);
            this.dgvVirtualPlayers.TabIndex = 20;
            this.dgvVirtualPlayers.Tag = "-1";
            this.dgvVirtualPlayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvirtualPlayers_CellClick);
            this.dgvVirtualPlayers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvirtualPlayers_CellDoubleClick);
            // 
            // txbSearchVirtualPlayers
            // 
            this.txbSearchVirtualPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchVirtualPlayers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchVirtualPlayers.ForeColor = System.Drawing.Color.Silver;
            this.txbSearchVirtualPlayers.Location = new System.Drawing.Point(188, 74);
            this.txbSearchVirtualPlayers.Name = "txbSearchVirtualPlayers";
            this.txbSearchVirtualPlayers.Size = new System.Drawing.Size(344, 29);
            this.txbSearchVirtualPlayers.TabIndex = 21;
            this.txbSearchVirtualPlayers.Tag = "Buscar,alfanumerico";
            this.txbSearchVirtualPlayers.Text = "Buscar";
            // 
            // cboSearchVirtualPlayers
            // 
            this.cboSearchVirtualPlayers.FormattingEnabled = true;
            this.cboSearchVirtualPlayers.Items.AddRange(new object[] {
            "Mostrar Todo",
            "Nombre",
            "Puntos",
            "Productos"});
            this.cboSearchVirtualPlayers.Location = new System.Drawing.Point(13, 74);
            this.cboSearchVirtualPlayers.Name = "cboSearchVirtualPlayers";
            this.cboSearchVirtualPlayers.Size = new System.Drawing.Size(169, 29);
            this.cboSearchVirtualPlayers.TabIndex = 22;
            // 
            // btnSearchVirtualPlayers
            // 
            this.btnSearchVirtualPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchVirtualPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnSearchVirtualPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchVirtualPlayers.ForeColor = System.Drawing.Color.White;
            this.btnSearchVirtualPlayers.Location = new System.Drawing.Point(538, 72);
            this.btnSearchVirtualPlayers.Name = "btnSearchVirtualPlayers";
            this.btnSearchVirtualPlayers.Size = new System.Drawing.Size(150, 30);
            this.btnSearchVirtualPlayers.TabIndex = 23;
            this.btnSearchVirtualPlayers.Text = "Buscar";
            this.btnSearchVirtualPlayers.UseVisualStyleBackColor = false;
            // 
            // btnDeletevirtualPlayer
            // 
            this.btnDeletevirtualPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletevirtualPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnDeletevirtualPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletevirtualPlayer.ForeColor = System.Drawing.Color.White;
            this.btnDeletevirtualPlayer.Location = new System.Drawing.Point(621, 612);
            this.btnDeletevirtualPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletevirtualPlayer.Name = "btnDeletevirtualPlayer";
            this.btnDeletevirtualPlayer.Size = new System.Drawing.Size(150, 35);
            this.btnDeletevirtualPlayer.TabIndex = 24;
            this.btnDeletevirtualPlayer.Text = "Eliminar";
            this.btnDeletevirtualPlayer.UseVisualStyleBackColor = false;
            this.btnDeletevirtualPlayer.Click += new System.EventHandler(this.btnDeletevirtualPlayer_Click);
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
            // clmRolevirtualPlayer
            // 
            this.clmRolevirtualPlayer.HeaderText = "Rol";
            this.clmRolevirtualPlayer.Name = "clmRolevirtualPlayer";
            this.clmRolevirtualPlayer.ReadOnly = true;
            // 
            // ChildMainVirtualPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnDeletevirtualPlayer);
            this.Controls.Add(this.btnSearchVirtualPlayers);
            this.Controls.Add(this.cboSearchVirtualPlayers);
            this.Controls.Add(this.txbSearchVirtualPlayers);
            this.Controls.Add(this.dgvVirtualPlayers);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildMainVirtualPlayer";
            this.Text = "ChildvirtualPlayers";
            this.Load += new System.EventHandler(this.ChildMainVirtualPlayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVirtualPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVirtualPlayers;
        private System.Windows.Forms.TextBox txbSearchVirtualPlayers;
        private System.Windows.Forms.ComboBox cboSearchVirtualPlayers;
        private System.Windows.Forms.Button btnSearchVirtualPlayers;
        private System.Windows.Forms.Button btnDeletevirtualPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRolevirtualPlayer;
    }
}
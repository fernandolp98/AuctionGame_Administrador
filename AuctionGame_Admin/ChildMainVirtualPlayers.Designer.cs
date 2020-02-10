﻿namespace AuctionGame_Aministrador
{
    partial class ChildMainVirtualPlayers
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
            this.btnSearchVirtualBidder = new System.Windows.Forms.Button();
            this.cboSearchVirtualBidder = new System.Windows.Forms.ComboBox();
            this.txbVirtualBidder = new System.Windows.Forms.TextBox();
            this.dgvVirtualBidders = new System.Windows.Forms.DataGridView();
            this.clmIdFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteFamily = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVirtualBidders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchVirtualBidder
            // 
            this.btnSearchVirtualBidder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchVirtualBidder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnSearchVirtualBidder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchVirtualBidder.ForeColor = System.Drawing.Color.White;
            this.btnSearchVirtualBidder.Location = new System.Drawing.Point(538, 72);
            this.btnSearchVirtualBidder.Name = "btnSearchVirtualBidder";
            this.btnSearchVirtualBidder.Size = new System.Drawing.Size(150, 30);
            this.btnSearchVirtualBidder.TabIndex = 23;
            this.btnSearchVirtualBidder.Text = "Buscar";
            this.btnSearchVirtualBidder.UseVisualStyleBackColor = false;
            // 
            // cboSearchVirtualBidder
            // 
            this.cboSearchVirtualBidder.FormattingEnabled = true;
            this.cboSearchVirtualBidder.Items.AddRange(new object[] {
            "Mostrar Todo",
            "Nombre",
            "Puntos",
            "Productos"});
            this.cboSearchVirtualBidder.Location = new System.Drawing.Point(13, 74);
            this.cboSearchVirtualBidder.Name = "cboSearchVirtualBidder";
            this.cboSearchVirtualBidder.Size = new System.Drawing.Size(169, 29);
            this.cboSearchVirtualBidder.TabIndex = 22;
            // 
            // txbVirtualBidder
            // 
            this.txbVirtualBidder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbVirtualBidder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVirtualBidder.ForeColor = System.Drawing.Color.Silver;
            this.txbVirtualBidder.Location = new System.Drawing.Point(188, 74);
            this.txbVirtualBidder.Name = "txbVirtualBidder";
            this.txbVirtualBidder.Size = new System.Drawing.Size(344, 29);
            this.txbVirtualBidder.TabIndex = 21;
            this.txbVirtualBidder.Tag = "Buscar,alfanumerico";
            this.txbVirtualBidder.Text = "Buscar";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVirtualBidders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVirtualBidders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVirtualBidders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdFamily,
            this.clmNameFamily,
            this.clmPoints,
            this.clmProducts});
            this.dgvVirtualBidders.EnableHeadersVisualStyles = false;
            this.dgvVirtualBidders.Location = new System.Drawing.Point(13, 116);
            this.dgvVirtualBidders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVirtualBidders.MultiSelect = false;
            this.dgvVirtualBidders.Name = "dgvVirtualBidders";
            this.dgvVirtualBidders.ReadOnly = true;
            this.dgvVirtualBidders.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVirtualBidders.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVirtualBidders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVirtualBidders.ShowCellToolTips = false;
            this.dgvVirtualBidders.Size = new System.Drawing.Size(758, 420);
            this.dgvVirtualBidders.TabIndex = 20;
            this.dgvVirtualBidders.Tag = "-1";
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
            this.btnDeleteFamily.TabIndex = 24;
            this.btnDeleteFamily.Text = "Eliminar";
            this.btnDeleteFamily.UseVisualStyleBackColor = false;
            // 
            // ChildMenuVirtualBidder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnDeleteFamily);
            this.Controls.Add(this.btnSearchVirtualBidder);
            this.Controls.Add(this.cboSearchVirtualBidder);
            this.Controls.Add(this.txbVirtualBidder);
            this.Controls.Add(this.dgvVirtualBidders);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildMenuVirtualBidder";
            this.Text = "ChildVirtualBidders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVirtualBidders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchVirtualBidder;
        private System.Windows.Forms.ComboBox cboSearchVirtualBidder;
        private System.Windows.Forms.TextBox txbVirtualBidder;
        private System.Windows.Forms.DataGridView dgvVirtualBidders;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducts;
        private System.Windows.Forms.Button btnDeleteFamily;
    }
}
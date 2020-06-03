namespace AuctionGame_Admin
{
    partial class FrmVirtualPlayersForRoutine
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pBoxDelete = new System.Windows.Forms.PictureBox();
            this.pBoxAdd = new System.Windows.Forms.PictureBox();
            this.dgvRegistered = new System.Windows.Forms.DataGridView();
            this.clmIdRegisteredColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRegistered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.clmidAvailableFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(166, 345);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 30);
            this.btnCancelar.TabIndex = 15;
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
            this.btnSave.Location = new System.Drawing.Point(322, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pBoxDelete
            // 
            this.pBoxDelete.Image = global::AuctionGame_Admin.Properties.Resources.leftArrow;
            this.pBoxDelete.Location = new System.Drawing.Point(217, 225);
            this.pBoxDelete.Name = "pBoxDelete";
            this.pBoxDelete.Size = new System.Drawing.Size(50, 50);
            this.pBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDelete.TabIndex = 20;
            this.pBoxDelete.TabStop = false;
            this.pBoxDelete.Click += new System.EventHandler(this.pBoxDelete_Click);
            // 
            // pBoxAdd
            // 
            this.pBoxAdd.Image = global::AuctionGame_Admin.Properties.Resources.rightArrow;
            this.pBoxAdd.Location = new System.Drawing.Point(217, 164);
            this.pBoxAdd.Name = "pBoxAdd";
            this.pBoxAdd.Size = new System.Drawing.Size(50, 50);
            this.pBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAdd.TabIndex = 19;
            this.pBoxAdd.TabStop = false;
            this.pBoxAdd.Click += new System.EventHandler(this.pBoxAdd_Click);
            // 
            // dgvRegistered
            // 
            this.dgvRegistered.AllowUserToAddRows = false;
            this.dgvRegistered.AllowUserToDeleteRows = false;
            this.dgvRegistered.AllowUserToOrderColumns = true;
            this.dgvRegistered.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvRegistered.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistered.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistered.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistered.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistered.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdRegisteredColumn,
            this.clmRegistered});
            this.dgvRegistered.EnableHeadersVisualStyles = false;
            this.dgvRegistered.Location = new System.Drawing.Point(274, 84);
            this.dgvRegistered.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRegistered.Name = "dgvRegistered";
            this.dgvRegistered.ReadOnly = true;
            this.dgvRegistered.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRegistered.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegistered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistered.ShowCellToolTips = false;
            this.dgvRegistered.Size = new System.Drawing.Size(197, 246);
            this.dgvRegistered.TabIndex = 18;
            this.dgvRegistered.Tag = "-1";
            this.dgvRegistered.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistered_CellDoubleClick);
            // 
            // clmIdRegisteredColumn
            // 
            this.clmIdRegisteredColumn.HeaderText = "ID";
            this.clmIdRegisteredColumn.Name = "clmIdRegisteredColumn";
            this.clmIdRegisteredColumn.ReadOnly = true;
            this.clmIdRegisteredColumn.Visible = false;
            // 
            // clmRegistered
            // 
            this.clmRegistered.HeaderText = "Agregados";
            this.clmRegistered.Name = "clmRegistered";
            this.clmRegistered.ReadOnly = true;
            // 
            // dgvAvailable
            // 
            this.dgvAvailable.AllowUserToAddRows = false;
            this.dgvAvailable.AllowUserToDeleteRows = false;
            this.dgvAvailable.AllowUserToOrderColumns = true;
            this.dgvAvailable.AllowUserToResizeRows = false;
            this.dgvAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailable.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmidAvailableFamily,
            this.clmAvailable});
            this.dgvAvailable.EnableHeadersVisualStyles = false;
            this.dgvAvailable.Location = new System.Drawing.Point(13, 84);
            this.dgvAvailable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.ReadOnly = true;
            this.dgvAvailable.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAvailable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailable.ShowCellToolTips = false;
            this.dgvAvailable.Size = new System.Drawing.Size(197, 246);
            this.dgvAvailable.TabIndex = 17;
            this.dgvAvailable.Tag = "-1";
            this.dgvAvailable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailable_CellDoubleClick);
            // 
            // clmidAvailableFamily
            // 
            this.clmidAvailableFamily.HeaderText = "ID";
            this.clmidAvailableFamily.Name = "clmidAvailableFamily";
            this.clmidAvailableFamily.ReadOnly = true;
            this.clmidAvailableFamily.Visible = false;
            // 
            // clmAvailable
            // 
            this.clmAvailable.HeaderText = "Disponibles";
            this.clmAvailable.Name = "clmAvailable";
            this.clmAvailable.ReadOnly = true;
            // 
            // FrmFamiliesForRoutine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(484, 387);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pBoxDelete);
            this.Controls.Add(this.pBoxAdd);
            this.Controls.Add(this.dgvRegistered);
            this.Controls.Add(this.dgvAvailable);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFamiliesForRoutine";
            this.Text = "Parametros para Rutina";
            this.Load += new System.EventHandler(this.FrmParamsForRoutine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pBoxDelete;
        private System.Windows.Forms.PictureBox pBoxAdd;
        private System.Windows.Forms.DataGridView dgvRegistered;
        private System.Windows.Forms.DataGridView dgvAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdRegisteredColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRegistered;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmidAvailableFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailable;

    }
}
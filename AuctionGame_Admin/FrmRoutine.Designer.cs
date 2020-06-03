namespace AuctionGame_Admin
{
    partial class FrmRoutine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboxGeneralInformation = new System.Windows.Forms.GroupBox();
            this.pboxSaveRoutine = new System.Windows.Forms.PictureBox();
            this.txbDescriptionRoutine = new System.Windows.Forms.TextBox();
            this.txbNameRoutine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxFamilies = new System.Windows.Forms.GroupBox();
            this.pboxEditFamiliesPerRoutine = new System.Windows.Forms.PictureBox();
            this.dgvFamilies = new System.Windows.Forms.DataGridView();
            this.clmIdFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilyPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilyProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxProducts = new System.Windows.Forms.GroupBox();
            this.pboxEditProductsPerRoutine = new System.Windows.Forms.PictureBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPointsProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInitialPriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSingleProduct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmAddedByFamily = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gboxvirtualPlayers = new System.Windows.Forms.GroupBox();
            this.pboxEditvirtualPlayersPerRoutine = new System.Windows.Forms.PictureBox();
            this.dgvvirtualPlayers = new System.Windows.Forms.DataGridView();
            this.clmIdvirtualPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamevirtualPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWalletvirtualPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRolevirtualPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.gboxGeneralInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSaveRoutine)).BeginInit();
            this.gboxFamilies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEditFamiliesPerRoutine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilies)).BeginInit();
            this.gboxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEditProductsPerRoutine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gboxvirtualPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEditvirtualPlayersPerRoutine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvirtualPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxGeneralInformation
            // 
            this.gboxGeneralInformation.Controls.Add(this.pboxSaveRoutine);
            this.gboxGeneralInformation.Controls.Add(this.txbDescriptionRoutine);
            this.gboxGeneralInformation.Controls.Add(this.txbNameRoutine);
            this.gboxGeneralInformation.Controls.Add(this.label3);
            this.gboxGeneralInformation.Controls.Add(this.label2);
            this.gboxGeneralInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.gboxGeneralInformation.Location = new System.Drawing.Point(12, 12);
            this.gboxGeneralInformation.Name = "gboxGeneralInformation";
            this.gboxGeneralInformation.Size = new System.Drawing.Size(536, 160);
            this.gboxGeneralInformation.TabIndex = 1;
            this.gboxGeneralInformation.TabStop = false;
            this.gboxGeneralInformation.Text = "Información General";
            // 
            // pboxSaveRoutine
            // 
            this.pboxSaveRoutine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxSaveRoutine.Image = global::AuctionGame_Admin.Properties.Resources.guardar_el_archivo;
            this.pboxSaveRoutine.Location = new System.Drawing.Point(496, 124);
            this.pboxSaveRoutine.Name = "pboxSaveRoutine";
            this.pboxSaveRoutine.Size = new System.Drawing.Size(30, 30);
            this.pboxSaveRoutine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxSaveRoutine.TabIndex = 28;
            this.pboxSaveRoutine.TabStop = false;
            this.pboxSaveRoutine.Click += new System.EventHandler(this.pboxSaveRoutine_Click);
            // 
            // txbDescriptionRoutine
            // 
            this.txbDescriptionRoutine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbDescriptionRoutine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescriptionRoutine.ForeColor = System.Drawing.Color.Silver;
            this.txbDescriptionRoutine.Location = new System.Drawing.Point(120, 73);
            this.txbDescriptionRoutine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbDescriptionRoutine.Multiline = true;
            this.txbDescriptionRoutine.Name = "txbDescriptionRoutine";
            this.txbDescriptionRoutine.Size = new System.Drawing.Size(369, 81);
            this.txbDescriptionRoutine.TabIndex = 2;
            this.txbDescriptionRoutine.Tag = "Descripción,alfanumerioco";
            this.txbDescriptionRoutine.Text = "Descripción";
            this.txbDescriptionRoutine.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbDescriptionRoutine.Leave += new System.EventHandler(this.Txb_Leave);
            // 
            // txbNameRoutine
            // 
            this.txbNameRoutine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNameRoutine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameRoutine.ForeColor = System.Drawing.Color.Silver;
            this.txbNameRoutine.Location = new System.Drawing.Point(120, 32);
            this.txbNameRoutine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNameRoutine.Name = "txbNameRoutine";
            this.txbNameRoutine.Size = new System.Drawing.Size(369, 29);
            this.txbNameRoutine.TabIndex = 1;
            this.txbNameRoutine.Tag = "Nombre,alfanumerico";
            this.txbNameRoutine.Text = "Nombre";
            this.txbNameRoutine.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbNameRoutine.Leave += new System.EventHandler(this.Txb_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(8, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(35, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre:";
            // 
            // gboxFamilies
            // 
            this.gboxFamilies.Controls.Add(this.pboxEditFamiliesPerRoutine);
            this.gboxFamilies.Controls.Add(this.dgvFamilies);
            this.gboxFamilies.Enabled = false;
            this.gboxFamilies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.gboxFamilies.Location = new System.Drawing.Point(12, 178);
            this.gboxFamilies.Name = "gboxFamilies";
            this.gboxFamilies.Size = new System.Drawing.Size(536, 160);
            this.gboxFamilies.TabIndex = 17;
            this.gboxFamilies.TabStop = false;
            this.gboxFamilies.Text = "Familias";
            // 
            // pboxEditFamiliesPerRoutine
            // 
            this.pboxEditFamiliesPerRoutine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxEditFamiliesPerRoutine.Image = global::AuctionGame_Admin.Properties.Resources.editUnabled;
            this.pboxEditFamiliesPerRoutine.Location = new System.Drawing.Point(500, 122);
            this.pboxEditFamiliesPerRoutine.Name = "pboxEditFamiliesPerRoutine";
            this.pboxEditFamiliesPerRoutine.Size = new System.Drawing.Size(30, 30);
            this.pboxEditFamiliesPerRoutine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxEditFamiliesPerRoutine.TabIndex = 27;
            this.pboxEditFamiliesPerRoutine.TabStop = false;
            this.pboxEditFamiliesPerRoutine.Click += new System.EventHandler(this.pboxEditFamiliesPerRoutine_Click);
            // 
            // dgvFamilies
            // 
            this.dgvFamilies.AllowUserToAddRows = false;
            this.dgvFamilies.AllowUserToDeleteRows = false;
            this.dgvFamilies.AllowUserToResizeRows = false;
            this.dgvFamilies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFamilies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFamilies.BackgroundColor = System.Drawing.Color.White;
            this.dgvFamilies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFamilies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFamilies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdFamily,
            this.clmNameFamily,
            this.clmFamilyPoints,
            this.clmFamilyProducts});
            this.dgvFamilies.EnableHeadersVisualStyles = false;
            this.dgvFamilies.Location = new System.Drawing.Point(7, 23);
            this.dgvFamilies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFamilies.MultiSelect = false;
            this.dgvFamilies.Name = "dgvFamilies";
            this.dgvFamilies.ReadOnly = true;
            this.dgvFamilies.RowHeadersVisible = false;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFamilies.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFamilies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamilies.ShowCellToolTips = false;
            this.dgvFamilies.Size = new System.Drawing.Size(486, 129);
            this.dgvFamilies.TabIndex = 26;
            this.dgvFamilies.Tag = "-1";
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
            // clmFamilyPoints
            // 
            this.clmFamilyPoints.HeaderText = "Puntos";
            this.clmFamilyPoints.Name = "clmFamilyPoints";
            this.clmFamilyPoints.ReadOnly = true;
            // 
            // clmFamilyProducts
            // 
            this.clmFamilyProducts.HeaderText = "Productos";
            this.clmFamilyProducts.Name = "clmFamilyProducts";
            this.clmFamilyProducts.ReadOnly = true;
            // 
            // gboxProducts
            // 
            this.gboxProducts.Controls.Add(this.pboxEditProductsPerRoutine);
            this.gboxProducts.Controls.Add(this.dgvProducts);
            this.gboxProducts.Enabled = false;
            this.gboxProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.gboxProducts.Location = new System.Drawing.Point(12, 344);
            this.gboxProducts.Name = "gboxProducts";
            this.gboxProducts.Size = new System.Drawing.Size(536, 160);
            this.gboxProducts.TabIndex = 17;
            this.gboxProducts.TabStop = false;
            this.gboxProducts.Text = "Productos";
            // 
            // pboxEditProductsPerRoutine
            // 
            this.pboxEditProductsPerRoutine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxEditProductsPerRoutine.Image = global::AuctionGame_Admin.Properties.Resources.editUnabled;
            this.pboxEditProductsPerRoutine.Location = new System.Drawing.Point(500, 122);
            this.pboxEditProductsPerRoutine.Name = "pboxEditProductsPerRoutine";
            this.pboxEditProductsPerRoutine.Size = new System.Drawing.Size(30, 30);
            this.pboxEditProductsPerRoutine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxEditProductsPerRoutine.TabIndex = 28;
            this.pboxEditProductsPerRoutine.TabStop = false;
            this.pboxEditProductsPerRoutine.Click += new System.EventHandler(this.pboxEditProductsPerRoutine_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.clmPointsProduct,
            this.clmInitialPriceProduct,
            this.clmSingleProduct,
            this.clmAddedByFamily});
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(7, 23);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.ShowCellToolTips = false;
            this.dgvProducts.Size = new System.Drawing.Size(486, 129);
            this.dgvProducts.TabIndex = 27;
            this.dgvProducts.Tag = "-1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // clmPointsProduct
            // 
            this.clmPointsProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmPointsProduct.HeaderText = "Puntos";
            this.clmPointsProduct.Name = "clmPointsProduct";
            this.clmPointsProduct.ReadOnly = true;
            this.clmPointsProduct.Width = 82;
            // 
            // clmInitialPriceProduct
            // 
            this.clmInitialPriceProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmInitialPriceProduct.HeaderText = "Precio Inicial";
            this.clmInitialPriceProduct.Name = "clmInitialPriceProduct";
            this.clmInitialPriceProduct.ReadOnly = true;
            this.clmInitialPriceProduct.Width = 123;
            // 
            // clmSingleProduct
            // 
            this.clmSingleProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmSingleProduct.HeaderText = "Individual";
            this.clmSingleProduct.Name = "clmSingleProduct";
            this.clmSingleProduct.ReadOnly = true;
            this.clmSingleProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmSingleProduct.Width = 76;
            // 
            // clmAddedByFamily
            // 
            this.clmAddedByFamily.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmAddedByFamily.HeaderText = "Familia";
            this.clmAddedByFamily.Name = "clmAddedByFamily";
            this.clmAddedByFamily.ReadOnly = true;
            this.clmAddedByFamily.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmAddedByFamily.Width = 75;
            // 
            // gboxvirtualPlayers
            // 
            this.gboxvirtualPlayers.Controls.Add(this.pboxEditvirtualPlayersPerRoutine);
            this.gboxvirtualPlayers.Controls.Add(this.dgvvirtualPlayers);
            this.gboxvirtualPlayers.Enabled = false;
            this.gboxvirtualPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.gboxvirtualPlayers.Location = new System.Drawing.Point(12, 514);
            this.gboxvirtualPlayers.Name = "gboxvirtualPlayers";
            this.gboxvirtualPlayers.Size = new System.Drawing.Size(536, 160);
            this.gboxvirtualPlayers.TabIndex = 18;
            this.gboxvirtualPlayers.TabStop = false;
            this.gboxvirtualPlayers.Text = "Jugadores Virtuales";
            // 
            // pboxEditvirtualPlayersPerRoutine
            // 
            this.pboxEditvirtualPlayersPerRoutine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxEditvirtualPlayersPerRoutine.Image = global::AuctionGame_Admin.Properties.Resources.editUnabled;
            this.pboxEditvirtualPlayersPerRoutine.Location = new System.Drawing.Point(496, 122);
            this.pboxEditvirtualPlayersPerRoutine.Name = "pboxEditvirtualPlayersPerRoutine";
            this.pboxEditvirtualPlayersPerRoutine.Size = new System.Drawing.Size(30, 30);
            this.pboxEditvirtualPlayersPerRoutine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxEditvirtualPlayersPerRoutine.TabIndex = 29;
            this.pboxEditvirtualPlayersPerRoutine.TabStop = false;
            this.pboxEditvirtualPlayersPerRoutine.Click += new System.EventHandler(this.pboxEditvirtualPlayersPerRoutine_Click);
            // 
            // dgvvirtualPlayers
            // 
            this.dgvvirtualPlayers.AllowUserToAddRows = false;
            this.dgvvirtualPlayers.AllowUserToDeleteRows = false;
            this.dgvvirtualPlayers.AllowUserToResizeRows = false;
            this.dgvvirtualPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvvirtualPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvvirtualPlayers.BackgroundColor = System.Drawing.Color.White;
            this.dgvvirtualPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvvirtualPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvirtualPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvvirtualPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvirtualPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdvirtualPlayer,
            this.clmNamevirtualPlayer,
            this.clmWalletvirtualPlayer,
            this.clmRolevirtualPlayer});
            this.dgvvirtualPlayers.EnableHeadersVisualStyles = false;
            this.dgvvirtualPlayers.Location = new System.Drawing.Point(12, 23);
            this.dgvvirtualPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvvirtualPlayers.MultiSelect = false;
            this.dgvvirtualPlayers.Name = "dgvvirtualPlayers";
            this.dgvvirtualPlayers.ReadOnly = true;
            this.dgvvirtualPlayers.RowHeadersVisible = false;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dgvvirtualPlayers.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvvirtualPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvirtualPlayers.ShowCellToolTips = false;
            this.dgvvirtualPlayers.Size = new System.Drawing.Size(477, 129);
            this.dgvvirtualPlayers.TabIndex = 27;
            this.dgvvirtualPlayers.Tag = "-1";
            // 
            // clmIdvirtualPlayer
            // 
            this.clmIdvirtualPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmIdvirtualPlayer.HeaderText = "ID";
            this.clmIdvirtualPlayer.Name = "clmIdvirtualPlayer";
            this.clmIdvirtualPlayer.ReadOnly = true;
            this.clmIdvirtualPlayer.Visible = false;
            // 
            // clmNamevirtualPlayer
            // 
            this.clmNamevirtualPlayer.HeaderText = "Nombre";
            this.clmNamevirtualPlayer.Name = "clmNamevirtualPlayer";
            this.clmNamevirtualPlayer.ReadOnly = true;
            // 
            // clmWalletvirtualPlayer
            // 
            this.clmWalletvirtualPlayer.HeaderText = "Billetera";
            this.clmWalletvirtualPlayer.Name = "clmWalletvirtualPlayer";
            this.clmWalletvirtualPlayer.ReadOnly = true;
            // 
            // clmRolevirtualPlayer
            // 
            this.clmRolevirtualPlayer.HeaderText = "Rol";
            this.clmRolevirtualPlayer.Name = "clmRolevirtualPlayer";
            this.clmRolevirtualPlayer.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(555, 639);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 35);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 686);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gboxvirtualPlayers);
            this.Controls.Add(this.gboxProducts);
            this.Controls.Add(this.gboxFamilies);
            this.Controls.Add(this.gboxGeneralInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmRoutine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rutina";
            this.Load += new System.EventHandler(this.FrmRoutine_Load);
            this.gboxGeneralInformation.ResumeLayout(false);
            this.gboxGeneralInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSaveRoutine)).EndInit();
            this.gboxFamilies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxEditFamiliesPerRoutine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilies)).EndInit();
            this.gboxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxEditProductsPerRoutine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gboxvirtualPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxEditvirtualPlayersPerRoutine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvirtualPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxGeneralInformation;
        private System.Windows.Forms.TextBox txbDescriptionRoutine;
        private System.Windows.Forms.TextBox txbNameRoutine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxFamilies;
        private System.Windows.Forms.GroupBox gboxProducts;
        private System.Windows.Forms.GroupBox gboxvirtualPlayers;
        private System.Windows.Forms.DataGridView dgvFamilies;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvvirtualPlayers;
        private System.Windows.Forms.PictureBox pboxEditFamiliesPerRoutine;
        private System.Windows.Forms.PictureBox pboxEditProductsPerRoutine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdvirtualPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamevirtualPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWalletvirtualPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRolevirtualPlayer;
        private System.Windows.Forms.PictureBox pboxSaveRoutine;
        private System.Windows.Forms.PictureBox pboxEditvirtualPlayersPerRoutine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPointsProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInitialPriceProduct;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSingleProduct;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAddedByFamily;
        private System.Windows.Forms.Button btnExit;
    }
}
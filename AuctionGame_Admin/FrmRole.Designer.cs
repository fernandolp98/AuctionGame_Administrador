namespace AuctionGame_Admin
{
    partial class FrmRole
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbRoundsTop = new System.Windows.Forms.TextBox();
            this.txbRoundsDown = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txbBidIncreaseBidTop = new System.Windows.Forms.TextBox();
            this.txbBidIncreaseDown = new System.Windows.Forms.TextBox();
            this.txbOffersForRoundTop = new System.Windows.Forms.TextBox();
            this.txbOfersForRoundDown = new System.Windows.Forms.TextBox();
            this.mtxbTimeToBidTop = new System.Windows.Forms.MaskedTextBox();
            this.mtxbTimeToBidDown = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbDescriptionRole = new System.Windows.Forms.TextBox();
            this.txbNameRole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbRoundsTop);
            this.groupBox1.Controls.Add(this.txbRoundsDown);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txbBidIncreaseBidTop);
            this.groupBox1.Controls.Add(this.txbBidIncreaseDown);
            this.groupBox1.Controls.Add(this.txbOffersForRoundTop);
            this.groupBox1.Controls.Add(this.txbOfersForRoundDown);
            this.groupBox1.Controls.Add(this.mtxbTimeToBidTop);
            this.groupBox1.Controls.Add(this.mtxbTimeToBidDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.groupBox1.Location = new System.Drawing.Point(8, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Párametos";
            // 
            // txbRoundsTop
            // 
            this.txbRoundsTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.txbRoundsTop.ForeColor = System.Drawing.Color.Silver;
            this.txbRoundsTop.Location = new System.Drawing.Point(321, 87);
            this.txbRoundsTop.Name = "txbRoundsTop";
            this.txbRoundsTop.Size = new System.Drawing.Size(64, 29);
            this.txbRoundsTop.TabIndex = 8;
            this.txbRoundsTop.Tag = "Máximo,numeroEntero";
            this.txbRoundsTop.Text = "Máximo";
            this.txbRoundsTop.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbRoundsTop.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbRoundsTop.Validated += new System.EventHandler(this.txbRoundsTop_Validated);
            // 
            // txbRoundsDown
            // 
            this.txbRoundsDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.txbRoundsDown.ForeColor = System.Drawing.Color.Silver;
            this.txbRoundsDown.Location = new System.Drawing.Point(321, 54);
            this.txbRoundsDown.Name = "txbRoundsDown";
            this.txbRoundsDown.Size = new System.Drawing.Size(64, 29);
            this.txbRoundsDown.TabIndex = 7;
            this.txbRoundsDown.Tag = "Mínimo,numeroEntero";
            this.txbRoundsDown.Text = "Mínimo";
            this.txbRoundsDown.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbRoundsDown.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbRoundsDown.Validated += new System.EventHandler(this.txbRoundsDown_Validated);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label15.Location = new System.Drawing.Point(248, 91);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 21);
            this.label15.TabIndex = 52;
            this.label15.Text = "Máximo";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label16.Location = new System.Drawing.Point(250, 58);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 21);
            this.label16.TabIndex = 51;
            this.label16.Text = "Mínimo";
            // 
            // txbBidIncreaseBidTop
            // 
            this.txbBidIncreaseBidTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.txbBidIncreaseBidTop.ForeColor = System.Drawing.Color.Silver;
            this.txbBidIncreaseBidTop.Location = new System.Drawing.Point(321, 186);
            this.txbBidIncreaseBidTop.Name = "txbBidIncreaseBidTop";
            this.txbBidIncreaseBidTop.Size = new System.Drawing.Size(64, 29);
            this.txbBidIncreaseBidTop.TabIndex = 10;
            this.txbBidIncreaseBidTop.Tag = "Máximo,numeroEntero";
            this.txbBidIncreaseBidTop.Text = "Máximo";
            this.txbBidIncreaseBidTop.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbBidIncreaseBidTop.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbBidIncreaseBidTop.Validated += new System.EventHandler(this.txbIncreaseForBidTop_Validated);
            // 
            // txbBidIncreaseDown
            // 
            this.txbBidIncreaseDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.txbBidIncreaseDown.ForeColor = System.Drawing.Color.Silver;
            this.txbBidIncreaseDown.Location = new System.Drawing.Point(321, 153);
            this.txbBidIncreaseDown.Name = "txbBidIncreaseDown";
            this.txbBidIncreaseDown.Size = new System.Drawing.Size(64, 29);
            this.txbBidIncreaseDown.TabIndex = 9;
            this.txbBidIncreaseDown.Tag = "Mínimo,numeroEntero";
            this.txbBidIncreaseDown.Text = "Mínimo";
            this.txbBidIncreaseDown.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbBidIncreaseDown.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbBidIncreaseDown.Validated += new System.EventHandler(this.txbIncreaseForBidDown_Validated);
            // 
            // txbOffersForRoundTop
            // 
            this.txbOffersForRoundTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.txbOffersForRoundTop.ForeColor = System.Drawing.Color.Silver;
            this.txbOffersForRoundTop.Location = new System.Drawing.Point(140, 186);
            this.txbOffersForRoundTop.Name = "txbOffersForRoundTop";
            this.txbOffersForRoundTop.Size = new System.Drawing.Size(64, 29);
            this.txbOffersForRoundTop.TabIndex = 6;
            this.txbOffersForRoundTop.Tag = "Máximo,numeroEntero";
            this.txbOffersForRoundTop.Text = "Máximo";
            this.txbOffersForRoundTop.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbOffersForRoundTop.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbOffersForRoundTop.Validated += new System.EventHandler(this.txbOffersForRoundTop_Validated);
            // 
            // txbOfersForRoundDown
            // 
            this.txbOfersForRoundDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.txbOfersForRoundDown.ForeColor = System.Drawing.Color.Silver;
            this.txbOfersForRoundDown.Location = new System.Drawing.Point(140, 153);
            this.txbOfersForRoundDown.Name = "txbOfersForRoundDown";
            this.txbOfersForRoundDown.Size = new System.Drawing.Size(64, 29);
            this.txbOfersForRoundDown.TabIndex = 5;
            this.txbOfersForRoundDown.Tag = "Mínimo,numeroEntero";
            this.txbOfersForRoundDown.Text = "Mínimo";
            this.txbOfersForRoundDown.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbOfersForRoundDown.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbOfersForRoundDown.Validated += new System.EventHandler(this.txbOfersForRoundDown_Validated);
            // 
            // mtxbTimeToBidTop
            // 
            this.mtxbTimeToBidTop.Location = new System.Drawing.Point(140, 87);
            this.mtxbTimeToBidTop.Mask = "00:00";
            this.mtxbTimeToBidTop.Name = "mtxbTimeToBidTop";
            this.mtxbTimeToBidTop.Size = new System.Drawing.Size(64, 29);
            this.mtxbTimeToBidTop.TabIndex = 4;
            this.mtxbTimeToBidTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxbTimeToBidTop.ValidatingType = typeof(System.DateTime);
            this.mtxbTimeToBidTop.Validated += new System.EventHandler(this.mtxbTimeToBidTop_Validated);
            // 
            // mtxbTimeToBidDown
            // 
            this.mtxbTimeToBidDown.Location = new System.Drawing.Point(140, 54);
            this.mtxbTimeToBidDown.Mask = "00:00";
            this.mtxbTimeToBidDown.Name = "mtxbTimeToBidDown";
            this.mtxbTimeToBidDown.Size = new System.Drawing.Size(64, 29);
            this.mtxbTimeToBidDown.TabIndex = 3;
            this.mtxbTimeToBidDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxbTimeToBidDown.ValidatingType = typeof(System.DateTime);
            this.mtxbTimeToBidDown.Validated += new System.EventHandler(this.mtxbTimeToBidDown_Validated);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(68, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Máximo";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(69, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mínimo";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label12.Location = new System.Drawing.Point(248, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 21);
            this.label12.TabIndex = 44;
            this.label12.Text = "Máximo";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label13.Location = new System.Drawing.Point(250, 157);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 21);
            this.label13.TabIndex = 43;
            this.label13.Text = "Mínimo";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label14.Location = new System.Drawing.Point(232, 124);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 21);
            this.label14.TabIndex = 42;
            this.label14.Text = "Incremento por puja:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label9.Location = new System.Drawing.Point(282, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Rounds:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label7.Location = new System.Drawing.Point(68, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "Máximo";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label8.Location = new System.Drawing.Point(69, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Mínimo";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label6.Location = new System.Drawing.Point(63, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ofertas por round:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tiempo en apostar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbDescriptionRole);
            this.groupBox2.Controls.Add(this.txbNameRole);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 148);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Generales";
            // 
            // txbDescriptionRole
            // 
            this.txbDescriptionRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescriptionRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescriptionRole.ForeColor = System.Drawing.Color.Silver;
            this.txbDescriptionRole.Location = new System.Drawing.Point(120, 73);
            this.txbDescriptionRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbDescriptionRole.Multiline = true;
            this.txbDescriptionRole.Name = "txbDescriptionRole";
            this.txbDescriptionRole.Size = new System.Drawing.Size(297, 69);
            this.txbDescriptionRole.TabIndex = 2;
            this.txbDescriptionRole.Tag = "Descripción,alfanumerioco";
            this.txbDescriptionRole.Text = "Descripción";
            this.txbDescriptionRole.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbDescriptionRole.Leave += new System.EventHandler(this.Txb_Leave);
            // 
            // txbNameRole
            // 
            this.txbNameRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNameRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameRole.ForeColor = System.Drawing.Color.Silver;
            this.txbNameRole.Location = new System.Drawing.Point(120, 32);
            this.txbNameRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNameRole.Name = "txbNameRole";
            this.txbNameRole.Size = new System.Drawing.Size(297, 29);
            this.txbNameRole.TabIndex = 1;
            this.txbNameRole.Tag = "Nombre,alfanumerico";
            this.txbNameRole.Text = "Nombre";
            this.txbNameRole.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbNameRole.Leave += new System.EventHandler(this.Txb_Leave);
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
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(166, 409);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 30);
            this.btnCancelar.TabIndex = 0;
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
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(500, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 490);
            this.Name = "FrmRole";
            this.Text = "Rol";
            this.Load += new System.EventHandler(this.FrmRole_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbRoundsTop;
        private System.Windows.Forms.TextBox txbRoundsDown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbBidIncreaseBidTop;
        private System.Windows.Forms.TextBox txbBidIncreaseDown;
        private System.Windows.Forms.TextBox txbOffersForRoundTop;
        private System.Windows.Forms.TextBox txbOfersForRoundDown;
        private System.Windows.Forms.MaskedTextBox mtxbTimeToBidTop;
        private System.Windows.Forms.MaskedTextBox mtxbTimeToBidDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbDescriptionRole;
        private System.Windows.Forms.TextBox txbNameRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSave;

    }
}
namespace AuctionGame_Admin
{
    partial class FrmVirtualBidder
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
            this.txbDescriptionVirtuaBidder = new System.Windows.Forms.TextBox();
            this.txbNameVirtualBidder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbWallet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbDescriptionVirtuaBidder
            // 
            this.txbDescriptionVirtuaBidder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescriptionVirtuaBidder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescriptionVirtuaBidder.ForeColor = System.Drawing.Color.Silver;
            this.txbDescriptionVirtuaBidder.Location = new System.Drawing.Point(119, 135);
            this.txbDescriptionVirtuaBidder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbDescriptionVirtuaBidder.Multiline = true;
            this.txbDescriptionVirtuaBidder.Name = "txbDescriptionVirtuaBidder";
            this.txbDescriptionVirtuaBidder.Size = new System.Drawing.Size(297, 69);
            this.txbDescriptionVirtuaBidder.TabIndex = 43;
            this.txbDescriptionVirtuaBidder.Tag = "Descripción,alfanumerico";
            this.txbDescriptionVirtuaBidder.Text = "Descripción";
            this.txbDescriptionVirtuaBidder.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbDescriptionVirtuaBidder.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbDescriptionVirtuaBidder.Validated += new System.EventHandler(this.Txb_Validated);
            // 
            // txbNameVirtualBidder
            // 
            this.txbNameVirtualBidder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNameVirtualBidder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameVirtualBidder.ForeColor = System.Drawing.Color.Silver;
            this.txbNameVirtualBidder.Location = new System.Drawing.Point(119, 76);
            this.txbNameVirtualBidder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNameVirtualBidder.Name = "txbNameVirtualBidder";
            this.txbNameVirtualBidder.Size = new System.Drawing.Size(297, 29);
            this.txbNameVirtualBidder.TabIndex = 42;
            this.txbNameVirtualBidder.Tag = "Nombre,alfanumerico";
            this.txbNameVirtualBidder.Text = "Nombre";
            this.txbNameVirtualBidder.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbNameVirtualBidder.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbNameVirtualBidder.Validated += new System.EventHandler(this.Txb_Validated);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 46;
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
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nombre:";
            // 
            // txbWallet
            // 
            this.txbWallet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.txbWallet.ForeColor = System.Drawing.Color.Silver;
            this.txbWallet.Location = new System.Drawing.Point(119, 230);
            this.txbWallet.Name = "txbWallet";
            this.txbWallet.Size = new System.Drawing.Size(120, 29);
            this.txbWallet.TabIndex = 44;
            this.txbWallet.Tag = "Cartera,moneda";
            this.txbWallet.Text = "Cartera";
            this.txbWallet.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbWallet.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbWallet.Validated += new System.EventHandler(this.Txb_Validated);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label9.Location = new System.Drawing.Point(40, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 47;
            this.label9.Text = "Cartera:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(72, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Rol:";
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(118, 307);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(121, 29);
            this.cboRole.TabIndex = 49;
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
            this.btnCancelar.TabIndex = 50;
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
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmVirtualBidder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDescriptionVirtuaBidder);
            this.Controls.Add(this.txbNameVirtualBidder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbWallet);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVirtualBidder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugador Virtual";
            this.Load += new System.EventHandler(this.FrmVirtualBidderr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDescriptionVirtuaBidder;
        private System.Windows.Forms.TextBox txbNameVirtualBidder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbWallet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSave;
    }
}
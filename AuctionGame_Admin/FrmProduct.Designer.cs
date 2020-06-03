namespace AuctionGame_Admin
{
    partial class FrmProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIdProduct = new System.Windows.Forms.TextBox();
            this.txbNameProduct = new System.Windows.Forms.TextBox();
            this.txbInitialPrice = new System.Windows.Forms.TextBox();
            this.txbPointsValue = new System.Windows.Forms.TextBox();
            this.pboxProducto = new System.Windows.Forms.PictureBox();
            this.btnPatchImaage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(32, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(3, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Inicial:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(42, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puntos:";
            // 
            // txbIdProduct
            // 
            this.txbIdProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIdProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdProduct.ForeColor = System.Drawing.Color.Silver;
            this.txbIdProduct.Location = new System.Drawing.Point(109, 67);
            this.txbIdProduct.Name = "txbIdProduct";
            this.txbIdProduct.Size = new System.Drawing.Size(182, 29);
            this.txbIdProduct.TabIndex = 2;
            this.txbIdProduct.Tag = "Código,numeroEntero";
            this.txbIdProduct.Text = "Código";
            this.txbIdProduct.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbIdProduct.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbIdProduct.Validated += new System.EventHandler(this.Txb_Validated);
            // 
            // txbNameProduct
            // 
            this.txbNameProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNameProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameProduct.ForeColor = System.Drawing.Color.Silver;
            this.txbNameProduct.Location = new System.Drawing.Point(109, 130);
            this.txbNameProduct.Name = "txbNameProduct";
            this.txbNameProduct.Size = new System.Drawing.Size(182, 29);
            this.txbNameProduct.TabIndex = 3;
            this.txbNameProduct.Tag = "Nombre,alfanumerico";
            this.txbNameProduct.Text = "Nombre";
            this.txbNameProduct.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbNameProduct.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbNameProduct.Validated += new System.EventHandler(this.Txb_Validated);
            // 
            // txbInitialPrice
            // 
            this.txbInitialPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbInitialPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInitialPrice.ForeColor = System.Drawing.Color.Silver;
            this.txbInitialPrice.Location = new System.Drawing.Point(109, 193);
            this.txbInitialPrice.Name = "txbInitialPrice";
            this.txbInitialPrice.Size = new System.Drawing.Size(182, 29);
            this.txbInitialPrice.TabIndex = 4;
            this.txbInitialPrice.Tag = "Precio Inicial,moneda";
            this.txbInitialPrice.Text = "Precio Inicial";
            this.txbInitialPrice.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbInitialPrice.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbInitialPrice.Validated += new System.EventHandler(this.Txb_Validated);
            // 
            // txbPointsValue
            // 
            this.txbPointsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPointsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPointsValue.ForeColor = System.Drawing.Color.Silver;
            this.txbPointsValue.Location = new System.Drawing.Point(109, 256);
            this.txbPointsValue.Name = "txbPointsValue";
            this.txbPointsValue.Size = new System.Drawing.Size(182, 29);
            this.txbPointsValue.TabIndex = 5;
            this.txbPointsValue.Tag = "Puntos,numeroEntero";
            this.txbPointsValue.Text = "Puntos";
            this.txbPointsValue.Enter += new System.EventHandler(this.Txb_Enter);
            this.txbPointsValue.Leave += new System.EventHandler(this.Txb_Leave);
            this.txbPointsValue.Validated += new System.EventHandler(this.Txb_Validated);
            // 
            // pboxProducto
            // 
            this.pboxProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pboxProducto.BackColor = System.Drawing.Color.White;
            this.pboxProducto.Image = global::AuctionGame_Admin.Properties.Resources.no_foto;
            this.pboxProducto.Location = new System.Drawing.Point(307, 67);
            this.pboxProducto.Name = "pboxProducto";
            this.pboxProducto.Size = new System.Drawing.Size(130, 170);
            this.pboxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxProducto.TabIndex = 8;
            this.pboxProducto.TabStop = false;
            // 
            // btnPatchImaage
            // 
            this.btnPatchImaage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatchImaage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatchImaage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPatchImaage.Location = new System.Drawing.Point(307, 255);
            this.btnPatchImaage.Name = "btnPatchImaage";
            this.btnPatchImaage.Size = new System.Drawing.Size(130, 30);
            this.btnPatchImaage.TabIndex = 6;
            this.btnPatchImaage.Text = "...";
            this.btnPatchImaage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPatchImaage.UseVisualStyleBackColor = true;
            this.btnPatchImaage.Click += new System.EventHandler(this.btnPatchImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(287, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(131, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(459, 363);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPatchImaage);
            this.Controls.Add(this.pboxProducto);
            this.Controls.Add(this.txbPointsValue);
            this.Controls.Add(this.txbInitialPrice);
            this.Controls.Add(this.txbNameProduct);
            this.Controls.Add(this.txbIdProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbIdProduct;
        private System.Windows.Forms.TextBox txbNameProduct;
        private System.Windows.Forms.TextBox txbInitialPrice;
        private System.Windows.Forms.TextBox txbPointsValue;
        private System.Windows.Forms.PictureBox pboxProducto;
        private System.Windows.Forms.Button btnPatchImaage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelar;
    }
}
namespace AuctionGame_Admin
{
    partial class ChildMainGame
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
            this.btnSearchFamilies = new System.Windows.Forms.Button();
            this.txbSearchFamilies = new System.Windows.Forms.TextBox();
            this.btnDeleteFamily = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchFamilies
            // 
            this.btnSearchFamilies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchFamilies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnSearchFamilies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFamilies.ForeColor = System.Drawing.Color.White;
            this.btnSearchFamilies.Location = new System.Drawing.Point(622, 548);
            this.btnSearchFamilies.Name = "btnSearchFamilies";
            this.btnSearchFamilies.Size = new System.Drawing.Size(150, 35);
            this.btnSearchFamilies.TabIndex = 19;
            this.btnSearchFamilies.Text = "Buscar";
            this.btnSearchFamilies.UseVisualStyleBackColor = false;
            // 
            // txbSearchFamilies
            // 
            this.txbSearchFamilies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchFamilies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchFamilies.ForeColor = System.Drawing.Color.Silver;
            this.txbSearchFamilies.Location = new System.Drawing.Point(427, 108);
            this.txbSearchFamilies.Name = "txbSearchFamilies";
            this.txbSearchFamilies.Size = new System.Drawing.Size(344, 29);
            this.txbSearchFamilies.TabIndex = 17;
            this.txbSearchFamilies.Tag = "Buscar,alfanumerico";
            this.txbSearchFamilies.Text = "Buscar";
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
            // 
            // ChildMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnDeleteFamily);
            this.Controls.Add(this.btnSearchFamilies);
            this.Controls.Add(this.txbSearchFamilies);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildMainGame";
            this.Text = "ChildMenuFamily";
            this.Load += new System.EventHandler(this.ChildMainGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchFamilies;
        private System.Windows.Forms.TextBox txbSearchFamilies;
        private System.Windows.Forms.Button btnDeleteFamily;
    }
}
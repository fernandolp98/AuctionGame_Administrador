namespace AuctionGame_Admin
{
    partial class FrmGame
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
            this.components = new System.ComponentModel.Container();
            this.rtxbUsers = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rtxbActivity = new System.Windows.Forms.RichTextBox();
            this.timerAuction = new System.Windows.Forms.Timer(this.components);
            this.txbClock = new System.Windows.Forms.TextBox();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.lblAuctionNumber = new System.Windows.Forms.Label();
            this.lblCurrentNameProduct = new System.Windows.Forms.Label();
            this.lblLastOffer = new System.Windows.Forms.Label();
            this.pboxCurrentProduct = new System.Windows.Forms.PictureBox();
            this.lblCurrentWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCurrentProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxbUsers
            // 
            this.rtxbUsers.Enabled = false;
            this.rtxbUsers.Location = new System.Drawing.Point(12, 33);
            this.rtxbUsers.Name = "rtxbUsers";
            this.rtxbUsers.Size = new System.Drawing.Size(216, 223);
            this.rtxbUsers.TabIndex = 21;
            this.rtxbUsers.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Usuarios Conectados";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(622, 614);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(150, 35);
            this.btnPlay.TabIndex = 19;
            this.btnPlay.Text = "Iniciar Juego";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rtxbActivity
            // 
            this.rtxbActivity.Location = new System.Drawing.Point(234, 33);
            this.rtxbActivity.Name = "rtxbActivity";
            this.rtxbActivity.ReadOnly = true;
            this.rtxbActivity.Size = new System.Drawing.Size(538, 223);
            this.rtxbActivity.TabIndex = 23;
            this.rtxbActivity.Text = "";
            // 
            // timerAuction
            // 
            this.timerAuction.Interval = 1000;
            this.timerAuction.Tick += new System.EventHandler(this.timerAuction_Tick);
            // 
            // txbClock
            // 
            this.txbClock.Location = new System.Drawing.Point(12, 262);
            this.txbClock.Name = "txbClock";
            this.txbClock.Size = new System.Drawing.Size(100, 29);
            this.txbClock.TabIndex = 24;
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.Location = new System.Drawing.Point(12, 304);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(131, 21);
            this.lblRoundNumber.TabIndex = 25;
            this.lblRoundNumber.Text = "lblRoundNumber";
            // 
            // lblAuctionNumber
            // 
            this.lblAuctionNumber.AutoSize = true;
            this.lblAuctionNumber.Location = new System.Drawing.Point(12, 325);
            this.lblAuctionNumber.Name = "lblAuctionNumber";
            this.lblAuctionNumber.Size = new System.Drawing.Size(138, 21);
            this.lblAuctionNumber.TabIndex = 26;
            this.lblAuctionNumber.Text = "lblAuctionNumber";
            // 
            // lblCurrentNameProduct
            // 
            this.lblCurrentNameProduct.AutoSize = true;
            this.lblCurrentNameProduct.Location = new System.Drawing.Point(12, 346);
            this.lblCurrentNameProduct.Name = "lblCurrentNameProduct";
            this.lblCurrentNameProduct.Size = new System.Drawing.Size(176, 21);
            this.lblCurrentNameProduct.TabIndex = 27;
            this.lblCurrentNameProduct.Text = "lblCurrentNameProduct";
            // 
            // lblLastOffer
            // 
            this.lblLastOffer.AutoSize = true;
            this.lblLastOffer.Location = new System.Drawing.Point(12, 367);
            this.lblLastOffer.Name = "lblLastOffer";
            this.lblLastOffer.Size = new System.Drawing.Size(91, 21);
            this.lblLastOffer.TabIndex = 28;
            this.lblLastOffer.Text = "lblLastOffer";
            // 
            // pboxCurrentProduct
            // 
            this.pboxCurrentProduct.Location = new System.Drawing.Point(639, 262);
            this.pboxCurrentProduct.Name = "pboxCurrentProduct";
            this.pboxCurrentProduct.Size = new System.Drawing.Size(133, 159);
            this.pboxCurrentProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxCurrentProduct.TabIndex = 29;
            this.pboxCurrentProduct.TabStop = false;
            // 
            // lblCurrentWinner
            // 
            this.lblCurrentWinner.AutoSize = true;
            this.lblCurrentWinner.Location = new System.Drawing.Point(12, 388);
            this.lblCurrentWinner.Name = "lblCurrentWinner";
            this.lblCurrentWinner.Size = new System.Drawing.Size(52, 21);
            this.lblCurrentWinner.TabIndex = 30;
            this.lblCurrentWinner.Text = "label2";
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lblCurrentWinner);
            this.Controls.Add(this.pboxCurrentProduct);
            this.Controls.Add(this.lblLastOffer);
            this.Controls.Add(this.lblCurrentNameProduct);
            this.Controls.Add(this.lblAuctionNumber);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.txbClock);
            this.Controls.Add(this.rtxbActivity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxbUsers);
            this.Controls.Add(this.btnPlay);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGame";
            this.Text = "ChildMenuFamily";
            this.Load += new System.EventHandler(this.ChildMainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCurrentProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtxbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RichTextBox rtxbActivity;
        private System.Windows.Forms.Timer timerAuction;
        private System.Windows.Forms.TextBox txbClock;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Label lblAuctionNumber;
        private System.Windows.Forms.Label lblCurrentNameProduct;
        private System.Windows.Forms.Label lblLastOffer;
        private System.Windows.Forms.PictureBox pboxCurrentProduct;
        private System.Windows.Forms.Label lblCurrentWinner;
    }
}
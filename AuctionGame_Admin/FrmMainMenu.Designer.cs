using System;
using System.Drawing;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSubMenuItem6 = new System.Windows.Forms.Panel();
            this.btnUsersStatistics = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnMenuItem6 = new System.Windows.Forms.Button();
            this.pnlSubMenuItem5 = new System.Windows.Forms.Panel();
            this.btnAddRoutines = new System.Windows.Forms.Button();
            this.btnRoutines = new System.Windows.Forms.Button();
            this.btnMenuItem5 = new System.Windows.Forms.Button();
            this.pnlSubMenuItem4 = new System.Windows.Forms.Panel();
            this.btnAddVirtualPlayer = new System.Windows.Forms.Button();
            this.btnVirtualPlayers = new System.Windows.Forms.Button();
            this.btnMenuItem4 = new System.Windows.Forms.Button();
            this.pnlSubMenuItem3 = new System.Windows.Forms.Panel();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnMenuItem3 = new System.Windows.Forms.Button();
            this.pnlSubMenuItem2 = new System.Windows.Forms.Panel();
            this.btnAddFamily = new System.Windows.Forms.Button();
            this.btnFamilies = new System.Windows.Forms.Button();
            this.btnMenuItem2 = new System.Windows.Forms.Button();
            this.pnlSubMenuItem1 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnMenuItem1 = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlSubMenuItem6.SuspendLayout();
            this.pnlSubMenuItem5.SuspendLayout();
            this.pnlSubMenuItem4.SuspendLayout();
            this.pnlSubMenuItem3.SuspendLayout();
            this.pnlSubMenuItem2.SuspendLayout();
            this.pnlSubMenuItem1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.pnlSidebar.Controls.Add(this.pnlSubMenuItem6);
            this.pnlSidebar.Controls.Add(this.btnMenuItem6);
            this.pnlSidebar.Controls.Add(this.pnlSubMenuItem5);
            this.pnlSidebar.Controls.Add(this.btnMenuItem5);
            this.pnlSidebar.Controls.Add(this.pnlSubMenuItem4);
            this.pnlSidebar.Controls.Add(this.btnMenuItem4);
            this.pnlSidebar.Controls.Add(this.pnlSubMenuItem3);
            this.pnlSidebar.Controls.Add(this.btnMenuItem3);
            this.pnlSidebar.Controls.Add(this.pnlSubMenuItem2);
            this.pnlSidebar.Controls.Add(this.btnMenuItem2);
            this.pnlSidebar.Controls.Add(this.pnlSubMenuItem1);
            this.pnlSidebar.Controls.Add(this.btnMenuItem1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(300, 661);
            this.pnlSidebar.TabIndex = 1;
            // 
            // pnlSubMenuItem6
            // 
            this.pnlSubMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.pnlSubMenuItem6.Controls.Add(this.btnUsersStatistics);
            this.pnlSubMenuItem6.Controls.Add(this.btnUsers);
            this.pnlSubMenuItem6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuItem6.Location = new System.Drawing.Point(0, 785);
            this.pnlSubMenuItem6.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubMenuItem6.Name = "pnlSubMenuItem6";
            this.pnlSubMenuItem6.Size = new System.Drawing.Size(283, 98);
            this.pnlSubMenuItem6.TabIndex = 8;
            this.pnlSubMenuItem6.Visible = false;
            // 
            // btnUsersStatistics
            // 
            this.btnUsersStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsersStatistics.FlatAppearance.BorderSize = 0;
            this.btnUsersStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnUsersStatistics.Location = new System.Drawing.Point(0, 49);
            this.btnUsersStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsersStatistics.Name = "btnUsersStatistics";
            this.btnUsersStatistics.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnUsersStatistics.Size = new System.Drawing.Size(283, 49);
            this.btnUsersStatistics.TabIndex = 4;
            this.btnUsersStatistics.Text = "Ver Estadíticas";
            this.btnUsersStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsersStatistics.UseVisualStyleBackColor = true;
            this.btnUsersStatistics.Click += new System.EventHandler(this.btnUsersStatistics_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(283, 49);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Ver Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnMenuItem6
            // 
            this.btnMenuItem6.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuItem6.FlatAppearance.BorderSize = 0;
            this.btnMenuItem6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnMenuItem6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnMenuItem6.Location = new System.Drawing.Point(0, 736);
            this.btnMenuItem6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuItem6.Name = "btnMenuItem6";
            this.btnMenuItem6.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnMenuItem6.Size = new System.Drawing.Size(283, 49);
            this.btnMenuItem6.TabIndex = 9;
            this.btnMenuItem6.Text = "Usuarios";
            this.btnMenuItem6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItem6.UseVisualStyleBackColor = true;
            this.btnMenuItem6.Click += new System.EventHandler(this.btnMenuItem6_Click);
            // 
            // pnlSubMenuItem5
            // 
            this.pnlSubMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.pnlSubMenuItem5.Controls.Add(this.btnAddRoutines);
            this.pnlSubMenuItem5.Controls.Add(this.btnRoutines);
            this.pnlSubMenuItem5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuItem5.Location = new System.Drawing.Point(0, 638);
            this.pnlSubMenuItem5.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubMenuItem5.Name = "pnlSubMenuItem5";
            this.pnlSubMenuItem5.Size = new System.Drawing.Size(283, 98);
            this.pnlSubMenuItem5.TabIndex = 10;
            this.pnlSubMenuItem5.Visible = false;
            // 
            // btnAddRoutines
            // 
            this.btnAddRoutines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRoutines.FlatAppearance.BorderSize = 0;
            this.btnAddRoutines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoutines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnAddRoutines.Location = new System.Drawing.Point(0, 49);
            this.btnAddRoutines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddRoutines.Name = "btnAddRoutines";
            this.btnAddRoutines.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnAddRoutines.Size = new System.Drawing.Size(283, 49);
            this.btnAddRoutines.TabIndex = 8;
            this.btnAddRoutines.Text = "Agregar Rutina";
            this.btnAddRoutines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRoutines.UseVisualStyleBackColor = true;
            this.btnAddRoutines.Click += new System.EventHandler(this.btnAddRoutines_Click);
            // 
            // btnRoutines
            // 
            this.btnRoutines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoutines.FlatAppearance.BorderSize = 0;
            this.btnRoutines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoutines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnRoutines.Location = new System.Drawing.Point(0, 0);
            this.btnRoutines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoutines.Name = "btnRoutines";
            this.btnRoutines.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnRoutines.Size = new System.Drawing.Size(283, 49);
            this.btnRoutines.TabIndex = 7;
            this.btnRoutines.Text = "Ver Rutinas";
            this.btnRoutines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoutines.UseVisualStyleBackColor = true;
            this.btnRoutines.Click += new System.EventHandler(this.btnRoutines_Click);
            // 
            // btnMenuItem5
            // 
            this.btnMenuItem5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuItem5.FlatAppearance.BorderSize = 0;
            this.btnMenuItem5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnMenuItem5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnMenuItem5.Location = new System.Drawing.Point(0, 589);
            this.btnMenuItem5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuItem5.Name = "btnMenuItem5";
            this.btnMenuItem5.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnMenuItem5.Size = new System.Drawing.Size(283, 49);
            this.btnMenuItem5.TabIndex = 9;
            this.btnMenuItem5.Text = "Rutinas";
            this.btnMenuItem5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItem5.UseVisualStyleBackColor = true;
            this.btnMenuItem5.Click += new System.EventHandler(this.btnMenuItem5_Click);
            // 
            // pnlSubMenuItem4
            // 
            this.pnlSubMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.pnlSubMenuItem4.Controls.Add(this.btnAddVirtualPlayer);
            this.pnlSubMenuItem4.Controls.Add(this.btnVirtualPlayers);
            this.pnlSubMenuItem4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuItem4.Location = new System.Drawing.Point(0, 491);
            this.pnlSubMenuItem4.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubMenuItem4.Name = "pnlSubMenuItem4";
            this.pnlSubMenuItem4.Size = new System.Drawing.Size(283, 98);
            this.pnlSubMenuItem4.TabIndex = 8;
            this.pnlSubMenuItem4.Visible = false;
            // 
            // btnAddVirtualPlayer
            // 
            this.btnAddVirtualPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddVirtualPlayer.FlatAppearance.BorderSize = 0;
            this.btnAddVirtualPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVirtualPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnAddVirtualPlayer.Location = new System.Drawing.Point(0, 49);
            this.btnAddVirtualPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddVirtualPlayer.Name = "btnAddVirtualPlayer";
            this.btnAddVirtualPlayer.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnAddVirtualPlayer.Size = new System.Drawing.Size(283, 49);
            this.btnAddVirtualPlayer.TabIndex = 8;
            this.btnAddVirtualPlayer.Text = "Agregar Jugador Virtual";
            this.btnAddVirtualPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVirtualPlayer.UseVisualStyleBackColor = true;
            this.btnAddVirtualPlayer.Click += new System.EventHandler(this.btnAddVirtualPlayer_Click);
            // 
            // btnVirtualPlayers
            // 
            this.btnVirtualPlayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVirtualPlayers.FlatAppearance.BorderSize = 0;
            this.btnVirtualPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirtualPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnVirtualPlayers.Location = new System.Drawing.Point(0, 0);
            this.btnVirtualPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVirtualPlayers.Name = "btnVirtualPlayers";
            this.btnVirtualPlayers.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnVirtualPlayers.Size = new System.Drawing.Size(283, 49);
            this.btnVirtualPlayers.TabIndex = 7;
            this.btnVirtualPlayers.Text = "Ver Jugadores Virtuales";
            this.btnVirtualPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVirtualPlayers.UseVisualStyleBackColor = true;
            this.btnVirtualPlayers.Click += new System.EventHandler(this.btnVirtualPlayers_Click);
            // 
            // btnMenuItem4
            // 
            this.btnMenuItem4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuItem4.FlatAppearance.BorderSize = 0;
            this.btnMenuItem4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnMenuItem4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnMenuItem4.Location = new System.Drawing.Point(0, 442);
            this.btnMenuItem4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuItem4.Name = "btnMenuItem4";
            this.btnMenuItem4.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnMenuItem4.Size = new System.Drawing.Size(283, 49);
            this.btnMenuItem4.TabIndex = 7;
            this.btnMenuItem4.Text = "Jugadores Virtuales";
            this.btnMenuItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItem4.UseVisualStyleBackColor = true;
            this.btnMenuItem4.Click += new System.EventHandler(this.btnMenuItem4_Click);
            // 
            // pnlSubMenuItem3
            // 
            this.pnlSubMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.pnlSubMenuItem3.Controls.Add(this.btnAddRole);
            this.pnlSubMenuItem3.Controls.Add(this.btnRoles);
            this.pnlSubMenuItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuItem3.Location = new System.Drawing.Point(0, 344);
            this.pnlSubMenuItem3.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubMenuItem3.Name = "pnlSubMenuItem3";
            this.pnlSubMenuItem3.Size = new System.Drawing.Size(283, 98);
            this.pnlSubMenuItem3.TabIndex = 6;
            this.pnlSubMenuItem3.Visible = false;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRole.FlatAppearance.BorderSize = 0;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnAddRole.Location = new System.Drawing.Point(0, 49);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnAddRole.Size = new System.Drawing.Size(283, 49);
            this.btnAddRole.TabIndex = 8;
            this.btnAddRole.Text = "Agregar Rol";
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnRoles.Location = new System.Drawing.Point(0, 0);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnRoles.Size = new System.Drawing.Size(283, 49);
            this.btnRoles.TabIndex = 7;
            this.btnRoles.Text = "Ver Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnMenuItem3
            // 
            this.btnMenuItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuItem3.FlatAppearance.BorderSize = 0;
            this.btnMenuItem3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnMenuItem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnMenuItem3.Location = new System.Drawing.Point(0, 295);
            this.btnMenuItem3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuItem3.Name = "btnMenuItem3";
            this.btnMenuItem3.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnMenuItem3.Size = new System.Drawing.Size(283, 49);
            this.btnMenuItem3.TabIndex = 5;
            this.btnMenuItem3.Text = "Roles";
            this.btnMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItem3.UseVisualStyleBackColor = true;
            this.btnMenuItem3.Click += new System.EventHandler(this.btnMenuItem3_Click);
            // 
            // pnlSubMenuItem2
            // 
            this.pnlSubMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.pnlSubMenuItem2.Controls.Add(this.btnAddFamily);
            this.pnlSubMenuItem2.Controls.Add(this.btnFamilies);
            this.pnlSubMenuItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuItem2.Location = new System.Drawing.Point(0, 197);
            this.pnlSubMenuItem2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubMenuItem2.Name = "pnlSubMenuItem2";
            this.pnlSubMenuItem2.Size = new System.Drawing.Size(283, 98);
            this.pnlSubMenuItem2.TabIndex = 4;
            this.pnlSubMenuItem2.Visible = false;
            // 
            // btnAddFamily
            // 
            this.btnAddFamily.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddFamily.FlatAppearance.BorderSize = 0;
            this.btnAddFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnAddFamily.Location = new System.Drawing.Point(0, 49);
            this.btnAddFamily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFamily.Name = "btnAddFamily";
            this.btnAddFamily.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnAddFamily.Size = new System.Drawing.Size(283, 49);
            this.btnAddFamily.TabIndex = 4;
            this.btnAddFamily.Text = "Agregar Familia";
            this.btnAddFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFamily.UseVisualStyleBackColor = true;
            this.btnAddFamily.Click += new System.EventHandler(this.btnAddFamily_Click);
            // 
            // btnFamilies
            // 
            this.btnFamilies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFamilies.FlatAppearance.BorderSize = 0;
            this.btnFamilies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamilies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnFamilies.Location = new System.Drawing.Point(0, 0);
            this.btnFamilies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFamilies.Name = "btnFamilies";
            this.btnFamilies.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnFamilies.Size = new System.Drawing.Size(283, 49);
            this.btnFamilies.TabIndex = 3;
            this.btnFamilies.Text = "Ver Familias";
            this.btnFamilies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFamilies.UseVisualStyleBackColor = true;
            this.btnFamilies.Click += new System.EventHandler(this.btnFamilies_Click);
            // 
            // btnMenuItem2
            // 
            this.btnMenuItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuItem2.FlatAppearance.BorderSize = 0;
            this.btnMenuItem2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnMenuItem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnMenuItem2.Location = new System.Drawing.Point(0, 148);
            this.btnMenuItem2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuItem2.Name = "btnMenuItem2";
            this.btnMenuItem2.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnMenuItem2.Size = new System.Drawing.Size(283, 49);
            this.btnMenuItem2.TabIndex = 3;
            this.btnMenuItem2.Text = "Familias";
            this.btnMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItem2.UseVisualStyleBackColor = true;
            this.btnMenuItem2.Click += new System.EventHandler(this.btnMenuItem2_Click);
            // 
            // pnlSubMenuItem1
            // 
            this.pnlSubMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.pnlSubMenuItem1.Controls.Add(this.btnAddProduct);
            this.pnlSubMenuItem1.Controls.Add(this.btnProducts);
            this.pnlSubMenuItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuItem1.Location = new System.Drawing.Point(0, 49);
            this.pnlSubMenuItem1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubMenuItem1.Name = "pnlSubMenuItem1";
            this.pnlSubMenuItem1.Size = new System.Drawing.Size(283, 99);
            this.pnlSubMenuItem1.TabIndex = 2;
            this.pnlSubMenuItem1.Visible = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnAddProduct.Location = new System.Drawing.Point(0, 49);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnAddProduct.Size = new System.Drawing.Size(283, 49);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Agregar Producto";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 0);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(283, 49);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Ver Productos";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnMenuItem1
            // 
            this.btnMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenuItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuItem1.FlatAppearance.BorderSize = 0;
            this.btnMenuItem1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnMenuItem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItem1.Location = new System.Drawing.Point(0, 0);
            this.btnMenuItem1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuItem1.Name = "btnMenuItem1";
            this.btnMenuItem1.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnMenuItem1.Size = new System.Drawing.Size(283, 49);
            this.btnMenuItem1.TabIndex = 1;
            this.btnMenuItem1.Text = "Productos";
            this.btnMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMenuItem1.UseVisualStyleBackColor = true;
            this.btnMenuItem1.Click += new System.EventHandler(this.btnMenuItem1_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(216)))));
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDashboard.Location = new System.Drawing.Point(300, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(784, 661);
            this.pnlDashboard.TabIndex = 2;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auction Game (Administrador)";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSubMenuItem6.ResumeLayout(false);
            this.pnlSubMenuItem5.ResumeLayout(false);
            this.pnlSubMenuItem4.ResumeLayout(false);
            this.pnlSubMenuItem3.ResumeLayout(false);
            this.pnlSubMenuItem2.ResumeLayout(false);
            this.pnlSubMenuItem1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnMenuItem3;
        private System.Windows.Forms.Panel pnlSubMenuItem2;
        private System.Windows.Forms.Button btnAddFamily;
        private System.Windows.Forms.Button btnFamilies;
        private System.Windows.Forms.Button btnMenuItem2;
        private System.Windows.Forms.Panel pnlSubMenuItem1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnMenuItem1;
        private System.Windows.Forms.Panel pnlSubMenuItem3;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Panel pnlSubMenuItem4;
        private System.Windows.Forms.Button btnAddVirtualPlayer;
        private System.Windows.Forms.Button btnVirtualPlayers;
        private System.Windows.Forms.Button btnMenuItem4;
        private System.Windows.Forms.Button btnMenuItem5;
        private System.Windows.Forms.Panel pnlSubMenuItem5;
        private System.Windows.Forms.Button btnAddRoutines;
        private System.Windows.Forms.Button btnRoutines;
        private System.Windows.Forms.Button btnMenuItem6;
        private System.Windows.Forms.Panel pnlSubMenuItem6;
        private System.Windows.Forms.Button btnUsers;
        private Button btnUsersStatistics;
    }
}


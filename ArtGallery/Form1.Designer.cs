
namespace ArtGallery
{
    partial class Form1
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
            this.panelSideMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnArtist = new System.Windows.Forms.Button();
            this.panelArtist = new System.Windows.Forms.Panel();
            this.btnViewArtists = new System.Windows.Forms.Button();
            this.btnEditArtist = new System.Windows.Forms.Button();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.btnArtwork = new System.Windows.Forms.Button();
            this.panelArtwork = new System.Windows.Forms.Panel();
            this.btnRentArtwork = new System.Windows.Forms.Button();
            this.btnViewArtworks = new System.Windows.Forms.Button();
            this.btnAddArtwork = new System.Windows.Forms.Button();
            this.btnExhibition = new System.Windows.Forms.Button();
            this.panelExhibition = new System.Windows.Forms.Panel();
            this.btnViewExhibition = new System.Windows.Forms.Button();
            this.btnAddExhibition = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.oracleCommandBuilder1 = new Oracle.ManagedDataAccess.Client.OracleCommandBuilder();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelArtist.SuspendLayout();
            this.panelArtwork.SuspendLayout();
            this.panelExhibition.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelSideMenu.Controls.Add(this.panel5);
            this.panelSideMenu.Controls.Add(this.btnArtist);
            this.panelSideMenu.Controls.Add(this.panelArtist);
            this.panelSideMenu.Controls.Add(this.btnArtwork);
            this.panelSideMenu.Controls.Add(this.panelArtwork);
            this.panelSideMenu.Controls.Add(this.btnExhibition);
            this.panelSideMenu.Controls.Add(this.panelExhibition);
            this.panelSideMenu.Controls.Add(this.btnCustomer);
            this.panelSideMenu.Controls.Add(this.panelCustomer);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(175, 600);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 48);
            this.panel5.TabIndex = 7;
            // 
            // btnArtist
            // 
            this.btnArtist.FlatAppearance.BorderSize = 0;
            this.btnArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtist.ForeColor = System.Drawing.Color.White;
            this.btnArtist.Location = new System.Drawing.Point(3, 57);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(172, 35);
            this.btnArtist.TabIndex = 1;
            this.btnArtist.Text = "Artists";
            this.btnArtist.UseVisualStyleBackColor = true;
            this.btnArtist.Click += new System.EventHandler(this.buttonArtist_Click);
            // 
            // panelArtist
            // 
            this.panelArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelArtist.Controls.Add(this.btnViewArtists);
            this.panelArtist.Controls.Add(this.btnEditArtist);
            this.panelArtist.Controls.Add(this.btnAddArtist);
            this.panelArtist.Location = new System.Drawing.Point(3, 98);
            this.panelArtist.Name = "panelArtist";
            this.panelArtist.Size = new System.Drawing.Size(172, 70);
            this.panelArtist.TabIndex = 1;
            // 
            // btnViewArtists
            // 
            this.btnViewArtists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewArtists.FlatAppearance.BorderSize = 0;
            this.btnViewArtists.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnViewArtists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnViewArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewArtists.ForeColor = System.Drawing.Color.Silver;
            this.btnViewArtists.Location = new System.Drawing.Point(0, 45);
            this.btnViewArtists.Name = "btnViewArtists";
            this.btnViewArtists.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnViewArtists.Size = new System.Drawing.Size(172, 22);
            this.btnViewArtists.TabIndex = 1;
            this.btnViewArtists.Text = "View Artists";
            this.btnViewArtists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewArtists.UseVisualStyleBackColor = true;
            this.btnViewArtists.Click += new System.EventHandler(this.btnViewArtists_Click);
            // 
            // btnEditArtist
            // 
            this.btnEditArtist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditArtist.FlatAppearance.BorderSize = 0;
            this.btnEditArtist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnEditArtist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnEditArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditArtist.ForeColor = System.Drawing.Color.Silver;
            this.btnEditArtist.Location = new System.Drawing.Point(0, 23);
            this.btnEditArtist.Name = "btnEditArtist";
            this.btnEditArtist.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnEditArtist.Size = new System.Drawing.Size(172, 22);
            this.btnEditArtist.TabIndex = 2;
            this.btnEditArtist.Text = "Edit Artist";
            this.btnEditArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditArtist.UseVisualStyleBackColor = true;
            this.btnEditArtist.Click += new System.EventHandler(this.btnEditArtist_Click);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddArtist.FlatAppearance.BorderSize = 0;
            this.btnAddArtist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAddArtist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAddArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArtist.ForeColor = System.Drawing.Color.Silver;
            this.btnAddArtist.Location = new System.Drawing.Point(0, 0);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAddArtist.Size = new System.Drawing.Size(172, 23);
            this.btnAddArtist.TabIndex = 1;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // btnArtwork
            // 
            this.btnArtwork.FlatAppearance.BorderSize = 0;
            this.btnArtwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtwork.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtwork.ForeColor = System.Drawing.Color.White;
            this.btnArtwork.Location = new System.Drawing.Point(3, 174);
            this.btnArtwork.Name = "btnArtwork";
            this.btnArtwork.Size = new System.Drawing.Size(172, 35);
            this.btnArtwork.TabIndex = 3;
            this.btnArtwork.Text = "Artworks";
            this.btnArtwork.UseVisualStyleBackColor = true;
            this.btnArtwork.Click += new System.EventHandler(this.buttonArtwork_Click);
            // 
            // panelArtwork
            // 
            this.panelArtwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelArtwork.Controls.Add(this.btnRentArtwork);
            this.panelArtwork.Controls.Add(this.btnViewArtworks);
            this.panelArtwork.Controls.Add(this.btnAddArtwork);
            this.panelArtwork.Location = new System.Drawing.Point(3, 215);
            this.panelArtwork.Name = "panelArtwork";
            this.panelArtwork.Size = new System.Drawing.Size(172, 92);
            this.panelArtwork.TabIndex = 3;
            // 
            // btnRentArtwork
            // 
            this.btnRentArtwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRentArtwork.FlatAppearance.BorderSize = 0;
            this.btnRentArtwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnRentArtwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnRentArtwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentArtwork.ForeColor = System.Drawing.Color.Silver;
            this.btnRentArtwork.Location = new System.Drawing.Point(0, 46);
            this.btnRentArtwork.Name = "btnRentArtwork";
            this.btnRentArtwork.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnRentArtwork.Size = new System.Drawing.Size(172, 23);
            this.btnRentArtwork.TabIndex = 3;
            this.btnRentArtwork.Text = "Rent Artwork";
            this.btnRentArtwork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentArtwork.UseVisualStyleBackColor = true;
            this.btnRentArtwork.Click += new System.EventHandler(this.btnRentArtwork_Click);
            // 
            // btnViewArtworks
            // 
            this.btnViewArtworks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewArtworks.FlatAppearance.BorderSize = 0;
            this.btnViewArtworks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnViewArtworks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnViewArtworks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewArtworks.ForeColor = System.Drawing.Color.Silver;
            this.btnViewArtworks.Location = new System.Drawing.Point(0, 23);
            this.btnViewArtworks.Name = "btnViewArtworks";
            this.btnViewArtworks.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnViewArtworks.Size = new System.Drawing.Size(172, 23);
            this.btnViewArtworks.TabIndex = 2;
            this.btnViewArtworks.Text = "View Artworks";
            this.btnViewArtworks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewArtworks.UseVisualStyleBackColor = true;
            this.btnViewArtworks.Click += new System.EventHandler(this.btnViewArtworks_Click);
            // 
            // btnAddArtwork
            // 
            this.btnAddArtwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddArtwork.FlatAppearance.BorderSize = 0;
            this.btnAddArtwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAddArtwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAddArtwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArtwork.ForeColor = System.Drawing.Color.Silver;
            this.btnAddArtwork.Location = new System.Drawing.Point(0, 0);
            this.btnAddArtwork.Name = "btnAddArtwork";
            this.btnAddArtwork.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAddArtwork.Size = new System.Drawing.Size(172, 23);
            this.btnAddArtwork.TabIndex = 1;
            this.btnAddArtwork.Text = "Add Artwork";
            this.btnAddArtwork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddArtwork.UseVisualStyleBackColor = true;
            this.btnAddArtwork.Click += new System.EventHandler(this.btnAddArtwork_Click);
            // 
            // btnExhibition
            // 
            this.btnExhibition.FlatAppearance.BorderSize = 0;
            this.btnExhibition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExhibition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExhibition.ForeColor = System.Drawing.Color.White;
            this.btnExhibition.Location = new System.Drawing.Point(3, 313);
            this.btnExhibition.Name = "btnExhibition";
            this.btnExhibition.Size = new System.Drawing.Size(172, 35);
            this.btnExhibition.TabIndex = 4;
            this.btnExhibition.Text = "Exhibitions";
            this.btnExhibition.UseVisualStyleBackColor = true;
            this.btnExhibition.Click += new System.EventHandler(this.buttonExhibition_Click);
            // 
            // panelExhibition
            // 
            this.panelExhibition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelExhibition.Controls.Add(this.btnViewExhibition);
            this.panelExhibition.Controls.Add(this.btnAddExhibition);
            this.panelExhibition.Location = new System.Drawing.Point(3, 354);
            this.panelExhibition.Name = "panelExhibition";
            this.panelExhibition.Size = new System.Drawing.Size(172, 45);
            this.panelExhibition.TabIndex = 6;
            // 
            // btnViewExhibition
            // 
            this.btnViewExhibition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewExhibition.FlatAppearance.BorderSize = 0;
            this.btnViewExhibition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnViewExhibition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnViewExhibition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewExhibition.ForeColor = System.Drawing.Color.Silver;
            this.btnViewExhibition.Location = new System.Drawing.Point(0, 23);
            this.btnViewExhibition.Name = "btnViewExhibition";
            this.btnViewExhibition.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnViewExhibition.Size = new System.Drawing.Size(172, 23);
            this.btnViewExhibition.TabIndex = 3;
            this.btnViewExhibition.Text = "View Exhibition";
            this.btnViewExhibition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewExhibition.UseVisualStyleBackColor = true;
            this.btnViewExhibition.Click += new System.EventHandler(this.btnViewExhibition_Click);
            // 
            // btnAddExhibition
            // 
            this.btnAddExhibition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddExhibition.FlatAppearance.BorderSize = 0;
            this.btnAddExhibition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAddExhibition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAddExhibition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExhibition.ForeColor = System.Drawing.Color.Silver;
            this.btnAddExhibition.Location = new System.Drawing.Point(0, 0);
            this.btnAddExhibition.Name = "btnAddExhibition";
            this.btnAddExhibition.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAddExhibition.Size = new System.Drawing.Size(172, 23);
            this.btnAddExhibition.TabIndex = 2;
            this.btnAddExhibition.Text = "Add Exhibition";
            this.btnAddExhibition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExhibition.UseVisualStyleBackColor = true;
            this.btnAddExhibition.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(3, 405);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(172, 35);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelCustomer.Controls.Add(this.btnAddCustomer);
            this.panelCustomer.Controls.Add(this.btnViewCustomers);
            this.panelCustomer.Location = new System.Drawing.Point(3, 446);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(175, 70);
            this.panelCustomer.TabIndex = 2;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Silver;
            this.btnAddCustomer.Location = new System.Drawing.Point(0, 23);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAddCustomer.Size = new System.Drawing.Size(175, 23);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCustomers.FlatAppearance.BorderSize = 0;
            this.btnViewCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnViewCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnViewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomers.ForeColor = System.Drawing.Color.Silver;
            this.btnViewCustomers.Location = new System.Drawing.Point(0, 0);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnViewCustomers.Size = new System.Drawing.Size(175, 23);
            this.btnViewCustomers.TabIndex = 0;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // oracleCommandBuilder1
            // 
            this.oracleCommandBuilder1.CatalogLocation = System.Data.Common.CatalogLocation.End;
            this.oracleCommandBuilder1.CatalogSeparator = "@";
            // 
            // panelPlayer
            // 
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(175, 564);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(785, 36);
            this.panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(175, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(785, 564);
            this.panelChildForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(980, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelArtist.ResumeLayout(false);
            this.panelArtwork.ResumeLayout(false);
            this.panelExhibition.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelSideMenu;
        private System.Windows.Forms.Panel panelCustomer;
        private Oracle.ManagedDataAccess.Client.OracleCommandBuilder oracleCommandBuilder1;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Button btnArtwork;
        private System.Windows.Forms.Button btnExhibition;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelArtist;
        private System.Windows.Forms.Button btnEditArtist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Panel panelArtwork;
        private System.Windows.Forms.Panel panelExhibition;
        private System.Windows.Forms.Button btnViewArtists;
        private System.Windows.Forms.Button btnViewArtworks;
        private System.Windows.Forms.Button btnAddArtwork;
        private System.Windows.Forms.Button btnViewExhibition;
        private System.Windows.Forms.Button btnAddExhibition;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Button btnRentArtwork;
    }
}
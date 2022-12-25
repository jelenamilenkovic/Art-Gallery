
namespace ArtGallery.Forms
{
    partial class AddArtist
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
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.txtArtistLName = new System.Windows.Forms.TextBox();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddArtistDB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTP);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.Country);
            this.groupBox1.Controls.Add(this.City);
            this.groupBox1.Controls.Add(this.txtArtistLName);
            this.groupBox1.Controls.Add(this.txtArtistName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(39, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add artist";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTP
            // 
            this.dateTP.Location = new System.Drawing.Point(131, 137);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(224, 20);
            this.dateTP.TabIndex = 15;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(402, 90);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(114, 20);
            this.txtCountry.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(402, 32);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(114, 20);
            this.txtCity.TabIndex = 13;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(318, 93);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(50, 13);
            this.Country.TabIndex = 12;
            this.Country.Text = "Country";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(318, 35);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(28, 13);
            this.City.TabIndex = 11;
            this.City.Text = "City";
            // 
            // txtArtistLName
            // 
            this.txtArtistLName.Location = new System.Drawing.Point(131, 90);
            this.txtArtistLName.Name = "txtArtistLName";
            this.txtArtistLName.Size = new System.Drawing.Size(114, 20);
            this.txtArtistLName.TabIndex = 9;
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(131, 33);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(114, 20);
            this.txtArtistName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "BirthDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // btnAddArtistDB
            // 
            this.btnAddArtistDB.Location = new System.Drawing.Point(494, 314);
            this.btnAddArtistDB.Name = "btnAddArtistDB";
            this.btnAddArtistDB.Size = new System.Drawing.Size(110, 27);
            this.btnAddArtistDB.TabIndex = 2;
            this.btnAddArtistDB.Text = "Add";
            this.btnAddArtistDB.UseVisualStyleBackColor = true;
            this.btnAddArtistDB.Click += new System.EventHandler(this.btnAddArtistDB_Click);
            // 
            // AddArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.btnAddArtistDB);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddArtist";
            this.Text = "AddArtist";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox txtArtistLName;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddArtistDB;
        private System.Windows.Forms.DateTimePicker dateTP;
    }
}
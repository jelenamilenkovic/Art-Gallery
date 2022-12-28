
namespace ArtGallery.Forms
{
    partial class AddCustomer
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
            this.btnAddCustomerDB = new System.Windows.Forms.Button();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.txtCustomerLName = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCustomerDB
            // 
            this.btnAddCustomerDB.Location = new System.Drawing.Point(540, 322);
            this.btnAddCustomerDB.Name = "btnAddCustomerDB";
            this.btnAddCustomerDB.Size = new System.Drawing.Size(110, 27);
            this.btnAddCustomerDB.TabIndex = 4;
            this.btnAddCustomerDB.Text = "Add";
            this.btnAddCustomerDB.UseVisualStyleBackColor = true;
            this.btnAddCustomerDB.Click += new System.EventHandler(this.btnAddCustomerDB_Click);
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.txtAddress);
            this.groupBoxCustomer.Controls.Add(this.txtEmail);
            this.groupBoxCustomer.Controls.Add(this.Country);
            this.groupBoxCustomer.Controls.Add(this.Email);
            this.groupBoxCustomer.Controls.Add(this.txtCustomerLName);
            this.groupBoxCustomer.Controls.Add(this.txtCustomerName);
            this.groupBoxCustomer.Controls.Add(this.label3);
            this.groupBoxCustomer.Controls.Add(this.label2);
            this.groupBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxCustomer.Location = new System.Drawing.Point(25, 12);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(625, 299);
            this.groupBoxCustomer.TabIndex = 3;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Add customer";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(402, 75);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(114, 20);
            this.txtAddress.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(402, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(114, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(318, 78);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(52, 13);
            this.Country.TabIndex = 12;
            this.Country.Text = "Address";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(318, 32);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(37, 13);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email";
            // 
            // txtCustomerLName
            // 
            this.txtCustomerLName.Location = new System.Drawing.Point(131, 75);
            this.txtCustomerLName.Name = "txtCustomerLName";
            this.txtCustomerLName.Size = new System.Drawing.Size(114, 20);
            this.txtCustomerLName.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(131, 30);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(114, 20);
            this.txtCustomerName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.btnAddCustomerDB);
            this.Controls.Add(this.groupBoxCustomer);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomerDB;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtCustomerLName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
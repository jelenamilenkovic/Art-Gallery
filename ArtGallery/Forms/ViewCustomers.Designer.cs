
namespace ArtGallery.Forms
{
    partial class ViewCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.IDCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToResizeColumns = false;
            this.dataGridViewCustomers.AllowUserToResizeRows = false;
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCustomer,
            this.NameCustomer,
            this.LastNameC,
            this.EmailC,
            this.AddressC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCustomers.EnableHeadersVisualStyles = false;
            this.dataGridViewCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewCustomers.Location = new System.Drawing.Point(47, 36);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCustomers.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewCustomers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(544, 185);
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            // 
            // IDCustomer
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.IDCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.IDCustomer.HeaderText = "ID";
            this.IDCustomer.Name = "IDCustomer";
            // 
            // NameCustomer
            // 
            this.NameCustomer.HeaderText = "Name";
            this.NameCustomer.Name = "NameCustomer";
            // 
            // LastNameC
            // 
            this.LastNameC.HeaderText = "Last Name";
            this.LastNameC.Name = "LastNameC";
            // 
            // EmailC
            // 
            this.EmailC.HeaderText = "Email";
            this.EmailC.Name = "EmailC";
            // 
            // AddressC
            // 
            this.AddressC.HeaderText = "Address";
            this.AddressC.Name = "AddressC";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(471, 272);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(120, 26);
            this.btnDeleteCustomer.TabIndex = 1;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Name = "ViewCustomers";
            this.Text = "ViewCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressC;
        private System.Windows.Forms.Button btnDeleteCustomer;
    }
}
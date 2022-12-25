
namespace ArtGallery.Forms
{
    partial class ViewArtists
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteArtist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ArtistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteArtist
            // 
            this.btnDeleteArtist.Location = new System.Drawing.Point(483, 304);
            this.btnDeleteArtist.Name = "btnDeleteArtist";
            this.btnDeleteArtist.Size = new System.Drawing.Size(162, 35);
            this.btnDeleteArtist.TabIndex = 1;
            this.btnDeleteArtist.Text = "Delete Artist";
            this.btnDeleteArtist.UseVisualStyleBackColor = true;
            this.btnDeleteArtist.Click += new System.EventHandler(this.btnDeleteArtist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtistID,
            this.ArtistName,
            this.ArtistLastName,
            this.ArtistCity,
            this.ArtistCountry,
            this.ArtistBD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(633, 201);
            this.dataGridView1.TabIndex = 2;
            // 
            // ArtistID
            // 
            this.ArtistID.HeaderText = "ID";
            this.ArtistID.Name = "ArtistID";
            // 
            // ArtistName
            // 
            this.ArtistName.HeaderText = "Name";
            this.ArtistName.Name = "ArtistName";
            // 
            // ArtistLastName
            // 
            this.ArtistLastName.HeaderText = "Last Name";
            this.ArtistLastName.Name = "ArtistLastName";
            // 
            // ArtistCity
            // 
            this.ArtistCity.HeaderText = "City";
            this.ArtistCity.Name = "ArtistCity";
            // 
            // ArtistCountry
            // 
            this.ArtistCountry.HeaderText = "Country";
            this.ArtistCountry.Name = "ArtistCountry";
            // 
            // ArtistBD
            // 
            this.ArtistBD.HeaderText = "BirthDate";
            this.ArtistBD.Name = "ArtistBD";
            // 
            // ViewArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteArtist);
            this.Name = "ViewArtists";
            this.Text = "ViewArtists";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteArtist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistBD;
    }
}
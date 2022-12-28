
namespace ArtGallery.Forms
{
    partial class RentArtwork
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.groupBoxRent = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxArtworks = new System.Windows.Forms.GroupBox();
            this.dataGridViewArtworks = new System.Windows.Forms.DataGridView();
            this.IDEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StyleArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtworksType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrawnArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRent = new System.Windows.Forms.Button();
            this.groupBoxRent.SuspendLayout();
            this.groupBoxArtworks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtworks)).BeginInit();
            this.groupBoxCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(61, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(61, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "End Date";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(136, 23);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(274, 25);
            this.dateTimePickerStart.TabIndex = 22;
            // 
            // groupBoxRent
            // 
            this.groupBoxRent.Controls.Add(this.btnRent);
            this.groupBoxRent.Controls.Add(this.groupBoxCustomers);
            this.groupBoxRent.Controls.Add(this.groupBoxArtworks);
            this.groupBoxRent.Controls.Add(this.btnSearch);
            this.groupBoxRent.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxRent.Controls.Add(this.dateTimePickerStart);
            this.groupBoxRent.Controls.Add(this.label5);
            this.groupBoxRent.Controls.Add(this.label1);
            this.groupBoxRent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxRent.Location = new System.Drawing.Point(43, 3);
            this.groupBoxRent.Name = "groupBoxRent";
            this.groupBoxRent.Size = new System.Drawing.Size(593, 418);
            this.groupBoxRent.TabIndex = 23;
            this.groupBoxRent.TabStop = false;
            this.groupBoxRent.Text = "Rent Artworks";
            this.groupBoxRent.Enter += new System.EventHandler(this.groupBoxRent_Enter);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(136, 54);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(274, 25);
            this.dateTimePickerEnd.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(426, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 25);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxArtworks
            // 
            this.groupBoxArtworks.Controls.Add(this.dataGridViewArtworks);
            this.groupBoxArtworks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxArtworks.Location = new System.Drawing.Point(20, 85);
            this.groupBoxArtworks.Name = "groupBoxArtworks";
            this.groupBoxArtworks.Size = new System.Drawing.Size(555, 145);
            this.groupBoxArtworks.TabIndex = 25;
            this.groupBoxArtworks.TabStop = false;
            this.groupBoxArtworks.Text = "View Artworks";
            // 
            // dataGridViewArtworks
            // 
            this.dataGridViewArtworks.AllowUserToAddRows = false;
            this.dataGridViewArtworks.AllowUserToDeleteRows = false;
            this.dataGridViewArtworks.AllowUserToResizeColumns = false;
            this.dataGridViewArtworks.AllowUserToResizeRows = false;
            this.dataGridViewArtworks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArtworks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewArtworks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewArtworks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewArtworks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArtworks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewArtworks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtworks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEx,
            this.TitleArtworks,
            this.StyleArtworks,
            this.YearArtworks,
            this.ArtworksType,
            this.DrawnArtworks,
            this.MaterialArtworks,
            this.WeightArtworks,
            this.HeightArtworks});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArtworks.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewArtworks.EnableHeadersVisualStyles = false;
            this.dataGridViewArtworks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewArtworks.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewArtworks.Name = "dataGridViewArtworks";
            this.dataGridViewArtworks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArtworks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewArtworks.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewArtworks.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewArtworks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArtworks.Size = new System.Drawing.Size(542, 118);
            this.dataGridViewArtworks.TabIndex = 3;
            // 
            // IDEx
            // 
            this.IDEx.HeaderText = "ID";
            this.IDEx.Name = "IDEx";
            // 
            // TitleArtworks
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.TitleArtworks.DefaultCellStyle = dataGridViewCellStyle7;
            this.TitleArtworks.HeaderText = "Title";
            this.TitleArtworks.Name = "TitleArtworks";
            // 
            // StyleArtworks
            // 
            this.StyleArtworks.HeaderText = "Style";
            this.StyleArtworks.Name = "StyleArtworks";
            // 
            // YearArtworks
            // 
            this.YearArtworks.HeaderText = "Year";
            this.YearArtworks.Name = "YearArtworks";
            // 
            // ArtworksType
            // 
            this.ArtworksType.HeaderText = "Type";
            this.ArtworksType.Name = "ArtworksType";
            // 
            // DrawnArtworks
            // 
            this.DrawnArtworks.HeaderText = "Drawn On";
            this.DrawnArtworks.Name = "DrawnArtworks";
            // 
            // MaterialArtworks
            // 
            this.MaterialArtworks.HeaderText = "Material";
            this.MaterialArtworks.Name = "MaterialArtworks";
            // 
            // WeightArtworks
            // 
            this.WeightArtworks.HeaderText = "Weight";
            this.WeightArtworks.Name = "WeightArtworks";
            // 
            // HeightArtworks
            // 
            this.HeightArtworks.HeaderText = "Height";
            this.HeightArtworks.Name = "HeightArtworks";
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.Controls.Add(this.dataGridViewCustomers);
            this.groupBoxCustomers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxCustomers.Location = new System.Drawing.Point(20, 236);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Size = new System.Drawing.Size(555, 123);
            this.groupBoxCustomers.TabIndex = 26;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "View Customers";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clmName,
            this.LastName,
            this.Email,
            this.Address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCustomers.EnableHeadersVisualStyles = false;
            this.dataGridViewCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewCustomers.Location = new System.Drawing.Point(7, 21);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCustomers.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewCustomers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(542, 96);
            this.dataGridViewCustomers.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // clmName
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.clmName.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // btnRent
            // 
            this.btnRent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRent.Location = new System.Drawing.Point(464, 376);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(111, 26);
            this.btnRent.TabIndex = 24;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // RentArtwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 461);
            this.Controls.Add(this.groupBoxRent);
            this.Name = "RentArtwork";
            this.Text = "EditCustomer";
            this.groupBoxRent.ResumeLayout(false);
            this.groupBoxRent.PerformLayout();
            this.groupBoxArtworks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtworks)).EndInit();
            this.groupBoxCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.GroupBox groupBoxRent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.GroupBox groupBoxArtworks;
        private System.Windows.Forms.DataGridView dataGridViewArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn StyleArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtworksType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrawnArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightArtworks;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Button btnRent;
    }
}
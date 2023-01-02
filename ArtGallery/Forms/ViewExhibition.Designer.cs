
namespace ArtGallery.Forms
{
    partial class ViewExhibition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteExhibition = new System.Windows.Forms.Button();
            this.dataGridViewExhibitions = new System.Windows.Forms.DataGridView();
            this.IDEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallExhibition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDateExhibition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDateExhibition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateExhibition = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewArtworks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StyleArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtworksType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrawnArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightArtworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExhibitions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtworks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteExhibition
            // 
            this.btnDeleteExhibition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteExhibition.Location = new System.Drawing.Point(483, 228);
            this.btnDeleteExhibition.Name = "btnDeleteExhibition";
            this.btnDeleteExhibition.Size = new System.Drawing.Size(126, 25);
            this.btnDeleteExhibition.TabIndex = 1;
            this.btnDeleteExhibition.Text = "Delete Exhibition";
            this.btnDeleteExhibition.UseVisualStyleBackColor = true;
            this.btnDeleteExhibition.Click += new System.EventHandler(this.btnDeleteExhibition_Click);
            // 
            // dataGridViewExhibitions
            // 
            this.dataGridViewExhibitions.AllowUserToAddRows = false;
            this.dataGridViewExhibitions.AllowUserToDeleteRows = false;
            this.dataGridViewExhibitions.AllowUserToResizeColumns = false;
            this.dataGridViewExhibitions.AllowUserToResizeRows = false;
            this.dataGridViewExhibitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExhibitions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewExhibitions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewExhibitions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewExhibitions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExhibitions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewExhibitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExhibitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEx,
            this.HallExhibition,
            this.SDateExhibition,
            this.EDateExhibition});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExhibitions.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewExhibitions.EnableHeadersVisualStyles = false;
            this.dataGridViewExhibitions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewExhibitions.Location = new System.Drawing.Point(31, 29);
            this.dataGridViewExhibitions.Name = "dataGridViewExhibitions";
            this.dataGridViewExhibitions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExhibitions.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewExhibitions.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewExhibitions.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewExhibitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExhibitions.Size = new System.Drawing.Size(544, 185);
            this.dataGridViewExhibitions.TabIndex = 2;
            // 
            // IDEx
            // 
            this.IDEx.HeaderText = "ID";
            this.IDEx.Name = "IDEx";
            // 
            // HallExhibition
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.HallExhibition.DefaultCellStyle = dataGridViewCellStyle7;
            this.HallExhibition.HeaderText = "Hall";
            this.HallExhibition.Name = "HallExhibition";
            // 
            // SDateExhibition
            // 
            this.SDateExhibition.HeaderText = "Start Date";
            this.SDateExhibition.Name = "SDateExhibition";
            // 
            // EDateExhibition
            // 
            this.EDateExhibition.HeaderText = "End Date";
            this.EDateExhibition.Name = "EDateExhibition";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateExhibition);
            this.groupBox1.Controls.Add(this.dataGridViewExhibitions);
            this.groupBox1.Controls.Add(this.btnDeleteExhibition);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(25, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Exhibitions";
            // 
            // btnUpdateExhibition
            // 
            this.btnUpdateExhibition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateExhibition.Location = new System.Drawing.Point(333, 228);
            this.btnUpdateExhibition.Name = "btnUpdateExhibition";
            this.btnUpdateExhibition.Size = new System.Drawing.Size(126, 25);
            this.btnUpdateExhibition.TabIndex = 4;
            this.btnUpdateExhibition.Text = "View Artworks";
            this.btnUpdateExhibition.UseVisualStyleBackColor = true;
            this.btnUpdateExhibition.Click += new System.EventHandler(this.btnUpdateExhibition_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewArtworks);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(25, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 196);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Artworks";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(513, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update Exhibition";
            this.button1.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArtworks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewArtworks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtworks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TitleArtworks,
            this.StyleArtworks,
            this.YearArtworks,
            this.ArtworksType,
            this.DrawnArtworks,
            this.MaterialArtworks,
            this.WeightArtworks,
            this.HeightArtworks});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArtworks.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewArtworks.EnableHeadersVisualStyles = false;
            this.dataGridViewArtworks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewArtworks.Location = new System.Drawing.Point(31, 36);
            this.dataGridViewArtworks.Name = "dataGridViewArtworks";
            this.dataGridViewArtworks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArtworks.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewArtworks.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewArtworks.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewArtworks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArtworks.Size = new System.Drawing.Size(544, 118);
            this.dataGridViewArtworks.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // TitleArtworks
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.TitleArtworks.DefaultCellStyle = dataGridViewCellStyle12;
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
            // ViewExhibition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewExhibition";
            this.Text = "ViewExhibition";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExhibitions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtworks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteExhibition;
        private System.Windows.Forms.DataGridView dataGridViewExhibitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallExhibition;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDateExhibition;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDateExhibition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateExhibition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn StyleArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtworksType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrawnArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightArtworks;
    }
}
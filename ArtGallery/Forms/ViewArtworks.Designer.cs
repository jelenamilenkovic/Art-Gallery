
namespace ArtGallery.Forms
{
    partial class ViewArtworks
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
            this.groupBoxArtworks = new System.Windows.Forms.GroupBox();
            this.btnAllOfArtworks = new System.Windows.Forms.Button();
            this.btnPainting = new System.Windows.Forms.Button();
            this.btnSculpture = new System.Windows.Forms.Button();
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
            this.groupBoxArtworks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtworks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxArtworks
            // 
            this.groupBoxArtworks.Controls.Add(this.btnAllOfArtworks);
            this.groupBoxArtworks.Controls.Add(this.btnPainting);
            this.groupBoxArtworks.Controls.Add(this.btnSculpture);
            this.groupBoxArtworks.Controls.Add(this.dataGridViewArtworks);
            this.groupBoxArtworks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxArtworks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxArtworks.Location = new System.Drawing.Point(25, 21);
            this.groupBoxArtworks.Name = "groupBoxArtworks";
            this.groupBoxArtworks.Size = new System.Drawing.Size(616, 287);
            this.groupBoxArtworks.TabIndex = 0;
            this.groupBoxArtworks.TabStop = false;
            this.groupBoxArtworks.Text = "View Artworks";
            // 
            // btnAllOfArtworks
            // 
            this.btnAllOfArtworks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllOfArtworks.Location = new System.Drawing.Point(410, 19);
            this.btnAllOfArtworks.Name = "btnAllOfArtworks";
            this.btnAllOfArtworks.Size = new System.Drawing.Size(73, 25);
            this.btnAllOfArtworks.TabIndex = 6;
            this.btnAllOfArtworks.Text = "Artworks";
            this.btnAllOfArtworks.UseVisualStyleBackColor = true;
            this.btnAllOfArtworks.Click += new System.EventHandler(this.btnAllOfArtworks_Click);
            // 
            // btnPainting
            // 
            this.btnPainting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPainting.Location = new System.Drawing.Point(269, 19);
            this.btnPainting.Name = "btnPainting";
            this.btnPainting.Size = new System.Drawing.Size(73, 25);
            this.btnPainting.TabIndex = 5;
            this.btnPainting.Text = "Painting";
            this.btnPainting.UseVisualStyleBackColor = true;
            this.btnPainting.Click += new System.EventHandler(this.btnPainting_Click);
            // 
            // btnSculpture
            // 
            this.btnSculpture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSculpture.Location = new System.Drawing.Point(118, 19);
            this.btnSculpture.Name = "btnSculpture";
            this.btnSculpture.Size = new System.Drawing.Size(73, 25);
            this.btnSculpture.TabIndex = 4;
            this.btnSculpture.Text = "Sculpture";
            this.btnSculpture.UseVisualStyleBackColor = true;
            this.btnSculpture.Click += new System.EventHandler(this.btnSculpture_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArtworks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArtworks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewArtworks.EnableHeadersVisualStyles = false;
            this.dataGridViewArtworks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewArtworks.Location = new System.Drawing.Point(38, 78);
            this.dataGridViewArtworks.Name = "dataGridViewArtworks";
            this.dataGridViewArtworks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArtworks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewArtworks.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewArtworks.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewArtworks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArtworks.Size = new System.Drawing.Size(551, 185);
            this.dataGridViewArtworks.TabIndex = 3;
            // 
            // IDEx
            // 
            this.IDEx.HeaderText = "ID";
            this.IDEx.Name = "IDEx";
            // 
            // TitleArtworks
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.TitleArtworks.DefaultCellStyle = dataGridViewCellStyle2;
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
            // ViewArtworks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 461);
            this.Controls.Add(this.groupBoxArtworks);
            this.Name = "ViewArtworks";
            this.Text = "ViewArtworks";
            this.groupBoxArtworks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtworks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxArtworks;
        private System.Windows.Forms.Button btnAllOfArtworks;
        private System.Windows.Forms.Button btnPainting;
        private System.Windows.Forms.Button btnSculpture;
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
    }
}
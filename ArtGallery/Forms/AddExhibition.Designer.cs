
namespace ArtGallery.Forms
{
    partial class AddExhibition
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
            this.groupBoxExhibition = new System.Windows.Forms.GroupBox();
            this.comboBoxHall = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarEndDate = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
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
            this.btnAddExhibition = new System.Windows.Forms.Button();
            this.groupBoxExhibition.SuspendLayout();
            this.groupBoxArtworks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtworks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxExhibition
            // 
            this.groupBoxExhibition.Controls.Add(this.btnAddExhibition);
            this.groupBoxExhibition.Controls.Add(this.btnYes);
            this.groupBoxExhibition.Controls.Add(this.label4);
            this.groupBoxExhibition.Controls.Add(this.label3);
            this.groupBoxExhibition.Controls.Add(this.comboBoxHall);
            this.groupBoxExhibition.Controls.Add(this.label1);
            this.groupBoxExhibition.Controls.Add(this.monthCalendarStartDate);
            this.groupBoxExhibition.Controls.Add(this.monthCalendarEndDate);
            this.groupBoxExhibition.Controls.Add(this.label5);
            this.groupBoxExhibition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExhibition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxExhibition.Location = new System.Drawing.Point(23, 12);
            this.groupBoxExhibition.Name = "groupBoxExhibition";
            this.groupBoxExhibition.Size = new System.Drawing.Size(600, 323);
            this.groupBoxExhibition.TabIndex = 3;
            this.groupBoxExhibition.TabStop = false;
            this.groupBoxExhibition.Text = "Add exhibition";
            // 
            // comboBoxHall
            // 
            this.comboBoxHall.FormattingEnabled = true;
            this.comboBoxHall.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxHall.Location = new System.Drawing.Point(85, 228);
            this.comboBoxHall.Name = "comboBoxHall";
            this.comboBoxHall.Size = new System.Drawing.Size(75, 21);
            this.comboBoxHall.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Start Date";
            // 
            // monthCalendarStartDate
            // 
            this.monthCalendarStartDate.Location = new System.Drawing.Point(47, 38);
            this.monthCalendarStartDate.Name = "monthCalendarStartDate";
            this.monthCalendarStartDate.TabIndex = 16;
            // 
            // monthCalendarEndDate
            // 
            this.monthCalendarEndDate.Location = new System.Drawing.Point(318, 38);
            this.monthCalendarEndDate.Name = "monthCalendarEndDate";
            this.monthCalendarEndDate.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hall";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hall";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Do you want to add artworks?";
            // 
            // btnYes
            // 
            this.btnYes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYes.Location = new System.Drawing.Point(499, 232);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(71, 21);
            this.btnYes.TabIndex = 21;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // groupBoxArtworks
            // 
            this.groupBoxArtworks.Controls.Add(this.dataGridViewArtworks);
            this.groupBoxArtworks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxArtworks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxArtworks.Location = new System.Drawing.Point(23, 355);
            this.groupBoxArtworks.Name = "groupBoxArtworks";
            this.groupBoxArtworks.Size = new System.Drawing.Size(600, 194);
            this.groupBoxArtworks.TabIndex = 4;
            this.groupBoxArtworks.TabStop = false;
            this.groupBoxArtworks.Text = "View Artworks";
            this.groupBoxArtworks.Visible = false;
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
            this.dataGridViewArtworks.Location = new System.Drawing.Point(19, 19);
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
            this.dataGridViewArtworks.Size = new System.Drawing.Size(551, 131);
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
            // btnAddExhibition
            // 
            this.btnAddExhibition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddExhibition.Location = new System.Drawing.Point(470, 280);
            this.btnAddExhibition.Name = "btnAddExhibition";
            this.btnAddExhibition.Size = new System.Drawing.Size(110, 27);
            this.btnAddExhibition.TabIndex = 5;
            this.btnAddExhibition.Text = "Add";
            this.btnAddExhibition.UseVisualStyleBackColor = true;
            this.btnAddExhibition.Click += new System.EventHandler(this.btnAddExhibition_Click);
            // 
            // AddExhibition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 561);
            this.Controls.Add(this.groupBoxArtworks);
            this.Controls.Add(this.groupBoxExhibition);
            this.Controls.Add(this.label2);
            this.Name = "AddExhibition";
            this.Text = "AddExhibition";
            this.groupBoxExhibition.ResumeLayout(false);
            this.groupBoxExhibition.PerformLayout();
            this.groupBoxArtworks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtworks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxExhibition;
        private System.Windows.Forms.MonthCalendar monthCalendarEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendarStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddExhibition;
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
    }
}
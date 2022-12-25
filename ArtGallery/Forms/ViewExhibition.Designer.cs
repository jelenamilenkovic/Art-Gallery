
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteExhibition = new System.Windows.Forms.Button();
            this.dataGridViewExhibitions = new System.Windows.Forms.DataGridView();
            this.IDEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallExhibition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDateExhibition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDateExhibition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExhibitions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteExhibition
            // 
            this.btnDeleteExhibition.Location = new System.Drawing.Point(503, 316);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExhibitions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExhibitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExhibitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEx,
            this.HallExhibition,
            this.SDateExhibition,
            this.EDateExhibition});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExhibitions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewExhibitions.EnableHeadersVisualStyles = false;
            this.dataGridViewExhibitions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewExhibitions.Location = new System.Drawing.Point(54, 39);
            this.dataGridViewExhibitions.Name = "dataGridViewExhibitions";
            this.dataGridViewExhibitions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExhibitions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewExhibitions.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewExhibitions.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.HallExhibition.DefaultCellStyle = dataGridViewCellStyle2;
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
            // ViewExhibition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.dataGridViewExhibitions);
            this.Controls.Add(this.btnDeleteExhibition);
            this.Name = "ViewExhibition";
            this.Text = "ViewExhibition";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExhibitions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteExhibition;
        private System.Windows.Forms.DataGridView dataGridViewExhibitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallExhibition;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDateExhibition;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDateExhibition;
    }
}
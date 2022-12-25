
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
            this.btnAddArtistDB = new System.Windows.Forms.Button();
            this.groupBoxExhibition = new System.Windows.Forms.GroupBox();
            this.comboBoxHall = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarEndDate = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxExhibition.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddArtistDB
            // 
            this.btnAddArtistDB.Location = new System.Drawing.Point(513, 310);
            this.btnAddArtistDB.Name = "btnAddArtistDB";
            this.btnAddArtistDB.Size = new System.Drawing.Size(110, 27);
            this.btnAddArtistDB.TabIndex = 4;
            this.btnAddArtistDB.Text = "Add";
            this.btnAddArtistDB.UseVisualStyleBackColor = true;
            this.btnAddArtistDB.Click += new System.EventHandler(this.btnAddArtistDB_Click);
            // 
            // groupBoxExhibition
            // 
            this.groupBoxExhibition.Controls.Add(this.comboBoxHall);
            this.groupBoxExhibition.Controls.Add(this.label1);
            this.groupBoxExhibition.Controls.Add(this.monthCalendarStartDate);
            this.groupBoxExhibition.Controls.Add(this.monthCalendarEndDate);
            this.groupBoxExhibition.Controls.Add(this.label5);
            this.groupBoxExhibition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExhibition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxExhibition.Location = new System.Drawing.Point(23, 12);
            this.groupBoxExhibition.Name = "groupBoxExhibition";
            this.groupBoxExhibition.Size = new System.Drawing.Size(600, 292);
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
            this.comboBoxHall.Location = new System.Drawing.Point(470, 229);
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
            // AddExhibition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.btnAddArtistDB);
            this.Controls.Add(this.groupBoxExhibition);
            this.Controls.Add(this.label2);
            this.Name = "AddExhibition";
            this.Text = "AddExhibition";
            this.groupBoxExhibition.ResumeLayout(false);
            this.groupBoxExhibition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddArtistDB;
        private System.Windows.Forms.GroupBox groupBoxExhibition;
        private System.Windows.Forms.MonthCalendar monthCalendarEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendarStartDate;
    }
}
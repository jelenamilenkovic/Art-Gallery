
namespace ArtGallery.Forms
{
    partial class AddArtwork
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
            this.groupBoxArtwork = new System.Windows.Forms.GroupBox();
            this.numericUpH = new System.Windows.Forms.NumericUpDown();
            this.numericUpW = new System.Windows.Forms.NumericUpDown();
            this.numericUpPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpYear = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewArtists = new System.Windows.Forms.DataGridView();
            this.ArtistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnNN = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxAddNewArtist = new System.Windows.Forms.GroupBox();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.txtArtistLName = new System.Windows.Forms.TextBox();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxartwork = new System.Windows.Forms.TextBox();
            this.artworklabel = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxStyle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.btnAddArtwork = new System.Windows.Forms.Button();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPainting = new System.Windows.Forms.Button();
            this.btnSculpture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxArtwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).BeginInit();
            this.groupBoxAddNewArtist.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxArtwork
            // 
            this.groupBoxArtwork.Controls.Add(this.numericUpH);
            this.groupBoxArtwork.Controls.Add(this.numericUpW);
            this.groupBoxArtwork.Controls.Add(this.numericUpPrice);
            this.groupBoxArtwork.Controls.Add(this.numericUpYear);
            this.groupBoxArtwork.Controls.Add(this.btnDB);
            this.groupBoxArtwork.Controls.Add(this.btnAddNew);
            this.groupBoxArtwork.Controls.Add(this.btnNN);
            this.groupBoxArtwork.Controls.Add(this.label11);
            this.groupBoxArtwork.Controls.Add(this.groupBoxAddNewArtist);
            this.groupBoxArtwork.Controls.Add(this.label3);
            this.groupBoxArtwork.Controls.Add(this.txtBoxartwork);
            this.groupBoxArtwork.Controls.Add(this.artworklabel);
            this.groupBoxArtwork.Controls.Add(this.labelWeight);
            this.groupBoxArtwork.Controls.Add(this.label10);
            this.groupBoxArtwork.Controls.Add(this.txtBoxStyle);
            this.groupBoxArtwork.Controls.Add(this.label9);
            this.groupBoxArtwork.Controls.Add(this.labelHeight);
            this.groupBoxArtwork.Controls.Add(this.btnAddArtwork);
            this.groupBoxArtwork.Controls.Add(this.txtBoxTitle);
            this.groupBoxArtwork.Controls.Add(this.label2);
            this.groupBoxArtwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxArtwork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxArtwork.Location = new System.Drawing.Point(52, 36);
            this.groupBoxArtwork.Name = "groupBoxArtwork";
            this.groupBoxArtwork.Size = new System.Drawing.Size(580, 405);
            this.groupBoxArtwork.TabIndex = 2;
            this.groupBoxArtwork.TabStop = false;
            this.groupBoxArtwork.Text = "Add artwork";
            // 
            // numericUpH
            // 
            this.numericUpH.DecimalPlaces = 2;
            this.numericUpH.Location = new System.Drawing.Point(67, 117);
            this.numericUpH.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpH.Name = "numericUpH";
            this.numericUpH.Size = new System.Drawing.Size(116, 20);
            this.numericUpH.TabIndex = 39;
            // 
            // numericUpW
            // 
            this.numericUpW.DecimalPlaces = 2;
            this.numericUpW.Location = new System.Drawing.Point(67, 72);
            this.numericUpW.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpW.Name = "numericUpW";
            this.numericUpW.Size = new System.Drawing.Size(116, 20);
            this.numericUpW.TabIndex = 38;
            // 
            // numericUpPrice
            // 
            this.numericUpPrice.Location = new System.Drawing.Point(445, 70);
            this.numericUpPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpPrice.Name = "numericUpPrice";
            this.numericUpPrice.Size = new System.Drawing.Size(116, 20);
            this.numericUpPrice.TabIndex = 37;
            // 
            // numericUpYear
            // 
            this.numericUpYear.Location = new System.Drawing.Point(445, 22);
            this.numericUpYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpYear.Name = "numericUpYear";
            this.numericUpYear.Size = new System.Drawing.Size(116, 20);
            this.numericUpYear.TabIndex = 36;
            // 
            // dataGridViewArtists
            // 
            this.dataGridViewArtists.AllowUserToAddRows = false;
            this.dataGridViewArtists.AllowUserToResizeColumns = false;
            this.dataGridViewArtists.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewArtists.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewArtists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArtists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewArtists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewArtists.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewArtists.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArtists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtistID,
            this.ArtistName,
            this.ArtistLastName,
            this.ArtistCity,
            this.ArtistCountry,
            this.ArtistBD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArtists.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewArtists.EnableHeadersVisualStyles = false;
            this.dataGridViewArtists.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewArtists.Location = new System.Drawing.Point(-30, 0);
            this.dataGridViewArtists.Name = "dataGridViewArtists";
            this.dataGridViewArtists.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewArtists.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewArtists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArtists.Size = new System.Drawing.Size(568, 150);
            this.dataGridViewArtists.TabIndex = 35;
            this.dataGridViewArtists.Visible = false;
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
            // btnDB
            // 
            this.btnDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDB.Location = new System.Drawing.Point(187, 150);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(104, 20);
            this.btnDB.TabIndex = 34;
            this.btnDB.Text = "From database";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNew.Location = new System.Drawing.Point(310, 150);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(104, 20);
            this.btnAddNew.TabIndex = 33;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnNN
            // 
            this.btnNN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNN.Location = new System.Drawing.Point(67, 150);
            this.btnNN.Name = "btnNN";
            this.btnNN.Size = new System.Drawing.Size(104, 20);
            this.btnNN.TabIndex = 32;
            this.btnNN.Text = "No name";
            this.btnNN.UseVisualStyleBackColor = true;
            this.btnNN.Click += new System.EventHandler(this.btnNN_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Artist";
            // 
            // groupBoxAddNewArtist
            // 
            this.groupBoxAddNewArtist.Controls.Add(this.dateTP);
            this.groupBoxAddNewArtist.Controls.Add(this.txtCountry);
            this.groupBoxAddNewArtist.Controls.Add(this.txtCity);
            this.groupBoxAddNewArtist.Controls.Add(this.Country);
            this.groupBoxAddNewArtist.Controls.Add(this.dataGridViewArtists);
            this.groupBoxAddNewArtist.Controls.Add(this.City);
            this.groupBoxAddNewArtist.Controls.Add(this.txtArtistLName);
            this.groupBoxAddNewArtist.Controls.Add(this.txtArtistName);
            this.groupBoxAddNewArtist.Controls.Add(this.label5);
            this.groupBoxAddNewArtist.Controls.Add(this.label7);
            this.groupBoxAddNewArtist.Controls.Add(this.label8);
            this.groupBoxAddNewArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddNewArtist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxAddNewArtist.Location = new System.Drawing.Point(36, 201);
            this.groupBoxAddNewArtist.Name = "groupBoxAddNewArtist";
            this.groupBoxAddNewArtist.Size = new System.Drawing.Size(508, 103);
            this.groupBoxAddNewArtist.TabIndex = 30;
            this.groupBoxAddNewArtist.TabStop = false;
            this.groupBoxAddNewArtist.Text = "Add artist";
            this.groupBoxAddNewArtist.Visible = false;
            // 
            // dateTP
            // 
            this.dateTP.Location = new System.Drawing.Point(105, 73);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(224, 20);
            this.dateTP.TabIndex = 15;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(376, 47);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(114, 20);
            this.txtCountry.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(376, 19);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(114, 20);
            this.txtCity.TabIndex = 13;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(292, 50);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(50, 13);
            this.Country.TabIndex = 12;
            this.Country.Text = "Country";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(292, 22);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(28, 13);
            this.City.TabIndex = 11;
            this.City.Text = "City";
            // 
            // txtArtistLName
            // 
            this.txtArtistLName.Location = new System.Drawing.Point(105, 47);
            this.txtArtistLName.Name = "txtArtistLName";
            this.txtArtistLName.Size = new System.Drawing.Size(114, 20);
            this.txtArtistLName.TabIndex = 9;
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(105, 20);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(114, 20);
            this.txtArtistName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "BirthDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Price";
            // 
            // txtBoxartwork
            // 
            this.txtBoxartwork.Location = new System.Drawing.Point(258, 69);
            this.txtBoxartwork.Name = "txtBoxartwork";
            this.txtBoxartwork.Size = new System.Drawing.Size(114, 20);
            this.txtBoxartwork.TabIndex = 27;
            // 
            // artworklabel
            // 
            this.artworklabel.AutoSize = true;
            this.artworklabel.Location = new System.Drawing.Point(205, 72);
            this.artworklabel.Name = "artworklabel";
            this.artworklabel.Size = new System.Drawing.Size(31, 13);
            this.artworklabel.TabIndex = 26;
            this.artworklabel.Text = "XXX";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(14, 73);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(47, 13);
            this.labelWeight.TabIndex = 24;
            this.labelWeight.Text = "Weight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Year";
            // 
            // txtBoxStyle
            // 
            this.txtBoxStyle.Location = new System.Drawing.Point(258, 22);
            this.txtBoxStyle.Name = "txtBoxStyle";
            this.txtBoxStyle.Size = new System.Drawing.Size(114, 20);
            this.txtBoxStyle.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Style";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(14, 119);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(44, 13);
            this.labelHeight.TabIndex = 19;
            this.labelHeight.Text = "Height";
            // 
            // btnAddArtwork
            // 
            this.btnAddArtwork.Enabled = false;
            this.btnAddArtwork.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArtwork.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddArtwork.Location = new System.Drawing.Point(448, 357);
            this.btnAddArtwork.Name = "btnAddArtwork";
            this.btnAddArtwork.Size = new System.Drawing.Size(113, 30);
            this.btnAddArtwork.TabIndex = 6;
            this.btnAddArtwork.Text = "Add artwork";
            this.btnAddArtwork.UseVisualStyleBackColor = true;
            this.btnAddArtwork.Click += new System.EventHandler(this.btnAddArtwork_Click);
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(67, 23);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(114, 20);
            this.txtBoxTitle.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // btnPainting
            // 
            this.btnPainting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnPainting.FlatAppearance.BorderSize = 0;
            this.btnPainting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnPainting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnPainting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainting.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainting.ForeColor = System.Drawing.Color.Yellow;
            this.btnPainting.Location = new System.Drawing.Point(300, 2);
            this.btnPainting.Margin = new System.Windows.Forms.Padding(0);
            this.btnPainting.Name = "btnPainting";
            this.btnPainting.Size = new System.Drawing.Size(73, 31);
            this.btnPainting.TabIndex = 3;
            this.btnPainting.Text = "painting";
            this.btnPainting.UseVisualStyleBackColor = false;
            this.btnPainting.Click += new System.EventHandler(this.btnPainting_Click);
            // 
            // btnSculpture
            // 
            this.btnSculpture.FlatAppearance.BorderSize = 0;
            this.btnSculpture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnSculpture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnSculpture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSculpture.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSculpture.ForeColor = System.Drawing.Color.Yellow;
            this.btnSculpture.Location = new System.Drawing.Point(373, 5);
            this.btnSculpture.Margin = new System.Windows.Forms.Padding(0);
            this.btnSculpture.Name = "btnSculpture";
            this.btnSculpture.Size = new System.Drawing.Size(82, 25);
            this.btnSculpture.TabIndex = 4;
            this.btnSculpture.Text = "sculpture";
            this.btnSculpture.UseVisualStyleBackColor = true;
            this.btnSculpture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSculpture_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Do you want to add";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(365, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "or";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(452, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "?";
            // 
            // AddArtwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(674, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSculpture);
            this.Controls.Add(this.btnPainting);
            this.Controls.Add(this.groupBoxArtwork);
            this.Name = "AddArtwork";
            this.Text = "AddArtwork";
            this.groupBoxArtwork.ResumeLayout(false);
            this.groupBoxArtwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).EndInit();
            this.groupBoxAddNewArtist.ResumeLayout(false);
            this.groupBoxAddNewArtist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxArtwork;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Button btnAddArtwork;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPainting;
        private System.Windows.Forms.Button btnSculpture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxartwork;
        private System.Windows.Forms.Label artworklabel;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxStyle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxAddNewArtist;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox txtArtistLName;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnNN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewArtists;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistBD;
        private System.Windows.Forms.NumericUpDown numericUpYear;
        private System.Windows.Forms.NumericUpDown numericUpH;
        private System.Windows.Forms.NumericUpDown numericUpW;
        private System.Windows.Forms.NumericUpDown numericUpPrice;
    }
}
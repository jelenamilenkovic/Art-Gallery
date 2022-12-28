using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery.Forms
{
    public partial class AddArtwork : Form
    {
        ArtworkBasic artwork;
        public int flag = 0;
        public bool type = true;
        public AddArtwork()
        {
            InitializeComponent();
            artwork = new ArtworkBasic();
            groupBoxArtwork.Visible = false;
        }

        private void btnPainting_Click(object sender, EventArgs e)
        {
            type = true;
            artworklabel.Text = "Drawn on";
            labelHeight.Visible = false;
            labelWeight.Visible = false;
            numericUpW.Visible = false;
            numericUpH.Visible = false;
            groupBoxArtwork.Visible = true;
        }

        private void btnSculpture_MouseClick(object sender, MouseEventArgs e)
        {
            type = false;
            artworklabel.Text = "Material";
            labelHeight.Visible = true;
            labelWeight.Visible = true;
            numericUpH.Visible = true;
            numericUpW.Visible = true;
            groupBoxArtwork.Visible = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.flag = 3;
            dataGridViewArtists.Visible = false;
            groupBoxAddNewArtist.Visible = true;
            btnAddArtwork.Enabled = true;
        }

        private void btnNN_Click(object sender, EventArgs e)
        {
            this.flag = 1;
            dataGridViewArtists.Visible = false;
            groupBoxAddNewArtist.Visible = false;
            btnAddArtwork.Enabled = true;
        }

        private void btnDB_Click(object sender, EventArgs e)
        {

            this.flag = 2;
            groupBoxAddNewArtist.Visible = false;
            dataGridViewArtists.Visible = true;
            btnAddArtwork.Enabled = true;


            this.dataGridViewArtists.Rows.Clear();
            List<ArtistPregled> podaci = DTOManager.getArtists();
            foreach (ArtistPregled p in podaci)
            {
                this.dataGridViewArtists.Rows.Add(new string[] { p.Artist_ID.ToString(), p.Name, p.Last_Name, p.City, p.BirthDate, p.Country });

            }
            dataGridViewArtists.Refresh();
        }

        private void btnAddArtwork_Click(object sender, EventArgs e)
        {



            this.artwork.Year = (int)numericUpYear.Value;
            this.artwork.Price = (int)numericUpPrice.Value;
            this.artwork.Style = txtBoxStyle.Text;
            this.artwork.Title = txtBoxTitle.Text;
            this.artwork.Type = type == true ? "painting" : "sculpture";

            if (type)
            {
                this.artwork.Drawn_on = txtBoxartwork.Text;
            }
            else
            {
                this.artwork.Height = (double)numericUpH.Value;
                this.artwork.Material = txtBoxartwork.Text;
                this.artwork.Weight = (double)numericUpW.Value;
            }

            
            switch (flag) { 
                case 1:
                    DTOManager.addArtwork(this.artwork,type);
                    MessageBox.Show("Uspesno ste dodali novi artwork!");
                    this.Close();
                    break;
                case 2:
                    this.artwork.Artist = DTOManager.getArtist(Int32.Parse(dataGridViewArtists.SelectedRows[0].Cells[0].Value.ToString()));
                    DTOManager.SaveArtworkForArtist(this.artwork,type);
                    MessageBox.Show("Uspesno ste dodali novi artwork!");
                    this.Close();
                    break;
                case 3:
                    ArtistBasic artist= new ArtistBasic();
                    artist.Name = txtArtistName.Text;
                    artist.Last_Name = txtArtistLName.Text;
                    artist.City = txtCity.Text;
                    artist.Country = txtCountry.Text;
                    artist.BirthDate = dateTP.Value.ToString("dd.MM.yyyy");

                    DTOManager.SaveArtworkandArtist(this.artwork, artist,type);
                    break;
            
            
            
            }
        }

        
    }
}

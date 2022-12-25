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
    public partial class AddArtist : Form
    {
        public ArtistBasic artist;
        public AddArtist()
        {
            artist = new ArtistBasic();
            InitializeComponent();
        }

        private void btnAddArtistDB_Click(object sender, EventArgs e)
        {
            this.artist.Name = txtArtistName.Text;
            this.artist.Last_Name = txtArtistLName.Text;
            this.artist.City = txtCity.Text;
            this.artist.Country = txtCountry.Text;
            this.artist.BirthDate = dateTP.Value.ToString("dd.MM.yyyy");

            DTOManager.addArtist(this.artist);
            MessageBox.Show("Uspesno ste dodali novog artista!");
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

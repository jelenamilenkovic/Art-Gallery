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
    public partial class ViewArtworks : Form
    {
        public ViewArtworks()
        {
            InitializeComponent();
            this.dataGridViewArtworks.Columns["MaterialArtworks"].Visible = true;
            this.dataGridViewArtworks.Columns["HeightArtworks"].Visible = true;
            this.dataGridViewArtworks.Columns["WeightArtworks"].Visible = true;
            this.dataGridViewArtworks.Columns["ArtworksType"].Visible = true;


            this.dataGridViewArtworks.Columns["DrawnArtworks"].Visible = true;
            WriteData();
        }

        public void WriteData()
        {
            this.dataGridViewArtworks.Rows.Clear();
            List<ArtworkPregled> podaci = DTOManager.getArtworks();



            foreach (ArtworkPregled p in podaci)
            {
                this.dataGridViewArtworks.Rows.Add(new string[] { p.Artwork_ID.ToString(), p.Title, p.Style, p.Year.ToString(), p.Type, p.Drawn_on, p.Material, p.Weight.ToString(), p.Height.ToString() });

            }

            dataGridViewArtworks.Refresh();
        }

        private void btnAllOfArtworks_Click(object sender, EventArgs e)
        {

            this.dataGridViewArtworks.Columns["MaterialArtworks"].Visible = true;
            this.dataGridViewArtworks.Columns["HeightArtworks"].Visible = true;
            this.dataGridViewArtworks.Columns["WeightArtworks"].Visible = true;
            this.dataGridViewArtworks.Columns["ArtworksType"].Visible = true;


            this.dataGridViewArtworks.Columns["DrawnArtworks"].Visible = true;

            WriteData();
        }

        private void btnPainting_Click(object sender, EventArgs e)
        {
            this.dataGridViewArtworks.Columns["MaterialArtworks"].Visible = false;
            this.dataGridViewArtworks.Columns["HeightArtworks"].Visible = false;
            this.dataGridViewArtworks.Columns["WeightArtworks"].Visible = false;
            this.dataGridViewArtworks.Columns["ArtworksType"].Visible = false;


            this.dataGridViewArtworks.Columns["DrawnArtworks"].Visible = true;

            this.dataGridViewArtworks.Rows.Clear();
            List<ArtworkPregled> podaci = DTOManager.getPaintings();



            foreach (ArtworkPregled p in podaci)
            {
                this.dataGridViewArtworks.Rows.Add(new string[] { p.Artwork_ID.ToString(), p.Title, p.Style, p.Year.ToString(), p.Type, p.Drawn_on, p.Material, p.Weight.ToString(), p.Height.ToString() });

            }

            dataGridViewArtworks.Refresh();
        }

        private void btnSculpture_Click(object sender, EventArgs e)
        {
            this.dataGridViewArtworks.Columns["ArtworksType"].Visible = false;
            this.dataGridViewArtworks.Columns["DrawnArtworks"].Visible = false;

            this.dataGridViewArtworks.Columns["MaterialArtworks"].Visible = true;
            this.dataGridViewArtworks.Columns["HeightArtworks"].Visible = true;
            this.dataGridViewArtworks.Columns["WeightArtworks"].Visible = true;

            this.dataGridViewArtworks.Rows.Clear();
            List<ArtworkPregled> podaci = DTOManager.getSculptures();



            foreach (ArtworkPregled p in podaci)
            {
                this.dataGridViewArtworks.Rows.Add(new string[] { p.Artwork_ID.ToString(), p.Title, p.Style, p.Year.ToString(), p.Type, p.Drawn_on, p.Material, p.Weight.ToString(), p.Height.ToString() });

            }

            dataGridViewArtworks.Refresh();
        }
    }
}

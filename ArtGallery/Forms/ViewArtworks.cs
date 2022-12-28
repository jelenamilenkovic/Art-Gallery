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
            Visibility(3);
            WriteData(3);
        }

        public void WriteData(int n)
        {
            this.dataGridViewArtworks.Rows.Clear();
            List<ArtworkPregled> podaci = n==0 ? DTOManager.getPaintings():(n==1? DTOManager.getSculptures() : DTOManager.getArtworks());



            foreach (ArtworkPregled p in podaci)
            {
                this.dataGridViewArtworks.Rows.Add(new string[] { p.Artwork_ID.ToString(), p.Title, p.Style, p.Year.ToString(), p.Type, p.Drawn_on, p.Material, p.Weight.ToString(), p.Height.ToString() });

            }

            dataGridViewArtworks.Refresh();
        }

        private void btnAllOfArtworks_Click(object sender, EventArgs e)
        {
            Visibility(3);
            WriteData(3);
        }

        private void Visibility(int n)
        {   
            this.dataGridViewArtworks.Columns["ArtworksType"].Visible = n==3 ? true : false;

            this.dataGridViewArtworks.Columns["MaterialArtworks"].Visible = n == 0 ? false : true;
            this.dataGridViewArtworks.Columns["HeightArtworks"].Visible = n == 0 ? false : true;
            this.dataGridViewArtworks.Columns["WeightArtworks"].Visible = n == 0 ? false : true;

            this.dataGridViewArtworks.Columns["DrawnArtworks"].Visible =n==1?false:true;
        }
        private void btnPainting_Click(object sender, EventArgs e)    // 0
        {
            Visibility(0);
            WriteData(0);
        }

        private void btnSculpture_Click(object sender, EventArgs e)  // 1
        {
            Visibility(1);
            WriteData(1);
        }
    }
}

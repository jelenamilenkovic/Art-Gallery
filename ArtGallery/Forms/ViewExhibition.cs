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
    public partial class ViewExhibition : Form
    {
        public ViewExhibition()
        {
            InitializeComponent();
            WriteData();
        }

        public void WriteData()
        {

            this.dataGridViewExhibitions.Rows.Clear();
            List<ExhibitionPregled> podaci = DTOManager.getExhibitions();



            foreach (ExhibitionPregled p in podaci)
            {
                this.dataGridViewExhibitions.Rows.Add(new string[] { p.Exhibition_ID.ToString(), p.Hall.ToString(), p.Start_Date.ToString(), p.End_Date.ToString() });

            }

            dataGridViewExhibitions.Refresh();

        }

        private void btnDeleteExhibition_Click(object sender, EventArgs e)
        {
            if (dataGridViewExhibitions.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Choose artist");
                return;
            }

            int idArtist = Int32.Parse(dataGridViewExhibitions.SelectedRows[0].Cells[0].Value.ToString());
            string poruka = "Do you want to delete the artist?";
            string title = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.deleteArtist(idArtist);
                MessageBox.Show("Successfully");
                this.WriteData();
            }
            else
            {

            }
        }

        private void btnUpdateExhibition_Click(object sender, EventArgs e)
        {
            this.dataGridViewArtworks.Rows.Clear();
            List<ArtworkPregled> podaci = DTOManager.getArtworksFromExhibition(Int32.Parse(dataGridViewExhibitions.SelectedRows[0].Cells[0].Value.ToString()));



            foreach (ArtworkPregled p in podaci)
            {
                this.dataGridViewArtworks.Rows.Add(new string[] { p.Artwork_ID.ToString(), p.Title, p.Style, p.Year.ToString(), p.Type, p.Drawn_on, p.Material, p.Weight.ToString(), p.Height.ToString() });

            }

            dataGridViewArtworks.Refresh();
        }
    }
}

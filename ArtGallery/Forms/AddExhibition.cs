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
    public partial class AddExhibition : Form
    {
       public ExhibitionBasic exhibition;
        public ShownBasic shown;
        public AddExhibition()
        {
            shown = new ShownBasic();
            InitializeComponent();

            exhibition =new ExhibitionBasic();
        }

        

        private void btnYes_Click(object sender, EventArgs e)
        {
            groupBoxArtworks.Visible = true;
            this.dataGridViewArtworks.Rows.Clear();

            List<ArtworkPregled> podaci = DTOManager.getArtworksOverlap2(monthCalendarStartDate.SelectionEnd.Date, monthCalendarEndDate.SelectionEnd.Date);



            foreach (ArtworkPregled p in podaci)
            {
                this.dataGridViewArtworks.Rows.Add(new string[] { p.Artwork_ID.ToString(), p.Title, p.Style, p.Year.ToString(), p.Type, p.Drawn_on, p.Material, p.Weight.ToString(), p.Height.ToString() });

            }

            dataGridViewArtworks.Refresh();
        }

        private void btnAddExhibition_Click(object sender, EventArgs e)
        {
            DateTime start = monthCalendarStartDate.SelectionEnd;
            DateTime end = monthCalendarEndDate.SelectionEnd;
            int EID = 0;
            if (start > end)
            {
                MessageBox.Show("Neuspesno dodavanje " + start.ToString() + "   " + end.ToString());
            }
            else
            {
                this.exhibition.Hall = Int32.Parse(comboBoxHall.Text);
                this.exhibition.Start_Date = monthCalendarStartDate.SelectionEnd.Date;
                this.exhibition.End_Date = monthCalendarEndDate.SelectionEnd.Date;
                EID=DTOManager.addExhibition(this.exhibition);
                MessageBox.Show("Successfully");
                shown.Artwork = DTOManager.getArtwork(Int32.Parse(dataGridViewArtworks.SelectedRows[0].Cells[0].Value.ToString()));
                shown.Exhibition = DTOManager.getExhibition(EID);
                DTOManager.addShown(shown);
            }
            this.Close();
        }
    }
}

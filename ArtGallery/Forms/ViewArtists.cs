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
    public partial class ViewArtists : Form
    {
        public ViewArtists()
        {
            InitializeComponent();
           WriteData();
        }
        public void WriteData()
        {
            this.dataGridView1.Rows.Clear();
            List<ArtistPregled> podaci = DTOManager.getArtists();



            foreach (ArtistPregled p in podaci)
            {
                this.dataGridView1.Rows.Add(new string[] { p.Artist_ID.ToString(), p.Name, p.Last_Name, p.City, p.BirthDate, p.Country });

            }

            dataGridView1.Refresh();
        }
        private void listViewArtist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Choose artist");
                return;
            }

            int idArtist = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
    }
}

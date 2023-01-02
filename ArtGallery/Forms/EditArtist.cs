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
    public partial class EditArtist : Form
    {
        ArtistBasic artist;
        public EditArtist()
        {
            InitializeComponent();
            artist = new ArtistBasic();
            WriteData();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            /*txtArtistName.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtArtistLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtCity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtCountry.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();*/

        }
        public void WriteData()
        {
            this.dataGridView1.Rows.Clear();
            groupBox2.Visible = false;
            List<ArtistPregled> podaci = DTOManager.getArtists();

            foreach (ArtistPregled p in podaci)
            {
                this.dataGridView1.Rows.Add(new string[] { p.Artist_ID.ToString(), p.Name, p.Last_Name, p.City, p.Country , p.BirthDate});

            }
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.groupBox2.Visible = false;
            string finding = textBoxFind.Text;
            bool x = comBoxFilter.GetItemText(comBoxFilter.SelectedItem).Equals("Last Name") == true ? true : false;
            List<ArtistPregled> podaci = DTOManager.getArtistFromFilter(x,finding); 
            foreach (ArtistPregled p in podaci)
            {
                this.dataGridView1.Rows.Add(new string[] { p.Artist_ID.ToString(), p.Name, p.Last_Name, p.City, p.Country, p.BirthDate });

            }
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

            txtArtistName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtArtistLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtCity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtCountry.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            artist.Name = txtArtistName.Text;
            artist.Last_Name = txtArtistLName.Text;
            artist.City = txtCity.Text;
            artist.Country = txtCountry.Text;

            DTOManager.updateArtist(artist);

            this.Close();

        }
    }
}

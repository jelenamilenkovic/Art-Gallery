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
    public partial class RentArtwork : Form
    {
        public RentArtwork()
        {
            InitializeComponent();
        }

        private void groupBoxRent_Enter(object sender, EventArgs e)
        {

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            AddRent();
        }
        public void AddRent()
        {
            RentBasic rent = new RentBasic();
            CustomerBasic cust = new CustomerBasic(Int32.Parse(dataGridViewCustomers.SelectedRows[0].Cells[0].Value.ToString()), dataGridViewCustomers.SelectedRows[0].Cells[1].Value.ToString(),
            dataGridViewCustomers.SelectedRows[0].Cells[2].Value.ToString(), dataGridViewCustomers.SelectedRows[0].Cells[3].Value.ToString(),
            dataGridViewCustomers.SelectedRows[0].Cells[4].Value.ToString());
            for (int i=0;i<this.dataGridViewArtworks.SelectedRows.Count ;i++)
            {
                ArtworkBasic artwork = DTOManager.getArtwork(Int32.Parse(dataGridViewArtworks.SelectedRows[0].Cells[0].Value.ToString()));
                rent.Id = new RentIDBasic();
                rent.Id.Artwork = artwork;
                rent.Id.Customer = cust;
                rent.R_StartDate= dateTimePickerStart.Value.Date;
                rent.R_EndDate=dateTimePickerEnd.Value.Date;
                DTOManager.addRent(rent);
                
            }
            this.Close();
                    
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            WriteArtworks();
            WriteCustomers();

        }
        public void WriteCustomers()
        {
            this.dataGridViewCustomers.Rows.Clear();
            List<CustomerPregled> podaci = DTOManager.getCustomers();



            foreach (CustomerPregled p in podaci)
            {
                this.dataGridViewCustomers.Rows.Add(new string[] { p.Customer_ID.ToString(), p.CustomerName, p.CustomerLastName, p.CustomerEmail, p.CustomerAddress });

            }

            dataGridViewCustomers.Refresh();
        }

        public void WriteArtworks()
        {
            this.dataGridViewArtworks.Rows.Clear();
            List<ArtworkPregled> podaci = DTOManager.getArtworks();



            foreach (ArtworkPregled p in podaci)
            {
                this.dataGridViewArtworks.Rows.Add(new string[] { p.Artwork_ID.ToString(), p.Title, p.Style, p.Year.ToString(), p.Type, p.Drawn_on, p.Material, p.Weight.ToString(), p.Height.ToString() });

            }

            dataGridViewArtworks.Refresh();
        }
    }
}

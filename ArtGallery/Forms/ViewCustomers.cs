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
    public partial class ViewCustomers : Form
    {
        public CustomerBasic customer;
        public ViewCustomers()
        {
            customer = new CustomerBasic();
            InitializeComponent();
            WriteData();
        }

        public void WriteData()
        {
            this.dataGridViewCustomers.Rows.Clear();
            List<CustomerPregled> podaci = DTOManager.getCustomers();



            foreach (CustomerPregled p in podaci)
            {
                this.dataGridViewCustomers.Rows.Add(new string[] { p.Customer_ID.ToString(), p.CustomerName, p.CustomerLastName, p.CustomerEmail, p.CustomerAddress});

            }

            dataGridViewCustomers.Refresh();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Choose artist");
                return;
            }

            int idArtist = Int32.Parse(dataGridViewCustomers.SelectedRows[0].Cells[0].Value.ToString());
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

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dataGridViewCustomers.Rows.Clear();
           // this.groupBox2.Visible = false;
            string finding = textBoxFind.Text;
            string filter = comBoxFilter.GetItemText(comBoxFilter.SelectedItem);
            List<CustomerPregled> podaci = DTOManager.getCustomerFromFilter(filter, finding);
            foreach (CustomerPregled p in podaci)
            {
                this.dataGridViewCustomers.Rows.Add(new string[] { p.Customer_ID.ToString(), p.CustomerName, p.CustomerLastName, p.CustomerEmail, p.CustomerAddress });

            }
            dataGridViewCustomers.ClearSelection();
            dataGridViewCustomers.Refresh();



            
            //dataGridView1.Refresh();a
        }

        private void btnViewArtworks_Click(object sender, EventArgs e)
        {
            this.dataGridViewArtworks.Rows.Clear();
            if (dataGridViewCustomers.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Choose artist");
                return;
            }
            else
            {
                groupBoxCustomer.Visible = false;
                groupBox2.Visible = true;
                List<RentBasic> podaci = DTOManager.getRentWithCID(Int32.Parse(dataGridViewCustomers.SelectedRows[0].Cells[0].Value.ToString()));
                foreach(RentBasic p in podaci)
                {
                    this.dataGridViewArtworks.Rows.Add(new string[] { p.Id.Artwork.Artwork_ID.ToString(), p.Id.Artwork.Title, p.R_StartDate.ToString(), p.R_EndDate.ToString() });
                }
                dataGridViewArtworks.Refresh();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Choose artist");
                return;
            }
            else {
            groupBoxCustomer.Visible = true;

                groupBox2.Visible = false;
                txtCustomerName.Text = dataGridViewCustomers.SelectedRows[0].Cells[1].Value.ToString();
            txtCustomerLName.Text = dataGridViewCustomers.SelectedRows[0].Cells[2].Value.ToString();
            txtEmail.Text = dataGridViewCustomers.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = dataGridViewCustomers.SelectedRows[0].Cells[4].Value.ToString(); }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            customer.CustomerName = txtCustomerName.Text;
            customer.CustomerLastName = txtCustomerLName.Text;
            customer.CustomerEmail = txtEmail.Text;
            customer.CustomerAddress = txtAddress.Text;
            DTOManager.updateCustomer(customer);

            this.Close();
        }
    }
}

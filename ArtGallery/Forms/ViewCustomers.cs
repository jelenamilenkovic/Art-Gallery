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
        public ViewCustomers()
        {
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
    }
}

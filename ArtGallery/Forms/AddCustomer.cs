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
    public partial class AddCustomer : Form
    {
        public CustomerBasic customer;
        public AddCustomer()
        {
            InitializeComponent();
            customer = new CustomerBasic();
        }

        private void btnAddCustomerDB_Click(object sender, EventArgs e)
        {
            this.customer.CustomerName = txtCustomerName.Text;
            this.customer.CustomerLastName = txtCustomerLName.Text;
            this.customer.CustomerEmail = txtEmail.Text;
            this.customer.CustomerAddress = txtAddress.Text;

            DTOManager.addCustomer(this.customer);
            MessageBox.Show("Uspesno ste dodali novog kupca!");
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtGallery.Forms;
using NHibernate;
using ArtGallery.Entities;

namespace ArtGallery
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        List<Panel> listPanel = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            panelArtist.Visible = false;
            panelArtwork.Visible = false;
            panelExhibition.Visible = false;
            panelCustomer.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Artwork r1 = s.Load<Artwork>(1);

                foreach (Entities.Rent p1 in r1.Rent)
                {
                    MessageBox.Show(p1.Rental_Price.ToString());
                }

               

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


               Entities.Customer p = new Entities.Customer();

                p.CustomerName = "Nevena";
                p.CustomerLastName = "Mladenovic";
                p.CustomerEmail = "nevenamladenovic741@yahoo.com";
                p.CustomerAddress = "Kneza Milosa 26 Beograd";

                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           listPanel[0].BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            listPanel[1].BringToFront();
        }

        private void buttonExhibition_Click(object sender, EventArgs e)
        {
            showSubMenu(panelExhibition);
        }

        private void buttonArtwork_Click(object sender, EventArgs e)
        {
            showSubMenu(panelArtwork);
        }

        private void buttonArtist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelArtist);
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCustomer);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddExhibition());

            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new RentArtwork());

            hideSubMenu();
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddArtist());

            hideSubMenu();
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditArtist());

            hideSubMenu();
        }

        private void btnViewArtists_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ViewArtists());

            hideSubMenu();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddCustomer());

            hideSubMenu();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ViewCustomers());

            hideSubMenu();
        }

        private void btnViewExhibition_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ViewExhibition());

            hideSubMenu();
        }

        private void btnEditArtworks_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditArtwork());

            hideSubMenu();
        }

        private void btnViewArtworks_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ViewArtworks());

            hideSubMenu();
        }

        private void btnAddArtwork_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddArtwork());

            hideSubMenu();
        }
    }
}

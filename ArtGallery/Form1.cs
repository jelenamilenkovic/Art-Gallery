using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ArtGallery.Entities;

namespace ArtGallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                ArtGallery.Entities.Artist p = s.Load<ArtGallery.Entities.Artist>(3);
                foreach(Artwork o in p.Artworks) { 
                MessageBox.Show(o.Title);}

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
    }
}

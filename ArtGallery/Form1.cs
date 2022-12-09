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

                Artwork r1 = s.Load<Artwork>(1);

                foreach (Entities.Exhibition p1 in r1.Exhibitions)
                {
                    MessageBox.Show(p1.Hall.ToString());
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
    }
}

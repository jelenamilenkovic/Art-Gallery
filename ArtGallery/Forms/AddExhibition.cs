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
        public AddExhibition()
        {
            InitializeComponent();

            exhibition =new ExhibitionBasic();
        }

        private void btnAddArtistDB_Click(object sender, EventArgs e)
        {

            DateTime start = monthCalendarStartDate.SelectionEnd;
            DateTime end = monthCalendarEndDate.SelectionEnd;

            if (start > end) {
                MessageBox.Show("Neuspesno dodavanje "+ start.ToString() + "   "+end.ToString());
            }
            else { 
            this.exhibition.Hall = Int32.Parse(comboBoxHall.Text);
            this.exhibition.Start_Date = monthCalendarStartDate.SelectionEnd.ToString("dd.MM.yyyy");
            this.exhibition.End_Date = monthCalendarEndDate.SelectionEnd.ToString("dd.MM.yyyy");
            DTOManager.addExhibition(this.exhibition);
            MessageBox.Show("Successfully");}
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Entities
{
    public class Artwork
    {
        public virtual int Artwork_ID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Style{ get; set; }
        public virtual int Year { get; set; }
        public virtual string Type { get; set; }
        public virtual string Drawn_on { get; set; }
        public virtual string Material { get; set; }
        public virtual double Weight { get; set; }
        public virtual double Height { get; set; }
        public virtual int Price { get; set; }
        public virtual IList<Exhibition> Exhibitions { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual IList<Rent> Rent{ get; set; }

        public Artwork()
        {

            Exhibitions = new List<Exhibition>();
        }
    }
}

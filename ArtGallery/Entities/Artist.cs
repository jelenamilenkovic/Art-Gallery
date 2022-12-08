using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Entities
{
    public class Artist
    {
        public virtual int Artist_ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Last_Name { get; set; }
        public virtual string City { get; set; }
        public virtual string BirthDate { get; set; }
        public virtual string Country { get; set; }
        public virtual string Phone_Number { get; set; }
        public virtual IList<Artwork> Artworks { get; set; }
        public Artist()
        {
            Artworks = new List<Artwork>();
        }
    }
}

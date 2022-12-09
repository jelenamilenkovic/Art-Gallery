using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Entities
{
    public class Exhibition
    {
        public virtual int Exhibition_ID { get; protected set; }
        public virtual string Start_Date { get; set; }
        public virtual string End_Date { get; set; }
        public virtual int Hall { get; set; }
        public virtual IList<Artwork> Artworks { get; set; }

        public Exhibition()
        {
            Artworks = new List<Artwork>();
        }
    }
}

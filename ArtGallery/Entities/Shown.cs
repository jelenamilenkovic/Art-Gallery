using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Entities
{
    public class Shown
    {
        public virtual int Id { get; set; }

        public virtual Exhibition Exhibition { get; set; }
        public virtual Artwork Artwork { get; set; }
    }
}

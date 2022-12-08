using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Entities
{
    public class Rent
    {
        public virtual int Id { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Artwork Artwork { get; set; }

        public virtual int Rental_Price { get; set; }
        public virtual DateTime R_StartDate { get; set; }
        public virtual DateTime R_EndDate { get; set; }
    }
}

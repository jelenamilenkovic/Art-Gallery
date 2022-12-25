using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Entities
{
   public class Customer
    {
        public virtual int Customer_ID { get; set; }
        public virtual string CustomerName { get; set; }
        public virtual string CustomerLastName { get; set; }
        public virtual string CustomerEmail { get; set; }
        public virtual string CustomerAddress { get; set; }
        public virtual IList<Artwork> Artworks { get; set; }
        public virtual IList<Rent> Rent { get; set; }

      //  public virtual IList<PhoneNumber> Phone_Numbers { get; set; }

        public Customer()
        {
      //      Phone_Numbers = new List<PhoneNumber>();
            Artworks = new List<Artwork>();
            Rent = new List<Rent>();
        }
    }
}

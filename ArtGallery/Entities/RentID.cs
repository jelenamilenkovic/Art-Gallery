using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Entities
{
    public class RentID
    {
        public virtual Customer Customer { get; set; }
        public virtual Artwork Artwork { get; set; }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(RentID))
                return false;
            RentID recievedObject = (RentID)obj;

            if ((Customer.Customer_ID== recievedObject.Customer.Customer_ID) &&
               (Artwork.Artwork_ID == recievedObject.Artwork.Artwork_ID))
            {
                return true;
            }

            return false;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

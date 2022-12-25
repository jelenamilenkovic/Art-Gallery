using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Entities
{
    public class PhoneNumber
    {

        public virtual int Id { get; set; }
        public virtual string Phone { get; set; }
        public virtual Customer Customer_ID { get; set; }
    }
}

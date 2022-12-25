using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
namespace ArtGallery.Mapping
{
    public class PhoneMapping : ClassMap<ArtGallery.Entities.PhoneNumber>
    {
        public PhoneMapping(){

            Table("C_PHONENUM");

            Id(x => x.Id, "PHONE_ID").GeneratedBy.Increment() ;



            Map(x => x.Phone).Column("PHONE");
            References(x => x.Customer_ID).Column("C_ID").LazyLoad();
        }
    }
}

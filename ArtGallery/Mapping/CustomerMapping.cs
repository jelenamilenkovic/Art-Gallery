using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ArtGallery.Mapping
{
   public class CustomerMapping:ClassMap<ArtGallery.Entities.Customer>
    {
        public CustomerMapping()
        {
            Table("CUSTOMER");
            Id(x => x.Customer_ID, "C_ID").GeneratedBy.Increment();
            Map(x => x.CustomerName, "C_NAME");
            Map(x => x.CustomerLastName, "C_LASTNAME");
            Map(x => x.CustomerEmail, "C_EMAIL");
            Map(x => x.CustomerAddress, "C_ADDRESS");

            HasMany(x => x.Artworks).KeyColumn("C_ID").Cascade.All().Inverse();
            // HasMany(x => x.Shown).KeyColumn("EXHIBITION_ID").LazyLoad().Cascade.All().Inverse();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtGallery.Entities;
using FluentNHibernate.Mapping;

namespace ArtGallery.Mapping
{
   public class ArtistMapping: ClassMap<ArtGallery.Entities.Artist>
    {
        public ArtistMapping() {
            Table("ARTIST");
        Id(x => x.Artist_ID, "ARTIST_ID").GeneratedBy.Increment();
        Map(x => x.Name, "NAME");
        Map(x => x.Last_Name, "LAST_NAME");
        Map(x => x.City, "CITY");
        Map(x => x.Country, "COUNTRY");
        Map(x => x.Phone_Number, "PHONE_NUMBER");
        Map(x => x.BirthDate, "BIRTHDATE");

            HasMany(x => x.Artworks).KeyColumn("ARTIST_ID").Cascade.All().Inverse();
        }
    }
}

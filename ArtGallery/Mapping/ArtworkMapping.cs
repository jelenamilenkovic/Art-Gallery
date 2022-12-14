using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtGallery.Entities;
using FluentNHibernate.Mapping;

namespace ArtGallery.Mapping
{
  public  class ArtworkMapping: ClassMap<ArtGallery.Entities.Artwork>
    {
        public ArtworkMapping()
        {
            Table("ARTWORK");
            Id(x => x.Artwork_ID, "ARTWORK_ID").GeneratedBy.Increment();
            Map(x => x.Year, "YEAR");
            Map(x => x.Title, "TITLE");
            Map(x => x.Style, "STYLE");
            Map(x => x.Price, "B_PRICE");
            Map(x => x.Material, "MATERIAL");
            References(x => x.Artist).Column("ARTIST_ID").LazyLoad();
            References(x => x.Customer).Column("C_ID").LazyLoad();
            Map(x => x.Height, "HEIGHT");
            Map(x => x.Weight, "WEIGHT");
            Map(x => x.Drawn_on, "DRAWN_ON");
            Map(x => x.Type, "TYPEA");

            HasManyToMany(x => x.Exhibitions).Table("SHOWN").ParentKeyColumn("ARTWORK_ID").ChildKeyColumn("EXHIBITION_ID").Cascade.All().Inverse();
            HasMany(x => x.Rent).KeyColumn("ARTWORK_ID").LazyLoad().Cascade.All().Inverse();
        }
    }
}

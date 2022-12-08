using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtGallery.Entities;
using FluentNHibernate.Mapping;

namespace ArtGallery.Mapping
{
    public class ShownMapping : ClassMap<ArtGallery.Entities.Shown>
    {
        public ShownMapping()
        {
            //Mapiranje tabele
            Table("Shown");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.Increment();

            //mapiranje veza
            References(x => x.Exhibition).Column("EXHIBITION_ID");
            References(x => x.Artwork).Column("ARTWORK_ID");
        }
    }
}

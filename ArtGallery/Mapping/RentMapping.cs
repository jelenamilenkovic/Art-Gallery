using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtGallery.Entities;
using FluentNHibernate.Mapping;

namespace ArtGallery.Mapping
{
    public class RentMapping: ClassMap<ArtGallery.Entities.Rent>
    {
        public RentMapping()
        {
            Table("RENT");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("HR.RENT_ID_SEQ");

            //mapiranje veza
            References(x => x.Customer).Column("C_ID");
            References(x => x.Artwork).Column("ARTWORK_ID");
            Map(x => x.Rental_Price, "RENTAL_PRICE");
            Map(x => x.R_EndDate, "R_ENDDATE");
            Map(x => x.R_StartDate, "R_STARTDATE");
        }

    }
}

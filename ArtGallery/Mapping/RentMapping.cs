using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtGallery.Entities;
using FluentNHibernate.Mapping;

namespace ArtGallery.Mapping
{
    public class RentMapping: ClassMap<Rent>
    {
        public RentMapping()
        {
            Table("RENT");

            //mapiranje primarnog kljuca
            CompositeId(x => x.Id).KeyReference(x => x.Artwork, "ARTWORK_ID").KeyReference(x => x.Customer, "C_ID");

            //mapiranje entiteta
            Map(x => x.Rental_Price, "RENTAL_PRICE");
            Map(x => x.R_EndDate, "R_ENDDATE");
            Map(x => x.R_StartDate, "R_STARTDATE");
        }

    }
}

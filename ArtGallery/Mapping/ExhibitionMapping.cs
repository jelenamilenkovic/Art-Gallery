using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ArtGallery.Mapping
{
   public  class ExhibitionMapping : ClassMap<ArtGallery.Entities.Exhibition>
    { 
        public ExhibitionMapping() {
        Table("EXHIBITION");
            Id(x => x.Exhibition_ID, "EXHIBITION_ID").GeneratedBy.Increment();
        Map(x => x.Start_Date, "START_DATE");
        Map(x => x.End_Date, "END_DATE");
        Map(x => x.Hall, "HALL");
       // HasMany(x => x.Shown).KeyColumn("EXHIBITION_ID").LazyLoad().Cascade.All().Inverse();
        }
    }
}

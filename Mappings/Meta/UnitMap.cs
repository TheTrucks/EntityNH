using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class UnitMap : ClassMap<Unit>
    {
        public UnitMap()
        {
            Table("meta.unit");
            Id(x => x.Id);
            Map(x => x.Name).Not.Nullable().Length(255).Unique();
            Map(x => x.Abbr).Not.Nullable().Length(20);
            Map(x => x.NameEng, "name_eng").Length(255).Unique();
            Map(x => x.AbbrEng, "abbr_eng").Length(20);
            Map(x => x.Type).Not.Nullable().Length(50);
            Map(x => x.SIConvert, "si_convertion");
            HasMany(x => x.Offsets).Inverse();
        }
    }
}

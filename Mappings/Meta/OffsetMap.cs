using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class OffsetMap : ClassMap<Offset>
    {
        public OffsetMap()
        {
            Table("meta.offset_type");
            Id(x => x.Id);
            References(x => x.Unit, "unit_id").Not.Nullable();
            Map(x => x.Name).Length(100);
            HasMany(x => x.Catalogs).Inverse();
        }
    }
}

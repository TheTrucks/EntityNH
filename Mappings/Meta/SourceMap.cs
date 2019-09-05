using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class SourceMap : ClassMap<Source>
    {
        public SourceMap()
        {
            Table("meta.source");
            Id(x => x.Id);
            Map(x => x.Name).Not.Nullable().Length(255).Unique();
            Map(x => x.Description).Length(500);
            Map(x => x.NameShort, "name_short").Not.Nullable().Length(4).Unique();
        }
    }
}

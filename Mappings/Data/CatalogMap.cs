using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;
using EntityNH.Entity.Data;

namespace EntityNH.Mappings.Data
{
    public class CatalogMap : ClassMap<Catalog>
    {
        public CatalogMap()
        {
            Table("data.catalog");
            Id(x => x.Id).GeneratedBy.Sequence("data.catalog_id_seq");
            References(x => x.Site, "site_id").Not.Nullable().UniqueKey("uix_ctl");
            References(x => x.Variable, "variable_id").Not.Nullable().UniqueKey("uix_ctl");
            References(x => x.OffsetType, "offset_type_id").Not.Nullable().UniqueKey("uix_ctl");
            Map(x => x.OffsetValue, "offset_value").Not.Nullable().UniqueKey("uix_ctl");
            References(x => x.Method, "method_id").Not.Nullable().UniqueKey("uix_ctl");
            References(x => x.Source, "source_id").Not.Nullable().UniqueKey("uix_ctl");
            Map(x => x.Parent, "parent_id").Not.Nullable();
            HasMany(x => x.DataValues).Cascade.All();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    class MethodMap : ClassMap<Method>
    {
        public MethodMap()
        {
            Table("meta.method");
            Id(x => x.Id);
            Map(x => x.Name).Not.Nullable().Length(250);
            Map(x => x.Description).Not.Nullable().Length(500);
            Map(x => x.Order).Not.Nullable();
            References(x => x.Parent, "parent_id").UniqueKey("ux_site").Not.Nullable();
            Map(x => x.Parameters, "model_output_store_parameters").Not.Nullable();
            Map(x => x.LegalEntityID, "legal_entity_id_source");
            HasMany(x => x.Catalogs).Inverse();
        }
    }
}

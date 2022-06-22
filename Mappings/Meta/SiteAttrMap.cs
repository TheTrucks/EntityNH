using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class SiteAttrMap : ClassMap<SiteAttr>
    {
        public SiteAttrMap()
        {
            Table("meta.site_attr_type");
            Id(x => x.Id);
            Map(x => x.Name).Not.Nullable();
            Map(x => x.SiteTypeIDMandatory, "site_type_id_mandatory");
            HasMany(x => x.Values);
        }
    }
}

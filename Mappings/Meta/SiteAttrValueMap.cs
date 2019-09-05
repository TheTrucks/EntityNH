using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class SiteAttrValueMap : ClassMap<SiteAttrValue>
    {
        public SiteAttrValueMap()
        {
            Table("meta.site_attr_value");
            CompositeId()
                .KeyReference(x => x.Entity, "entity_id")
                .KeyReference(x => x.Type, "attr_type_id")
                .KeyProperty(x => x.DateS, "date_s");
            Map(x => x.Value).Not.Nullable();
        }
    }
}

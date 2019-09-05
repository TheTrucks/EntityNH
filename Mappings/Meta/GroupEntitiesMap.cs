using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class GroupEntitiesMap : ClassMap<GroupEntites>
    {
        public GroupEntitiesMap()
        {
            Table("meta.entity_group_entities");
            CompositeId()
                .KeyReference(x => x.Group, "entity_group_id")
                .KeyReference(x => x.Entity, "entity_id");
            Map(x => x.OrderBy, "order_by");
        }
    }
}

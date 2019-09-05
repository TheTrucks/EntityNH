using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;
using FluentNHibernate.Mapping;

namespace EntityNH.Mappings.Meta
{
    public class EntityGroupMap : ClassMap<EntityGroup>
    {
        public EntityGroupMap()
        {
            Table("meta.entity_group");
            Id(x => x.Id).GeneratedBy.Sequence("meta.entity_group_id_seq");
            Map(x => x.Name);
            References(x => x.Type, "entity_tab_name");
            HasMany(x => x.SiteLinks).Inverse().Cascade.All().KeyColumn("entity_group_id");
        }
    }
}

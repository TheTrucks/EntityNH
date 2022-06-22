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
            HasManyToMany(x => x.SiteList)
                .Table("meta.entity_group_entities")
                .ParentKeyColumn("entity_group_id")
                .ChildKeyColumn("entity_id")
                .Cascade.All();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace EntityNH.Mappings.Meta
{
    public class EntityTypeMap : ClassMap<Entity.Meta.EntityType>
    {
        public EntityTypeMap()
        {
            Table("meta.entity");
            Id(x => x.Name);
            Map(x => x.NameRus, "name_rus");
        }
    }
}

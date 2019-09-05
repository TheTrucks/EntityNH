using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Mappings.Meta
{
    public class ValueTypeMap : ClassMap<Entity.Meta.ValueType>
    {
        public ValueTypeMap()
        {
            Table("meta.value_type");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.NameShort, "name_short");
            Map(x => x.Description);
            HasMany(x => x.Variables).Inverse();
        }
    }
}

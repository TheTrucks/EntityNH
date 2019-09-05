using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Mappings.Meta
{
    public class VariableTypeMap : ClassMap<VariableType>
    {
        public VariableTypeMap()
        {
            Table("meta.variable_type");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.NameShort, "name_short");
            Map(x => x.NameEng, "name_eng");
            Map(x => x.Description);
            HasMany(x => x.Variables).Inverse();
        }
    }
}

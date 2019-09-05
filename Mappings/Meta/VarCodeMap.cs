using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class VarCodeMap : ClassMap<VarCode>
    {
        public VarCodeMap()
        {
            Table("meta.variable_code");
            CompositeId()
                   .KeyReference(x => x.VarId, "variable_id")
                   .KeyProperty(x => x.Code);
            Map(x => x.Name);
            Map(x => x.NameShort, "name_short");
            Map(x => x.Description);
            //HasMany(x => x.Variables).Inverse();
        }
    }
}

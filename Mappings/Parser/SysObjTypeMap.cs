using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Parser;

namespace EntityNH.Mappings.Parser
{
    public class SysObjTypeMap : ClassMap<SysObjType>
    {
        public SysObjTypeMap()
        {
            Table("parser.sysobjtype");
            Id(x => x.Id);
            Map(x => x.Name).Not.Nullable();
        }
    }
}

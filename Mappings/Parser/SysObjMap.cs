using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Parser;

namespace EntityNH.Mappings.Parser
{
    public class SysObjMap : ClassMap<SysObj>
    {
        public SysObjMap()
        {
            Table("parser.sysobj");
            Id(x => x.Id);
            References(x => x.Type, "sysobjtypeid").Not.Nullable();
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Notes);
            Map(x => x.Heap);
            Map(x => x.LastStartParam);
            HasMany(x => x.Parsers).Inverse().Cascade.All();
        }
    }
}

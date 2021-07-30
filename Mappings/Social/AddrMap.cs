using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Social;

namespace EntityNH.Mappings.Social
{
    public class AddrMap : ClassMap<Addr>
    {
        public AddrMap()
        {
            Table("social.addr");
            Id(x => x.Id).GeneratedBy.Sequence("meta.addr_region_id_seq");
            Map(x => x.Name);
            Map(x => x.NameShort, "name_short");
            References(x => x.Type, "addr_type_id");
            References(x => x.Parent, "parent_id");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Social;

namespace EntityNH.Mappings.Social
{
    public class AddrTypeMap : ClassMap<AddrType>
    {
        public AddrTypeMap()
        {
            Table("social.addr_type");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.NameShort, "name_short");
        }
    }
}

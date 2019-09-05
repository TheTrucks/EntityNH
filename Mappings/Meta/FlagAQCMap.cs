using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class FlagAQCMap : ClassMap<FlagAQC>
    {
        public FlagAQCMap()
        {
            Table("meta.flag_aqc");
            Id(x => x.Id, "flag_aqc");
            Map(x => x.Name);
            Map(x => x.NameShort, "name_short");
            Map(x => x.Order);
            HasMany(x => x.DataValues).Inverse();
        }
    }
}

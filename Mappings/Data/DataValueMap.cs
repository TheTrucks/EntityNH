using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Data;

namespace EntityNH.Mappings.Data
{
    public class DataValueMap : ClassMap<DataValue>
    {
        public DataValueMap()
        {
            Table("data.data_value");
            Id(x => x.Id).GeneratedBy.Sequence("data.data_value_id_seq");
            References(x => x.Catalog, "catalog_id").UniqueKey("uk1");
            Map(x => x.DateLocal, "date_loc").Not.Nullable();
            Map(x => x.DateUTC, "date_utc").UniqueKey("uk1").Not.Nullable();
            Map(x => x.Value).UniqueKey("uk1").Not.Nullable();
            References(x => x.FlagAQC, "flag_aqc").Not.Nullable();
            Map(x => x.UTCOffset, "utc_offset").Not.Nullable();
            HasMany(x => x.SourceLinks).Inverse().Cascade.Delete().KeyColumn("data_value_id");
        }
    }
}

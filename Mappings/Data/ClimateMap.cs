using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Data;

namespace EntityNH.Mappings.Data
{
    public class ClimateMap : ClassMap<Climate>
    {
        public ClimateMap()
        {
            Table("data.climate_0");
            Id(x => x.Id);
            References(x => x.Site, "site_id");
            References(x => x.Variable, "variable_id");
            References(x => x.OffsetType, "offset_type_id");
            Map(x => x.OffsetVal, "offset_value");
            References(x => x.DataType, "data_type_id");
            References(x => x.TimeType, "time_id");
            Map(x => x.YearStart, "year_s");
            Map(x => x.YearFinish, "year_f");
            HasMany(x => x.Values).Inverse();
        }
    }
}

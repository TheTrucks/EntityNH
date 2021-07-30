using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Forecast;

namespace EntityNH.Mappings.Forecast
{
    public class DataStoreMap : ClassMap<DataStore>
    {
        public DataStoreMap()
        {
            Table("for_test.data_store");
            Id(x => x.Id).GeneratedBy.Sequence("for_test.forecast_data_store_seq");
            Map(x => x.Date);
            Map(x => x.Depth);
            References(x => x.Location, "location_id");
            HasMany(x => x.DataList).Inverse().Cascade.Delete();
        }
    }
}

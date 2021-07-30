using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Forecast;

namespace EntityNH.Mappings.Forecast
{
    public class ForecastDataMap : ClassMap<ForecastData>
    {
        public ForecastDataMap()
        {
            Table("for_test.forecast_data");
            Id(x => x.Id).GeneratedBy.Sequence("for_test.forecast_data_seq");
            References(x => x.DataStore, "data_store_id");
            References(x => x.Variable, "variable_id");
            Map(x => x.Value);
            Map(x => x.Order, "sort_order");
            Map(x => x.Commentary);
        }
    }
}

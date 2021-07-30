using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Forecast;

namespace EntityNH.Mappings.Forecast
{
    public class LocationMap : ClassMap<Location>
    {
        public LocationMap()
        {
            Table("for_test.location");
            Id(x => x.Id);
            References(x => x.Address, "addr_id");
            References(x => x.Station, "station_id");
            Map(x => x.Order, "sort_order");
        }
    }
}

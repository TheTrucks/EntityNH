using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class StationXGeoObjMap : ClassMap<StationXGeoObj>
    {
        public StationXGeoObjMap()
        {
            Table("meta.station_x_geoobject");
            CompositeId()
                .KeyReference(x => x.Station, "station_id")
                .KeyReference(x => x.GeoObject, "geo_object_id");
            Map(x => x.Order, "\"order\"");
        }
    }
}

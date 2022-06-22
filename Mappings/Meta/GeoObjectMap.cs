using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class GeoObjectMap : ClassMap<GeoObject>
    {
        public GeoObjectMap()
        {
            Table("meta.geo_object");
            Id(x => x.Id);
            References(x => x.Type, "geo_type_id");
            Map(x => x.Name);
            References(x => x.FallInto, "fall_into_id");
            Map(x => x.Order, "\"order\"");

            HasManyToMany(x => x.Stations)
                .Table("meta.station_x_geoobject")
                .ParentKeyColumn("geo_object_id")
                .ChildKeyColumn("station_id")
                .Cascade.All();
        }
    }
}

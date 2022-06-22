using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings
{
    class StationMap : ClassMap<Station>
    {
        public StationMap()
        {
            Table("meta.station");
            Id(x => x.Id).GeneratedBy.Sequence("meta.station_id_seq");
            Map(x => x.Code).UniqueKey("uc_code").Not.Nullable();
            Map(x => x.Name).Not.Nullable();
            References(x => x.Type, "station_type_id").UniqueKey("uc_code").Not.Nullable();
            Map(x => x.NameEng, "name_eng");
            Map(x => x.NameEngShort, "name_short_eng");
            Map(x => x.AddrRegion, "addr_region_id");
            Map(x => x.Org, "org_id");
            HasMany(x => x.Sites).Cascade.All();

            HasManyToMany(x => x.GeoObjects)
                .Table("meta.station_x_geoobject")
                .ParentKeyColumn("station_id")
                .ChildKeyColumn("geo_object_id")
                .Inverse()
                .Cascade.All();
        }
    }
}

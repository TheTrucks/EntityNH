using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class SiteMap : ClassMap<Site>
    {
        public SiteMap()
        {
            Table("meta.site");
            Id(x => x.Id).GeneratedBy.Sequence("meta.site_id_seq");
            References(x => x.Station, "station_id").UniqueKey("ux_site").Not.Nullable();
            References(x => x.Type, "site_type_id").UniqueKey("ux_site").Not.Nullable();
            Map(x => x.Description);
            Map(x => x.Code).UniqueKey("ux_site");
            HasMany(x => x.Catalogs).AsSet().Cascade.All().KeyColumn("site_id");
            HasMany(x => x.AttrValues).KeyColumn("entity_id").Cascade.All();
            HasMany(x => x.Parsers).Cascade.All().KeyColumn("siteid");

            HasManyToMany(x => x.EntityGroups)
                .Table("meta.station_x_geoobject")
                .ParentKeyColumn("station_id")
                .ChildKeyColumn("geo_object_id")
                .Cascade.All();
        }
    }
}

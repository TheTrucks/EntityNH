using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    class StationTypeMap : ClassMap<StationType>
    {
        public StationTypeMap()
        {
            Table("meta.station_type");
            Id(x => x.Id);
            Map(x => x.Name).Unique().Not.Nullable();
            Map(x => x.NameShort, "name_short").Unique().Not.Nullable();
            HasMany(x => x.Stations).KeyColumn("station_type_id").Inverse();
        }

    }
}

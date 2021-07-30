using System;
using System.Collections.Generic;
using System.Linq;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Data;

namespace EntityNH.Mappings.Data
{
    public class ClimateValueMap : ClassMap<ClimateValue>
    {
        public ClimateValueMap()
        {
            Table("data.climate_1");
            CompositeId()
                .KeyReference(x => x.Parent, "climate_0_id")
                .KeyProperty(x => x.TimeValue, "time_num");
            Map(x => x.Value);
        }
    }
}

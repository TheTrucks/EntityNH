using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;
using FluentNHibernate.Mapping;

namespace EntityNH.Mappings.Meta
{
    public class GeoTypeMap : ClassMap<GeoType>
    {
        public GeoTypeMap()
        {
            Table("meta.geo_type");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.NameEng, "name_eng");
        }
    }
}

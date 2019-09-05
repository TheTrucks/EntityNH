using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class SampleMediumMap : ClassMap<SampleMedium>
    {
        public SampleMediumMap()
        {
            Table("meta.sample_medium");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description, "name_short");
            HasMany(x => x.Variables).Inverse();
        }
    }
}

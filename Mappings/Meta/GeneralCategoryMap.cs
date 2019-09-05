using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class GeneralCategoryMap : ClassMap<GeneralCategory>
    {
        public GeneralCategoryMap()
        {
            Table("meta.general_category");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.NameShort, "name_short");
            Map(x => x.Order);
            HasMany(x => x.Variables).Inverse();
        }
    }
}

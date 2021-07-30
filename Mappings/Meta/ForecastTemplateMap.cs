using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class ForecastTemplateMap : ClassMap<ForecastTemplate>
    {
        public ForecastTemplateMap()
        {
            Table("meta.forecast_list");
            Id(x => x.Id);
            References(x => x.Variable, "var_id");
            Map(x => x.Description);
            Map(x => x.SortOrder, "sort_order");
        }
    }
}

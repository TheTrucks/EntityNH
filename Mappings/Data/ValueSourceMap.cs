using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Data;

namespace EntityNH.Mappings.Data
{
    public class ValueSourceMap : ClassMap<ValueSource>
    {
        public ValueSourceMap()
        {
            Table("data.datavalue_datasource");
            CompositeId()
                .KeyReference(x => x.Value, "data_value_id")
                .KeyReference(x => x.Source, "data_source_id");
        }
    }
}

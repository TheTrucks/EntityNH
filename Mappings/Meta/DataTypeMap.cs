using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class DataTypeMap : ClassMap<DataType>
    {
        public DataTypeMap()
        {
            Table("meta.data_type");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.NameShort, "name_short");
            Map(x => x.Description);
            HasMany(x => x.Variables).Inverse();
        }
    }
}

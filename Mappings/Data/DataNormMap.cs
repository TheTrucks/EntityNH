using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;
using EntityNH.Entity.Data;

namespace EntityNH.Mappings.Data
{
    public class DataNormMap : ClassMap<DataNorm>
    {
        public DataNormMap()
        {
            Table("data.data_norm");
            Id(x => x.Id).GeneratedBy.Sequence("data.norma_id_seq");
            References(x => x.Site, "site_id").Not.Nullable();
            Map(x => x.ObservationTime, "date_obs").Not.Nullable();
            References(x => x.NormType, "norm_type_id").Not.Nullable();
            Map(x => x.Value, "norm_value").Not.Nullable();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Data;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Data
{
    public class DataSourceMap : ClassMap<DataSource>
    {
        public DataSourceMap()
        {
            Table("data.data_source");
            Id(x => x.Id).GeneratedBy.Sequence("data.data_source_id_seq");
            References(x => x.Site, "site_id");
            References(x => x.CodeForm, "code_form_id");
            Map(x => x.DateUTC, "date_utc");
            Map(x => x.DateUTCReceive, "date_utc_recieve");
            Map(x => x.DateLocInsert, "date_loc_insert");
            Map(x => x.Value);
            Map(x => x.Hash);
            HasMany(x => x.ValueLinks).Cascade.Delete().KeyColumn("data_source_id");
        }
    }
}

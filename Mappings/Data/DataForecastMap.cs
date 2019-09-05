using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Data;

namespace EntityNH.Mappings.Data
{
    public class DataForecastMap : ClassMap<DataForecast>
    {
        public DataForecastMap()
        {
            Table("data.data_forecast");
            //Map(x => x.FCSLag, "fcs_lag").Not.Nullable();
            //Map(x => x.DateFCS, "date_fcs").Not.Nullable();
            //Map(x => x.DateInsert, "date_insert").Not.Nullable();
            //Map(x => x.Value).Not.Nullable();
            //References(x => x.Catalog, "catalog_id").Not.Nullable();
            CompositeId()
                .KeyProperty(x => x.FCSLag, "fcs_lag")
                .KeyProperty(x => x.DateFCS, "date_fcs")
                .KeyProperty(x => x.DateInsert, "date_insert")
                .KeyProperty(x => x.Value)
                .KeyReference(x => x.Catalog, "catalog_id");
        }
    }
}

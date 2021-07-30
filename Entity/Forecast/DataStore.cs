using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Forecast
{
    public class DataStore
    {
        public virtual long? Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual int Depth { get; set; }
        public virtual Location Location { get; set; }
        public virtual IList<ForecastData> DataList { get; set; }
    }
}

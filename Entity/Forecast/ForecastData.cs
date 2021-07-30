using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;

namespace EntityNH.Entity.Forecast
{
    public class ForecastData
    {
        public virtual long? Id { get; set; }
        public virtual DataStore DataStore { get; set; }
        public virtual Variable Variable { get; set; }
        public virtual double? Value { get; set; }
        public virtual int Order { get; set; }
        public virtual string Commentary { get; set; }
    }
}

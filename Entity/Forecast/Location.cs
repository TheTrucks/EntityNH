using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Social;
using EntityNH.Entity.Meta;

namespace EntityNH.Entity.Forecast
{
    public class Location
    {
        public virtual int? Id { get; set; }
        public virtual Addr Address { get; set; }
        public virtual Station Station { get; set; }
        public virtual int Order { get; set; }
    }
}

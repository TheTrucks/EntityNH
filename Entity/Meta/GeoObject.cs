using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Meta
{
    public class GeoObject
    {
        public virtual int? Id { get; set; }
        public virtual GeoType Type { get; set; }
        public virtual string Name { get; set; }
        public virtual GeoObject FallInto { get; set; }
        public virtual int? Order { get; set; }
        public virtual IList<Station> Stations { get; set; }
    }
}

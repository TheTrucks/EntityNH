using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Meta
{
    public class Station
    {
        public virtual int? Id { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual StationType Type { get; set; }
        public virtual string NameEng { get; set; }
        public virtual string NameEngShort { get; set; }
        public virtual int? AddrRegion { get; set; }
        public virtual int? Org { get; set; }
        public virtual IList<Site> Sites { get; set; }

        public virtual ISet<GeoObject> GeoObjects { get; set; }
    }
}

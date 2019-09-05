using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Meta
{
    public class StationType
    {
        public virtual int? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string NameShort { get; set; }
        public virtual IList<Station> Stations { get; set; }
        public virtual IList<Site> Sites { get; set; }
    }
}

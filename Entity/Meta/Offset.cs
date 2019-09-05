using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Data;

namespace EntityNH.Entity.Meta
{
    public class Offset
    {
        public virtual int? Id { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Catalog> Catalogs { get; set; }
    }
}

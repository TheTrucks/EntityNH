using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Data;
using EntityNH.Entity.Parser;

namespace EntityNH.Entity.Meta
{
    public class Site
    {
        public virtual int? Id { get; set; }
        public virtual Station Station { get; set; }
        public virtual StationType Type { get; set; }
        public virtual string Description { get; set; }
        public virtual string Code { get; set; }
        public virtual ISet<Catalog> Catalogs { get; set; }
        public virtual IList<SiteAttrValue> AttrValues { get; set; }
        public virtual IList<SysParsersXSites> Parsers { get; set; }
        public virtual ISet<EntityGroup> EntityGroups { get; set; }
    }
}

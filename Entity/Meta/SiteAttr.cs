using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Meta
{
    public class SiteAttr
    {
        public virtual int? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string SiteTypeIDMandatory { get; set; }
        public virtual IList<SiteAttrValue> Values { get; set; }
    }
}

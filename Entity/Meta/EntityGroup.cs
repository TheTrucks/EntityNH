using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;

namespace EntityNH.Entity.Meta
{
    public class EntityGroup
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual EntityType Type { get;set; }
        public virtual IList<GroupEntites> SiteLinks { get; set; }
    }
}

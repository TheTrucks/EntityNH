using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Data;
namespace EntityNH.Entity.Meta
{
    public class Method
    {
        public virtual int? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int? Order { get; set; }
        public virtual Method Parent { get; set; }
        public virtual string Parameters { get; set; }
        public virtual int? LegalEntityID { get; set; }
        public virtual IList<Catalog> Catalogs { get; set; }
    }
}

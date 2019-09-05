using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Meta
{
    public class GeneralCategory
    {
        public virtual int? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string NameShort { get; set; }
        public virtual int? Order { get; set; }
        public virtual IList<Variable> Variables { get; set; }
    }
}

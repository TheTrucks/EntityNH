using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Meta
{
    public class Unit
    {
        public virtual int? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Abbr { get; set; }
        public virtual string NameEng { get; set; }
        public virtual string AbbrEng { get; set; }
        public virtual string Type { get; set; }
        public virtual double SIConvert { get; set; }
        public virtual IList<Offset> Offsets { get; set; }
    }
}

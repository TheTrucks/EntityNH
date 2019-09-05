using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;

namespace EntityNH.Entity.Data
{
    public class Catalog
    {
        public virtual int? Id { get; set; }
        public virtual Site Site { get; set; }
        public virtual Variable Variable { get; set; }
        public virtual Offset OffsetType { get; set; }
        public virtual double? OffsetValue { get; set; }
        public virtual Method Method { get; set; }
        public virtual Source Source { get; set; }
        public virtual int? Parent { get; set; }
        public virtual IList<DataValue> DataValues { get; set; }
    }
}

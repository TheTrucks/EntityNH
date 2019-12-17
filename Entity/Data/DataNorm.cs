using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;
using EntityNH.Entity.Parser;

namespace EntityNH.Entity.Data
{
    public class DataNorm
    {
        public virtual int? Id { get; set; }
        public virtual Site Site { get; set; }
        public virtual int? ObservationTime { get; set; }
        public virtual Variable NormType { get; set; }
        public virtual double? Value { get; set; }
    }
}

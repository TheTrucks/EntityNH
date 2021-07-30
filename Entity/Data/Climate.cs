using System;
using System.Collections.Generic;
using System.Linq;
using EntityNH.Entity.Meta;

namespace EntityNH.Entity.Data
{
    public class Climate
    {
        public virtual int Id { get; set; }
        public virtual Site Site { get; set; }
        public virtual Variable Variable { get; set; }
        public virtual Offset OffsetType { get; set; }
        public virtual double OffsetVal { get; set; }
        public virtual DataType DataType { get; set; }
        public virtual Unit TimeType { get; set; }
        public virtual int YearStart { get; set; }
        public virtual int YearFinish { get; set; }
        public virtual IList<ClimateValue> Values { get; set; }
    }
}

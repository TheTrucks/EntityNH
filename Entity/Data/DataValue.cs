using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;

namespace EntityNH.Entity.Data
{
    public class DataValue
    {
        public virtual long? Id { get; set; }
        public virtual Catalog Catalog { get; set; }
        public virtual DateTime DateLocal { get; set; }
        public virtual DateTime DateUTC { get; set; }
        public virtual double? Value { get; set; }
        public virtual FlagAQC FlagAQC { get; set; }
        public virtual float? UTCOffset { get; set; }
        public virtual IList<ValueSource> SourceLinks { get; set; }
    }
}

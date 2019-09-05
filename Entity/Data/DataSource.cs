using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;
using EntityNH.Entity.Data;

namespace EntityNH.Entity.Data
{
    public class DataSource
    {
        public virtual long? Id { get; set; }
        public virtual Site Site { get; set; }
        public virtual CodeForm CodeForm { get; set; }
        public virtual DateTime DateUTC { get; set; }
        public virtual DateTime DateUTCReceive { get; set; }
        public virtual DateTime DateLocInsert { get; set; }
        public virtual string Value { get; set; }
        public virtual string Hash { get; set; }
        public virtual IList<ValueSource> ValueLinks { get; set; }
    }
}

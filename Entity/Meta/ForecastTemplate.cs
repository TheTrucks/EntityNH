using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;

namespace EntityNH.Entity.Meta
{
    public class ForecastTemplate
    {
        public virtual int Id { get; set; }
        public virtual Variable Variable { get; set; }
        public virtual string Description { get; set; }
        public virtual int? SortOrder { get; set; }
    }
}

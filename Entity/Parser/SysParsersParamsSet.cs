using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Parser
{
    public class SysParsersParamsSet
    {
        public virtual int? Id { get; set; }
        public virtual int? CodeFormId { get; set; }
        public virtual IList<SysParsersParams> ParamsList { get; set; }
        public virtual IList<SysParsersXSites> Parsers { get; set; }
    }
}

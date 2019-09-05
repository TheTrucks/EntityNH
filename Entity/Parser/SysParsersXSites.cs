using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;

namespace EntityNH.Entity.Parser
{
    public class SysParsersXSites
    {
        public virtual int? Id { get; set; }
        public virtual Site Site { get; set; }
        public virtual SysObj SysObj { get; set; }
        public virtual string ExtSite { get; set; }
        public virtual SysParsersParamsSet ParamsSet { get; set; }
        public virtual bool IsActual { get; set; }
    }
}

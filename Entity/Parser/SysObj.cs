using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Parser
{
    public class SysObj
    {
        public virtual int? Id { get; set; }
        public virtual SysObjType Type { get; set; }
        public virtual string Name { get; set; }
        public virtual string Notes { get; set; }
        public virtual string Heap { get; set; }
        public virtual string LastStartParam { get; set; }
        public virtual IList<SysParsersXSites> Parsers { get; set; }
    }
}

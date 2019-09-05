using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;

namespace EntityNH.Entity.Parser
{
    public class SysParsersParams
    {
        public virtual int? Id { get; set; }
        public virtual SysParsersParamsSet ParamsSet { get; set; }
        public virtual Variable IntVariable { get; set; }
        public virtual Offset IntOffset { get; set; }
        public virtual string Extparam { get; set; }
        public virtual int? ExtLevel { get; set; }
        public virtual double Multiplier { get; set; }
        public virtual bool WriteNoDataValue { get; set; }
    }
}

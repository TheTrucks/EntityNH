using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Parser;

namespace EntityNH.Mappings.Parser
{
    public class SysParsersParamsMap : ClassMap<SysParsersParams>
    {
        public SysParsersParamsMap()
        {
            Table("parser.sysparsersparams");
            Id(x => x.Id);
            References(x => x.ParamsSet, "sysparsersparamssetid").Not.Nullable();
            References(x => x.IntVariable, "intvariableid").Not.Nullable();
            References(x => x.IntOffset, "intoffsetid").Not.Nullable();
            Map(x => x.Extparam).Not.Nullable();
            Map(x => x.ExtLevel, "extlevelid").Not.Nullable();
            Map(x => x.Multiplier).Not.Nullable();
            Map(x => x.WriteNoDataValue).Default("true");
        }
    }
}

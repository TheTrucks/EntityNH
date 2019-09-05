using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Parser;

namespace EntityNH.Mappings.Parser
{
    public class SysParsersParamsSetMap : ClassMap<SysParsersParamsSet>
    {
        public SysParsersParamsSetMap()
        {
            Table("parser.sysparsersparamsset");
            Id(x => x.Id);
            Map(x => x.CodeFormId).Not.Nullable();
            HasMany(x => x.ParamsList).Inverse().Cascade.All();
            HasMany(x => x.Parsers).Inverse().Cascade.All();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;
using EntityNH.Entity.Parser;

namespace EntityNH.Mappings.Parser
{
    public class SysParsersXSitesMap : ClassMap<SysParsersXSites>
    {
        public SysParsersXSitesMap()
        {
            Table("parser.sysparsersxsites");
            Id(x => x.Id).GeneratedBy.Sequence("parser.sysparsersxsites_id_seq");
            References(x => x.Site, "siteid").Not.Nullable();
            References(x => x.SysObj, "sysobjid").Not.Nullable();
            Map(x => x.ExtSite, "extsiteid").Length(50);
            References(x => x.ParamsSet, "sysparsersparamssetid").Not.Nullable();
            Map(x => x.IsActual).Not.Nullable().Default("true");
        }
    }
}

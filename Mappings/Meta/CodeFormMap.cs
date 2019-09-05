using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class CodeFormMap : ClassMap<CodeForm>
    {
        public CodeFormMap()
        {
            Table("meta.code_form");
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}

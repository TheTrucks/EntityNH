using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EntityNH.Entity.Meta;

namespace EntityNH.Mappings.Meta
{
    public class VariableMap : ClassMap<Variable>
    {
        public VariableMap()
        {
            Table("meta.variable");
            Id(x => x.Id);
            References(x => x.VarType, "variable_type_id");
            References(x => x.TimeType, "time_id");
            References(x => x.Unit, "unit_id");
            References(x => x.ValType, "value_type_id");
            References(x => x.DataType, "data_type_id");
            References(x => x.CategoryType, "general_category_id");
            References(x => x.SampleSource, "sample_medium_id");
            Map(x => x.TimeSupport, "time_support");
            Map(x => x.Name);
            Map(x => x.NameEng, "name_eng");
            Map(x => x.NoDataCode, "code_no_data");
            Map(x => x.ErrorDataCode, "code_err_data");
            HasMany(x => x.Catalogs).Inverse();
            HasMany(x => x.Codes).Cascade.All();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Meta
{
    public class Variable
    {
        public virtual int? Id { get; set; }
        public virtual VariableType VarType { get; set; }
        public virtual Unit TimeType { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ValueType ValType { get; set; }
        public virtual DataType DataType { get; set; }
        public virtual GeneralCategory CategoryType { get; set; }
        public virtual SampleMedium SampleSource { get; set; }
        public virtual int? TimeSupport { get; set; }
        public virtual string Name { get; set; }
        public virtual string NameEng { get; set; }
        public virtual double? NoDataCode { get; set; }
        public virtual double? ErrorDataCode { get; set; }
        public virtual IList<Data.Catalog> Catalogs { get; set; }
        public virtual IList<VarCode> Codes { get; set; }
    }
}

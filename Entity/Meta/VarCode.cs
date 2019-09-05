using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Meta
{
    public class VarCode
    {
        public virtual Variable VarId { get; set; }
        public virtual int? Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string NameShort { get; set; }
        public virtual string Description { get; set; }
        //public virtual IList<Variable> Variables { get; set; }

        public override bool Equals(object obj)
        {
            var typeObj = (VarCode)obj;

            return this.VarId.Id == typeObj.VarId.Id &&
                this.Code == typeObj.Code;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 13) ^ VarId.Id.GetHashCode();
                hash = (hash * 13) ^ Code.GetHashCode();

                return hash;
            }
        }
    }
}

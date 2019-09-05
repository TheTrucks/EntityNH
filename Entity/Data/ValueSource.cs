using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Data
{
    public class ValueSource
    {
        public virtual DataValue Value { get; set; }
        public virtual DataSource Source { get; set; }

        public override bool Equals(object obj)
        {
            var typeObj = (ValueSource)obj;

            return this.Value.Id == typeObj.Value.Id &&
                this.Source.Id == typeObj.Source.Id;                
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 3) ^ Value.Id.GetHashCode();
                hash = (hash * 3) ^ Source.Id.GetHashCode();

                return hash;
            }
        }
    }
}

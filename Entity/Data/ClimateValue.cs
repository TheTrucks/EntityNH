using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Data
{
    public class ClimateValue
    {
        public virtual Climate Parent { get; set; }
        public virtual double Value { get; set; }
        public virtual int TimeValue { get; set; }

        public override bool Equals(object obj)
        {
            var typedObj = (ClimateValue)obj;

            return
                this.Parent.Id == typedObj.Parent.Id
                && this.Value == typedObj.Value
                && this.TimeValue == typedObj.TimeValue;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash += Parent.Id.GetHashCode() * 2;
                hash += Value.GetHashCode() * 3;
                hash += TimeValue.GetHashCode() * 4;

                return hash;
            }
        }
    }
}

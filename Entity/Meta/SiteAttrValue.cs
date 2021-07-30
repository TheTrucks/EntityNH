using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Meta
{
    public class SiteAttrValue
    {
        public virtual Site Entity { get; set; }
        public virtual SiteAttr Type { get; set; }
        public virtual string Value { get; set; }
        public virtual DateTime DateS { get; set; }

        public override bool Equals(object obj)
        {
            var typeObj = (SiteAttrValue)obj;

            return this.Entity.Id == typeObj.Entity.Id &&
                this.Type.Id == typeObj.Type.Id &&
                this.DateS == typeObj.DateS;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash += (hash * 7) ^ Entity.Id.GetHashCode();
                hash += (hash * 7) ^ Type.Id.GetHashCode();
                hash += (hash * 7) ^ DateS.GetHashCode();

                return hash;
            }
        }
    }
}

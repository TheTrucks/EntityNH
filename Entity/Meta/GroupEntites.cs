using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityNH.Entity.Meta;

namespace EntityNH.Entity.Meta
{
    public class GroupEntites
    {
        public virtual EntityGroup Group { get; set; }
        public virtual Site Entity { get; set; }
        public virtual string OrderBy { get; set; }
        public override bool Equals(object obj)
        {
            var typeObj = (GroupEntites)obj;

            return this.Group.Id == typeObj.Group.Id &&
                this.Entity.Id == typeObj.Entity.Id;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 2) ^ Group.Id.GetHashCode();
                hash = (hash * 3) ^ Entity.Id.GetHashCode();
                int ord;
                if (!string.IsNullOrEmpty(OrderBy) && int.TryParse(OrderBy, out ord))
                    hash *= (ord >= 0 ? ord : 1);

                return hash;
            }
        }
    }
}

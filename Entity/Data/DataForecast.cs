using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Data
{
    public class DataForecast
    {
        public virtual double FCSLag { get; set; }
        public virtual DateTime DateFCS { get; set; }
        public virtual DateTime DateInsert { get; set; }
        public virtual double Value { get; set; }
        public virtual Catalog Catalog { get; set; }

        public override bool Equals(object obj)
        {
            var typeObj = (DataForecast)obj;

            return this.FCSLag == typeObj.FCSLag &&
                this.DateFCS == typeObj.DateFCS &&
                this.DateInsert == typeObj.DateInsert &&
                this.Value == typeObj.Value &&
                this.Catalog.Id == typeObj.Catalog.Id;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 2) ^ FCSLag.GetHashCode();
                hash = (hash * 2) ^ DateFCS.GetHashCode();
                hash = (hash * 2) ^ DateInsert.GetHashCode();
                hash = (hash * 2) ^ Value.GetHashCode();
                hash = (hash * 2) ^ Catalog.Id.GetHashCode();

                return hash;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityNH.Entity.Meta
{
    public class StationXGeoObj
    {
        public virtual Station Station { get; set; }
        public virtual GeoObject GeoObject { get; set; }
        public virtual int Order { get; set; }

        public override bool Equals(object obj)
        {
            var typeObj = (StationXGeoObj)obj;

            return this.Station.Id == typeObj.Station.Id &&
                this.GeoObject.Id == typeObj.GeoObject.Id;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 2) ^ Station.Id.GetHashCode();
                hash = (hash * 3) ^ GeoObject.Id.GetHashCode();

                return hash;
            }
        }
    }
}

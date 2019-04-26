using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AsScale : Basics
    {
        public DateTime CreateTime { get; set; }

        public int OperId { get; set; }

        public DateTime OperTime { get; set; }

        public string Name { get; set; }

        public string Descr { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string ProvinceId { get; set; }

        public string CityId { get; set; }

        public string DistrictId { get; set; }

        public bool IsActive { get; set; }
    }
}

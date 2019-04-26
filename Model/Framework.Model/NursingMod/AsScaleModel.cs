using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 量表
    /// </summary>
    public class AsScaleModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OperId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime OperTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProvinceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DistrictId { get; set; }

        /// <summary>
        /// 操作员名称
        /// </summary>
        public string OperName { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        public string ProvinceName { get; set; }
        /// <summary>
        /// 市名称
        /// </summary>
        public string CityName { get; set; }
        /// <summary>
        /// 区名称
        /// </summary>
        public string DistrictName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsActive { get; set; }
    }
}

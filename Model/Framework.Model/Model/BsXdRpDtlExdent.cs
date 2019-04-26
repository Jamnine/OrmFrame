

using System;
namespace Orm.Model
{
    /// <summary>
    /// 减号套餐明细表 - 实体类
    /// </summary>
    public partial class BsXdRpDtl
    {
        private string _locationId;  //Name
        private string _name;  //Name
        private Double _amount;  //Name 

        ///// <summary>
        ///// 项目名称
        ///// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        ///// <summary>
        ///// 总金额
        ///// </summary> 
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        /// <summary>
        /// 所在机构ID
        /// </summary> 
        public string LocationId
        {
			get { return _locationId; }
			set { _locationId = value;}
		}

    }  
}           



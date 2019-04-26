

using System;
namespace Orm.Model
{
    /// <summary>
    /// 传染病报告卡 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsInfection : BaseModel
    {

         
        private string _name;  //传染病名称

        private int _type;  //传染病类型：1、甲类，2、乙类，3、丙类，4、其他

        private bool _isActive;  //是否有效标识

        private int _orderby;  //排序

        private int _HospitalID;  //
         
        /// <summary>
        /// 传染病名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 传染病类型：1、甲类，2、乙类，3、丙类，4、其他
        /// </summary>
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 是否有效标识
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// 排序
        /// </summary>
        public int Orderby
        {
            get { return _orderby; }
            set { _orderby = value; }
        }

  

    }
}



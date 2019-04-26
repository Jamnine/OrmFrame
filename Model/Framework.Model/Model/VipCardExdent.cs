

using System;
namespace Orm.Model
{
	/// <summary>
	/// 会员卡表 - 实体类
	/// </summary> 
	public partial class VipCard :BaseModel
	{
		private string _introducerName;  //卡号
		private string _vipTypeID;  //卡号
        private string _name;
        private string _introducerOperName;

        /// <summary>
        /// 推荐人名称
        /// </summary>
        public string IntroducerName
        {
            get { return _introducerName; }
            set { _introducerName = value; }
        }
        /// <summary>
        /// 推荐操作人名称
        /// </summary>
        public string IntroducerOperName
        {
            get { return _introducerOperName; }
            set { _introducerOperName = value; }
        }
        /// <summary>
        /// VipTypeID
        /// </summary>
        public string VipTypeID
        {
            get { return _vipTypeID; }
            set { _vipTypeID = value; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }  
}           



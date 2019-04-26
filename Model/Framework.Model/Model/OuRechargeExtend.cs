

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:会员充值表 - 实体类
	/// </summary>
	public partial class OuRecharge : BaseModel
	{
        private string _payWayName;  
        private string _operTypeName;  
        private string _operName;
        private string _hospitalName;
        public string PayWayName
        {
            get { return _payWayName; }
            set { _payWayName = value; }
        }
        public string OperTypeName
        {
            get { return _operTypeName; }
            set { _operTypeName = value; }
        }
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }
        public string HospitalName
        {
            get { return _hospitalName; }
            set { _hospitalName = value; }
        }


    }  
}           



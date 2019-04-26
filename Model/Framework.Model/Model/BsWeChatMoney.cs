

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:微信红包记录表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsWeChatMoney : BaseModel
    {   		
		private string _doctorId;  //医生id
		
		private DateTime _operTime;  //发送日期
		
		private string _loctionId;  //诊所id
		
		private double _money;  //金额
		
		private int _HospitalID;  //

        public BsWeChatMoney() { }                                   
		
		/// <summary>
		/// 医生id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 发送日期
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 诊所id
		/// </summary>
		public string LoctionId
		{
			get { return _loctionId;}
			set { _loctionId = value;}
		}                                    
		
		/// <summary>
		/// 金额
		/// </summary>
		public double Money
		{
			get { return _money;}
			set { _money = value;}
		}                                    
		
                                   
		        
	}  
}           





using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsLimitDocLev:BaseModel
	{    
		private string _limitGroupId;  //限额
		
		private string _docLevId;  //职称对应BsDocLevel.Id
		
		private int _orderBy;  //排序
		
		private string _typeGFXEId;  //公费限额类别
		
		private double _limitFeeMz;  //门诊限制金额
		
		private double _limitFeeZy;  //门诊限制金额
		
		private string _lsLimitType;  //限额类别：1-每天限额；2-每次限额
		
		private bool _isActive;  //是否有效标识

        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 限额
		/// </summary>
		public string LimitGroupId
		{
			get { return _limitGroupId;}
			set { _limitGroupId = value;}
		}                                    
		
		/// <summary>
		/// 职称对应BsDocLevel.Id
		/// </summary>
		public string DocLevId
		{
			get { return _docLevId;}
			set { _docLevId = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 公费限额类别
		/// </summary>
		public string TypeGFXEId
		{
			get { return _typeGFXEId;}
			set { _typeGFXEId = value;}
		}                                    
		
		/// <summary>
		/// 门诊限制金额
		/// </summary>
		public double LimitFeeMz
		{
			get { return _limitFeeMz;}
			set { _limitFeeMz = value;}
		}                                    
		
		/// <summary>
		/// 门诊限制金额
		/// </summary>
		public double LimitFeeZy
		{
			get { return _limitFeeZy;}
			set { _limitFeeZy = value;}
		}                                    
		
		/// <summary>
		/// 限额类别：1-每天限额；2-每次限额
		/// </summary>
		public string LsLimitType
		{
			get { return _lsLimitType;}
			set { _lsLimitType = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}
   
    }  
}           



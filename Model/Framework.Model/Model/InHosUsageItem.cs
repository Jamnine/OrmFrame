

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class InHosUsageItem : BaseModel
    {    
		private string _usageId;  //用法对应BsUsage.Id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _adviceId;  //医嘱ID
		
		private int _lsMarkType;  //医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		
		private double _totality;  //数量
		
		private int _groupNum;  //组号
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private string _usageMemo;  //用法备注
		
		private string _adviceMemo;  //医嘱备注
		
		private string _usageItemId;  //用法项目Id,BsUsageItem.Id
		
		private double _times;  //次数
		
		private DateTime _adviceTime;  //医嘱时间
		
		private string _frequencyId;  //频率对应BsFrequency.Id
		
		private DateTime _chargeTime;  //插入费用时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
                  
		/// <summary>
		/// 用法对应BsUsage.Id
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱ID
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 组号
		/// </summary>
		public int GroupNum
		{
			get { return _groupNum;}
			set { _groupNum = value;}
		}                                    
		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 用法备注
		/// </summary>
		public string UsageMemo
		{
			get { return _usageMemo;}
			set { _usageMemo = value;}
		}                                    
		
		/// <summary>
		/// 医嘱备注
		/// </summary>
		public string AdviceMemo
		{
			get { return _adviceMemo;}
			set { _adviceMemo = value;}
		}                                    
		
		/// <summary>
		/// 用法项目Id,BsUsageItem.Id
		/// </summary>
		public string UsageItemId
		{
			get { return _usageItemId;}
			set { _usageItemId = value;}
		}                                    
		
		/// <summary>
		/// 次数
		/// </summary>
		public double Times
		{
			get { return _times;}
			set { _times = value;}
		}                                    
		
		/// <summary>
		/// 医嘱时间
		/// </summary>
		public DateTime AdviceTime
		{
			get { return _adviceTime;}
			set { _adviceTime = value;}
		}                                    
		
		/// <summary>
		/// 频率对应BsFrequency.Id
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 插入费用时间
		/// </summary>
		public DateTime ChargeTime
		{
			get { return _chargeTime;}
			set { _chargeTime = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           



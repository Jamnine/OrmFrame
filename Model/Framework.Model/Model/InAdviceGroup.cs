

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class InAdviceGroup:BaseModel
	{   
		 
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _usageId;  //用法
		
		private int _groupNum;  //组号
		
		private int _lsMarkType;  //执行单类：1-长期；2-临时；3-其他；4-床位；5-出院带药
		
		private int _maxFrequency;  //最大
		
		private string _memo;  //备注
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _times;  //次数
		
		private string _multifunction;  //医嘱类别|用法ID|次数
		
		private bool _isGroupOnlyOne;  //同组是否只有一种静滴药品
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InAdviceGroup() { }
         
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 用法
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
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
		/// 执行单类：1-长期；2-临时；3-其他；4-床位；5-出院带药
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 最大
		/// </summary>
		public int MaxFrequency
		{
			get { return _maxFrequency;}
			set { _maxFrequency = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 科室ID,BsLocation.Id
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 次数
		/// </summary>
		public string Times
		{
			get { return _times;}
			set { _times = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类别|用法ID|次数
		/// </summary>
		public string Multifunction
		{
			get { return _multifunction;}
			set { _multifunction = value;}
		}                                    
		
		/// <summary>
		/// 同组是否只有一种静滴药品
		/// </summary>
		public bool IsGroupOnlyOne
		{
			get { return _isGroupOnlyOne;}
			set { _isGroupOnlyOne = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		                                  
		        
	}  
}           



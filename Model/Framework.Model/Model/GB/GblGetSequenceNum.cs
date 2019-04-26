

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 记录系统每个模块下一次单据号 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblGetSequenceNum : BaseModel
    {   
		
		
		
		private int _nextSequenceNum;  //下次序列号
		
		private bool _isDayBegin;  //是否每天从YYYYMMDD0001开始
		
		private string _getdateStr;  //字符串日期
		
		private string _nextSequenceStr;  //字符下次序列号
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 下次序列号
		/// </summary>
		public int NextSequenceNum
		{
			get { return _nextSequenceNum;}
			set { _nextSequenceNum = value;}
		}                                    
		
		/// <summary>
		/// 是否每天从YYYYMMDD0001开始
		/// </summary>
		public bool IsDayBegin
		{
			get { return _isDayBegin;}
			set { _isDayBegin = value;}
		}                                    
		
		/// <summary>
		/// 字符串日期
		/// </summary>
		public string GetdateStr
		{
			get { return _getdateStr;}
			set { _getdateStr = value;}
		}                                    
		
		/// <summary>
		/// 字符下次序列号
		/// </summary>
		public string NextSequenceStr
		{
			get { return _nextSequenceStr;}
			set { _nextSequenceStr = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           



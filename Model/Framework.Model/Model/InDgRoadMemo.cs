

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院病人临床路径备注 - 实体类
	/// </summary>
	[Serializable]
	public partial class InDgRoadMemo : BaseModel
	{    
		private string _hospId;  //
		
		private string _roadId;  //临床路径ID
		
		private string _memo;  //说明
		
		private string _adViceId;  //医嘱ID
		
		private int _lsMarkType;  //医嘱类型1-长期；2-临时；3-其他；4-床位；5-出院带药
		
		private string _operId;  //
		
		private DateTime _operTime;  //
		
		private string _dayGroupId;  //
		
		private int _memoType;  //提前1,推迟2,新增3,未做4,删除5,延迟停止医嘱6
		
		private string _roadPatDtlId;  //
		
		private string _titleName;  //原因
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InDgRoadMemo() { }
                               
		
		/// <summary>
		/// 
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 临床路径ID
		/// </summary>
		public string RoadId
		{
			get { return _roadId;}
			set { _roadId = value;}
		}                                    
		
		/// <summary>
		/// 说明
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 医嘱ID
		/// </summary>
		public string AdViceId
		{
			get { return _adViceId;}
			set { _adViceId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类型1-长期；2-临时；3-其他；4-床位；5-出院带药
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DayGroupId
		{
			get { return _dayGroupId;}
			set { _dayGroupId = value;}
		}                                    
		
		/// <summary>
		/// 提前1,推迟2,新增3,未做4,删除5,延迟停止医嘱6
		/// </summary>
		public int MemoType
		{
			get { return _memoType;}
			set { _memoType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string RoadPatDtlId
		{
			get { return _roadPatDtlId;}
			set { _roadPatDtlId = value;}
		}                                    
		
		/// <summary>
		/// 原因
		/// </summary>
		public string TitleName
		{
			get { return _titleName;}
			set { _titleName = value;}
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


